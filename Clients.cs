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
    public partial class Clients : Form
    {
        public catanaswordEntities _context = new catanaswordEntities();
        private int _selectedClientId;

        String FullName, firstname, lastname;
        public Clients(List<CLINETINFO> _source)
        {
            InitializeComponent();
            cLINETINFOBindingSource.DataSource = _source;
        }
        private void Clients_Load(object sender, EventArgs e)
        {
            
        }
        public String getClientFullName(int clientId)
        {
            if (dataGridView1.SelectedRows.Count > 0 && _selectedClientId == clientId)
            {
                firstname = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                lastname = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
            }

            return FullName = $" {firstname} " + $" {lastname} ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cLINETINFOBindingSource.DataSource = _context.CLINETINFOes
              .Where(q => q.FirstName.Contains(txtsearch.Text)
               || q.LastName.Contains(txtsearch.Text)
               || q.Residency_.Contains(txtsearch.Text)
               || q.Id.ToString().Contains(txtsearch.Text)).ToList();
        }

        

        private void cLINETINFOBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var client = _context.CLINETINFOes.
                    Where(q => q.Id == _selectedClientId).
                    FirstOrDefault();

            _context.CLINETINFOes.Remove(client);
            _context.SaveChanges();

            MessageBox.Show("Client Deleted Successfully!");

            cLINETINFOBindingSource.DataSource = _context.CLINETINFOes.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             frmUpdateClient form = new frmUpdateClient(_selectedClientId, cLINETINFOBindingSource);
            form.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)

                _selectedClientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            getClientFullName(_selectedClientId);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmClientLoan form = new frmClientLoan(_selectedClientId, FullName);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (dataGridView1.SelectedRows.Count > 0)

        //        _selectedClientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

        //    getClientFullName(_selectedClientId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddClient form = new frmAddClient(cLINETINFOBindingSource);
            form.ShowDialog();
        }
    }
}
