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
    public partial class frmUpdateClient : Form
    {
        private catanaswordEntities _context = new catanaswordEntities();
        private BindingSource _bs;
        private int _selectedClientId;
        private BindingSource _clientBindingSource;
        public frmUpdateClient()
        {
            InitializeComponent();
        }
        public frmUpdateClient(int selectedClientID, BindingSource bs) : this()
        {
            _bs = bs;
            _selectedClientId = selectedClientID;
        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
            var client = _context.CLINETINFOes.
            Where(q => q.Id == _selectedClientId).
              FirstOrDefault();

            textBox1.Text = client.FirstName;
            textBox2.Text = client.LastName;
            textBox3.Text = client.Residency_;
            textBox4.Text = client.Age.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = _context.CLINETINFOes.
                  Where(q => q.Id == _selectedClientId).
               FirstOrDefault();

            client.FirstName = textBox1.Text.Trim();
            client.LastName = textBox2.Text.Trim();
            client.Residency_ = textBox3.Text.Trim();
            client.Age = Convert.ToInt32(textBox4.Text.Trim());

            _context.SaveChanges();

            _bs.DataSource = _context.CLINETINFOes.ToList();

            MessageBox.Show("Client Information Updated Successfully!");

            this.Close();
        }
    }
}
