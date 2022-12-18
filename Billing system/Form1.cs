using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {

            string user, pass;
            user =  txtUser.Text;
            pass = txtPass.Text;

            if (user == "admin"&& pass == "pass")
                {
                MessageBox.Show("LOGIN!!! SUCCESSFUL");
                    this.Hide();
                    main ss = new main();
                    ss.Show();
                }
            
            else
            {
                MessageBox.Show("INVALID CREDENTIALS ! TRY AGAIN >_<");
            }
        }
    }
}
