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
        public int _selectedloanID, _selectedSchedID, _selectedClientID, RowCount;
        public decimal OutstandingBalance;
        BindingSource _bs;
        String ClientFullName, Term;
        public frmPaymentSchedule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bal = GetBalance();
            OutstandingBalance = Convert.ToDecimal(bal);
            RowCount = DataGridSchedule.Rows.Count;

            int temp = 1;

            for (int i = 0; i < RowCount; i++)
            {
                if ((string)DataGridSchedule.Rows[i].Cells[2].Value == "UNPAID") temp = 0;
            }

            if (temp == 0)
            {
                frmTransaction form = new frmTransaction(Term, _selectedloanID, _selectedClientID, _bs, scheduleBindingSource);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("THIS LOAN HAS NO EXISTING OUTSTANDING BALANCE");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTransactionHistory form = new frmTransactionHistory(_selectedloanID);
            form.ShowDialog();
        }

        public frmPaymentSchedule(int selectedClientID, int selectedLoanID, String Fullname, String term, BindingSource bs) : this()
        {
            _selectedloanID = selectedLoanID;
            _selectedClientID = selectedClientID;
            ClientFullName = Fullname;
            Term = term;
            _bs = bs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private double GetBalance()
        {
            scheduleBindingSource.DataSource = _context.Schedules
                                              .Where(cl => cl.LoanID == _selectedloanID)
                                              .ToList();

            double sum = DataGridSchedule.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells[1].Value != null)
                .Sum(row => Convert.ToDouble(row.Cells[1].Value));

            return sum;
        }


        private void frmPaymentSchedule_Load(object sender, EventArgs e)
        {
            scheduleBindingSource.DataSource = _context.Schedules.Where(s => s.LoanID == _selectedloanID).ToList();
            textBox2.Text = _selectedloanID.ToString();
            textBox1.Text = ClientFullName;
        }
    }
}
