using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP1
{
    public partial class Check : Form
    {
        private readonly User _user;
        private readonly UserRepository _userRepository;
        private List<User> _users;
        public int _index = 0;

        public Check(User user, UserRepository userRepository)
        {
            _user = user;
            _userRepository = userRepository;
            InitializeComponent();

            _users = _userRepository.GetAllUsers();
            _index = 0;
            UpdateView();
        }

        private void UpdateView()
        {
            var user = _users[_index];

            LoginOutput.Text = user.Name;

            IsBlockedCheckBox.Checked = user.IsBlocked;
            IsBlockedCheckBox.Enabled = user.Name != "ADMIN";

            PasswordRestrictionCheckBox.Checked = user.HasPasswordLimitations;

            PrevButton.Enabled = _index != 0;
            NextButton.Enabled = _index != _users.Count - 1;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var user = _users[_index];

            _userRepository.Update(new User(
                LoginOutput.Text,
                user.Password,
                IsBlockedCheckBox.Checked,
                PasswordRestrictionCheckBox.Checked));

            _users = _userRepository.GetAllUsers();
            MessageBox.Show("Пользователь \"" + LoginOutput.Text + "\" сохранен.", "Сохрание пользователя", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            _index = 0;
            UpdateView();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            --_index;
            UpdateView();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ++_index;
            UpdateView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
