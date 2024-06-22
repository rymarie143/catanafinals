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
    public partial class frmTransaction : Form
    {
        public catanaswordEntities _context = new catanaswordEntities();
        public int _rowCount, _loanID, _clientID;
        BindingSource _clientLoanBS, _scheduleBS;
        public frmTransaction()
        {
            InitializeComponent();
        }
        public frmTransaction(String Term, int loanID, int clientID, BindingSource loan) : this()
        {
            txtTerm.Text = Term.ToString();
            _loanID = loanID;
            _clientID = clientID;
            _clientLoanBS = loan;
        }
        public frmTransaction(String Term, int loanID, int clientID, BindingSource loan, BindingSource sched) : this()
        {
            txtTerm.Text = Term.ToString();
            _loanID = loanID;
            _clientID = clientID;
            _clientLoanBS = loan;
            _scheduleBS = sched;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transact transaction = new Transact();

            transaction.LoanID = _loanID;
            transaction.PaymentType = cboxPayType?.Text.Trim();
            transaction.PaymentAmount = Convert.ToDecimal(txtAmount?.Text);
            transaction.TransactionDate = DateTime.Today;
            _context.Transacts.Add(transaction);
            _context.SaveChanges();

            decimal? collectibles;
            decimal? RemainingAmount = Decimal.Parse(txtAmount.Text);
            decimal OutstandingBal = 0;
            if (cboxPayType.Text == "PARTIAL PAYMENT")
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    collectibles = (decimal?)dataGridView1.Rows[i].Cells[3].Value;
                    if (RemainingAmount > collectibles && (String)dataGridView1.Rows[i].Cells[4].Value == "UNPAID")
                    {
                        RemainingAmount = RemainingAmount - collectibles;
                        dataGridView1.Rows[i].Cells[4].Value = "PAID";
                        dataGridView1.Rows[i].Cells[3].Value = Convert.ToDecimal(0);

                    }
                    else if (collectibles > RemainingAmount && RemainingAmount != 0 && (String)dataGridView1.Rows[i].Cells[4].Value == "UNPAID")
                    {
                        collectibles = collectibles - RemainingAmount;
                        RemainingAmount = 0;
                        dataGridView1.Rows[i].Cells[3].Value = collectibles;
                    }
                    else if (RemainingAmount == 0) break;
                }

                _context.SaveChanges();
            }
            else if (cboxPayType.Text == "FULL PAYMENT")
            {
                decimal? PaymentAmount = Convert.ToDecimal(txtAmount.Text);
                decimal? Balance = Convert.ToDecimal(txtBalance.Text);
                RemainingAmount = PaymentAmount;
                collectibles = Balance;

                if (PaymentAmount < Balance)
                {
                    MessageBox.Show("Insufficient Amount to Complete Full Payment\nSwitch Payment Type");
                    txtBalance.Text = OutstandingBal.ToString();
                }
                else if (collectibles == 0)
                {
                    MessageBox.Show("Loan is Fully Paid");
                }
                else if (PaymentAmount == Balance || PaymentAmount > Balance)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[4].Value = "PAID";
                        dataGridView1.Rows[i].Cells[3].Value = Convert.ToDecimal(0);
                        RemainingAmount = PaymentAmount - collectibles;
                    }
                    MessageBox.Show("Transaction Complete\nCollect Change: ₱ " + RemainingAmount);
                }
                else { MessageBox.Show("Enter Valid Amount"); }

            }
            _context.SaveChanges();
            scheduleBindingSource.DataSource = _context.Schedules.Where(s => s.LoanID == _loanID).ToList();
            // Update Outstanding Balance    
            txtBalance.Text = GetBalance().ToString();
            txtAmount.Text = "";
            cboxPayType.Text = "Select Payment Type";

            //Update  Loan Status
            UpdateSatus();

            //Update Table Values
            _clientLoanBS.DataSource = _context.ClientLoans.Where(l => l.ClientID == _clientID).ToList();

            if (_scheduleBS != null)
            {
                _scheduleBS.DataSource = _context.Schedules.Where(l => l.LoanID == _loanID).ToList();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            scheduleBindingSource.DataSource = _context.Schedules.Where(s => s.LoanID == _loanID).ToList();

            txtBalance.Text = GetBalance().ToString();
            cboxPayType.Text = "Select Payment Type";
        }
        private decimal GetBalance()
        {
            scheduleBindingSource.DataSource = _context.Schedules
                                              .Where(cl => cl.LoanID == _loanID)
                                              .ToList();

            decimal sum = (decimal)dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells[3].Value != null)
                .Sum(row => Convert.ToDouble(row.Cells[3].Value));

            return sum;
        }
        private void UpdateSatus()
        {
            var clientloan = _context.ClientLoans.Where(l => l.LoanId == _loanID).FirstOrDefault();

            int temp = 1;
            if (clientloan != null)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if ((String)dataGridView1.Rows[j].Cells[4].Value == "UNPAID")
                    {
                        temp = 0;
                    }
                }
                if (temp != 0)
                {
                    clientloan.LoanStatus = "PAID";
                    _context.SaveChanges();
                }
            }
        }

    }
}
