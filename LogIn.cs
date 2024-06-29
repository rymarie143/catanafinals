using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using catanafinals.entities;


namespace catanafinals
{
    
    public partial class LogIn : Form
    {
        private catanaswordEntities c = new catanaswordEntities();

        public LogIn()
        {
            InitializeComponent();
            comboBox1.Text = "Select User Role";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputUserName = textBox1.Text;
            string inputPassword = textBox2.Text;

            var UserID = c.LoanUserAccounts.Where(user => user.UserName == inputUserName && user.UserPassword == inputPassword).Select(user => user.Id).FirstOrDefault();
            var UserRole = c.LoanUserAccounts.Where(user => user.Id == UserID).Select(user => user.UserRole).FirstOrDefault();

            if (UserRole != null)
            {
                if (UserRole == "Admin")
                {
                    MessageBox.Show("hi admin" + inputUserName + "!");
                }
                else
                {
                    MessageBox.Show("hi user" + inputUserName + "!");
                }

                this.Hide();
                Form1 form = new Form1(UserRole, UserID);
                
                form.ShowDialog();

                
            }
            else MessageBox.Show("not found yas");
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "Select User Role";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createaccount n = new createaccount();
            n.ShowDialog();
        }
    }
}
