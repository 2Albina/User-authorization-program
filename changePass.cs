using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DP1
{
    public partial class changePass : Form
    {
        private readonly User _user;
        private readonly UserRepository _userRepository;
        private readonly UserBoard _parent;
        public changePass(User user, UserRepository userRepository, UserBoard parent)
        {
            _user = user;
            _userRepository = userRepository;
            _parent = parent;
            InitializeComponent();
            if (_user.HasPasswordLimitations)
                MessageBox.Show("Ограничения на пароль:\n" +
                                "Пароль должен содержать как минимум одну строчную и одну прописную букву.",
                    "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_userRepository.Auth(_user.Name, OldPasswordInput.Text))
            {
                MessageBox.Show("Неправильный старый пароль.", "Ошибка смены пароля", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                NewPasswordInput.Text = "";
                return;
            }

            if (NewPasswordInput.Text != ConfirmPasswordInput.Text)
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка смены пароля", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (NewPasswordInput.Text == "")
            {
                MessageBox.Show("Пароли не могут быть пустыми.", "Ошибка смены пароля", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (_user.HasPasswordLimitations && !PasswordManager.HasLimitations(NewPasswordInput.Text))
            {
                MessageBox.Show(
                    "Пароль должен содержать как минимум одну строчную и одну прописную букву.",
                    "Ошибка смены пароля", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new User(_user.Name, PasswordManager.Hash(NewPasswordInput.Text), _user.IsBlocked, _user.HasPasswordLimitations);

            _userRepository.Update(user);
            _parent.PasswordChanged = true;
            MessageBox.Show(
                "Пароль успешно изменен",
                "Смена пароля", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void OldPasswordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
