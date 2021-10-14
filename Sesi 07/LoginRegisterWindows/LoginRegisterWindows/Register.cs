using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterWindows
{
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //db.Execute("INSER INTO user_info (id, names, username, password) VALUES (NULL, '" + edName.Text + "', '" + edUsername.Text + "', '" + edPassword.Text + "'");
            db.ExecuteSql("INSERT INTO `user_info` (`id`, `names`, `username`, `password`) VALUES (NULL, '" + edName.Text + "', '" + edUsername.Text + "', '" + edPassword.Text + "')");

            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Form1 login = new Form1();
            //login.Show();
        }
    }
}
