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
    
    public partial class frmAddClient : Form
    {
        public catanaswordEntities _context = new catanaswordEntities();
        private BindingSource _bs;
        public frmAddClient()
        {
            InitializeComponent();
        }
        public frmAddClient(BindingSource bs) : this()
        {
            _bs = bs;
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLINETINFO client = new CLINETINFO();
            client.FirstName = textBox1.Text.Trim();
            client.LastName = textBox2.Text.Trim();
            client.Residency_ = textBox3.Text.Trim();
            client.Age = Convert.ToInt32(textBox4.Text.Trim());

            _context.CLINETINFOes.Add(client);
            _context.SaveChanges();

            _bs.DataSource = _context.CLINETINFOes.ToList();

            MessageBox.Show("Client Added Successfully!");

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
