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
    public partial class frmPaymentSchedule : Form
    {
        private catanaswordEntities _context = new catanaswordEntities();
        public int _selectedloanID, _selectedSchedID;
       
        public frmPaymentSchedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double bal = GetBalance();
            //OutstandingBalance = Convert.ToDecimal(bal);
            //RowCount = DataGridSchedule.Rows.Count;

            //int temp = 1;

            //for (int i = 0; i < RowCount; i++)
            //{
            //    if ((string)DataGridSchedule.Rows[i].Cells[2].Value == "UNPAID") temp = 0;
            //}

            //if (temp == 0)
            //{
            //    frmTransaction form = new frmTransaction(Term, _selectedloanID, _selectedClientID, _bs, scheduleBindingSource);
            //    form.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("THIS LOAN HAS NO EXISTING OUTSTANDING BALANCE");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmTransactionHistory form = new frmTransactionHistory(_selectedloanID);
            //form.ShowDialog();
        }

        public frmPaymentSchedule(int selectedLoanID) : this()
        {
            _selectedloanID = selectedLoanID;
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridSchedule_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridSchedule.SelectedRows.Count > 0)
                _selectedSchedID = Convert.ToInt32(DataGridSchedule.SelectedRows[0].Cells[1].Value);
        }

        private void frmPaymentSchedule_Load(object sender, EventArgs e)
        {
            scheduleBindingSource.DataSource = _context.Schedules.Where(s => s.LoanID == _selectedloanID).ToList();
           
        }
    }
}
