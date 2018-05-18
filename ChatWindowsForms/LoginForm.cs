using Business.Logic;
using Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatWindowsForms
{
    public partial class LoginForm : Form
    {
        LoginBusiness loginBusiness;
        public LoginForm()
        {
            InitializeComponent();
            this.loginBusiness = new LoginBusiness();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = this.loginBusiness.Login(this.inputUser.Text, this.inputPassword.Text);
            if (user.Userid > 0)
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            else
            {
                this.lblErrorLogin.Text = "El usuario o la contraseña son erroneos";
            }
        }
    }
}
