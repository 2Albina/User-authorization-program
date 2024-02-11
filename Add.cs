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
    public partial class Add : Form
    {
        private readonly UserRepository _userRepository;
        public Add(UserRepository userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
        }

        private void LoginInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_login_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userName = LoginInput.Text;
            if (_userRepository.HasUser(userName))
            {
                MessageBox.Show("Пользователь с таким именем уже существует.", "Ошибка добавления пользователя", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _userRepository.Create(new User(
                userName,
                PasswordManager.Hash(""),
                false,
                true));

            MessageBox.Show("Пользователь \"" + userName + "\" добавлен.", "Добавление пользователя", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
