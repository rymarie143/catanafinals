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
    public partial class frmClientLoan : Form
    {
        public catanaswordEntities _context = new catanaswordEntities();
        private int _selectedClientId, _selectedLoanID;
        String Term;
        public frmClientLoan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public frmClientLoan(int selectedClientID, String Fullname) : this()
        {
            _selectedClientId = selectedClientID;
            textBox1.Text = Fullname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _selectedClientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                _selectedLoanID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);

                Term = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAddLoan form = new frmAddLoan(_selectedClientId, clientLoanBindingSource);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPaymentSchedule form = new frmPaymentSchedule(_selectedClientId, _selectedLoanID, textBox1.Text.Trim(), Term, clientLoanBindingSource);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTransaction form = new frmTransaction(Term, _selectedLoanID, _selectedClientId, clientLoanBindingSource);
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmClientLoan_Load(object sender, EventArgs e)
        {

            clientLoanBindingSource.DataSource = _context.ClientLoans
                                                          .Where(cl => cl.ClientID == _selectedClientId)
                                                          .ToList();
            textBox2.Text = dataGridView1.Rows
                                .Cast<DataGridViewRow>()
                                .Sum(t => Convert.ToInt32(t.Cells[2].Value)).ToString();
        }
    }
}
