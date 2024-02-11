using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP1
{
    public partial class Login : Form
    {
        private int _wrongInputCount = 0;
        private readonly UserRepository _userRepository = new UserRepository();

        public Login()
        {
            InitializeComponent();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            //Hide();
            Close();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            var login = LoginInput.Text;
            var password = PasswordInput.Text;
            var user = _userRepository.GetUser(login);

            if (user != null) {
                if (user.IsBlocked)
                {
                    MessageBox.Show("Пользователь заблокирован!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_userRepository.Auth(login, password))
                {
                    UserBoard client = new UserBoard(user, _userRepository, PasswordInput.Text == "", this);
                    Hide();
                    client.Show();
                    if (PasswordInput.Text == "")
                    {
                        MessageBox.Show("После первого входа в систему Вам следует сменить пароль.", "Первый вход в систему", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        client.PasswordChanged = false;
                        client.ChangePasswordAction();
                    }
                    else if (user.HasPasswordLimitations && !PasswordManager.HasLimitations(PasswordInput.Text))
                    {
                        MessageBox.Show("ADMIN включает правила ограничения доступа к паролю для вашей учетной записи. Вам следует сменить пароль.", "Войдите в систему", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        client.PasswordChanged = false;
                        client.ChangePasswordAction();
                    }

                    if (!client.PasswordChanged)
                    {
                        Show();
                        client.Close();
                    }

                    _wrongInputCount = 0;
                    AttemptLabel.Text = "" + (3 - _wrongInputCount);
                }
                else
                {
                    _wrongInputCount++;
                    if (_wrongInputCount >= 3)
                    {
                        MessageBox.Show("Превышен лимит попыток входа в систему. Вынужденный выход.", "Ошибка входа", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop);
                        Application.Exit();
                    }

                    MessageBox.Show("Неправильный пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    PasswordInput.Text = "";
                    AttemptLabel.Text = "" + (3 - _wrongInputCount);
                }
            }
        }
    }
}
