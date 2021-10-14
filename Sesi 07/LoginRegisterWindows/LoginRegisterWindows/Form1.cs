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
    public partial class Form1 : Form
    {
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //start register window
            Register register = new Register();
            register.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //db.ExecuteSql("SELECT * FROM `user_info` WHERE `username` = '" + edUsername.Text + "' AND `password` = '" + edPassword.Text + "'");
            db.ExecuteSelect("SELECT * FROM `user_info` WHERE username='" + edUsername.Text + "' and password='" + edPassword.Text + "'");


            if (db.Count() == 1)
            {
                MessageBox.Show("Success You will Login as " + db.Results(0, "names"));
            }
            else
            {
                MessageBox.Show("Wrong username and password combination");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
