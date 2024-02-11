using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DP1
{
    public partial class UserBoard : Form
    {
        private readonly User _user;

        private readonly UserRepository _userRepository;

        private Login _logInForm;

        //private List<User> _users;

        public bool PasswordChanged = true;
        public UserBoard(User user, UserRepository userRepository, bool needToChangePassword,
            Login logInForm)
        {
            _user = user;
            _userRepository = userRepository;
            _logInForm = logInForm;
            InitializeComponent();

            _user = _userRepository.GetUser(_user.Name);
            var isAdmin = _user.Name == "ADMIN";
            bCheck.Visible = isAdmin;
            bAdd.Visible = isAdmin;
            просмотрПользователейToolStripMenuItem.Visible = isAdmin;
            добавитьПользователяToolStripMenuItem.Visible = isAdmin;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.ShowDialog();
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordAction();
        }

        private void просмотрПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form check = new Check(_user, _userRepository);
            check.ShowDialog();
        }

        private void добавитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form add = new Add(_userRepository);
            add.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ChangePasswordAction()
        {
            Form change = new changePass(_user, _userRepository, this);
            change.ShowDialog();
        }

        private void bChangePass_Click(object sender, EventArgs e)
        {
            ChangePasswordAction();
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            Form check = new Check(_user, _userRepository);
            check.ShowDialog();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Form add = new Add(_userRepository);
            add.ShowDialog();
        }
    }
}
