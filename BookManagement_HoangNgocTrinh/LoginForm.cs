using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_HoangNgocTrinh
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void grbSearchCriteria_Enter(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblBookName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAccountService service = new();
            UserAccount acc = service.CheckLogin(txtEmail.Text, txtPass.Text);

            if(acc == null)
            {
                MessageBox.Show("Email does not exits!!!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(acc.Role == -1)
            {
                MessageBox.Show("Wrong password!!!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(acc.Role == 3)
            {
                MessageBox.Show("You have no permisstion to access this function!!!", "Wrong credentials", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            BookManagerMainForm f = new();
            f.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
