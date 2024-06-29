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
    public partial class createaccount : Form
    {
        private catanaswordEntities c = new catanaswordEntities();
        public createaccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoanUserAccount user = new LoanUserAccount();

            user.UserName = textBox1.Text;
            user.UserRole = comboBox1.Text;
            user.UserPassword = textBox2.Text;

            c.LoanUserAccounts.Add(user);

            c.SaveChanges();

            MessageBox.Show("created account yas?");
            this.Close();
        }
    }
}
