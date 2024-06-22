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
    public partial class frmAddLoan : Form
    {
        private catanaswordEntities _context = new catanaswordEntities();
        private BindingSource _bs;
        DateTime startdate = DateTime.Today;
        DateTime dueDate;
        private int _selectedClientId;
        private decimal loanAmount, deduction, interest, daystopay;
        private decimal _interestedAmount, _recAmount, _payable;
        private string term, loanStatus;
       
        public frmAddLoan()
        {
            InitializeComponent();

            txtLoanAmount.TextChanged += InputChanged;
            txtInterest.TextChanged += InputChanged;
            txtDeduction.TextChanged += InputChanged;
            txtNumberOfPayment.TextChanged += InputChanged;
            txtStatus.TextChanged += InputChanged;

        }
        public frmAddLoan(int selectedClientId, BindingSource bs) : this()
        {
            _bs = bs;
            _selectedClientId = selectedClientId;
        }
        private void InputChanged(object sender, EventArgs e)
        {
            ComputeAndUpdateValue();
        }
        private DateTime calculateDueDate(int daysToAdd, String terms)
        {
            DateTime startdate = DateTime.Today.AddDays(1);

            if (terms == "Daily")

                dueDate = startdate.AddDays(daysToAdd);

            else if (terms == "Weekly")

                dueDate = startdate.AddDays((daysToAdd + 1) * 7);

            else if (terms == "Monthly")

                dueDate = startdate.AddMonths((daysToAdd + 1));

            else if (terms == "Bi-monthly")

                dueDate = startdate.AddDays((daysToAdd + 1) * 15);

            return dueDate;

        }
        private void ComputeAndUpdateValue()
        {
            decimal.TryParse(txtLoanAmount.Text, out loanAmount);
            decimal.TryParse(txtInterest.Text, out interest);
            decimal.TryParse(txtDeduction.Text, out deduction);
            decimal.TryParse(txtNumberOfPayment.Text, out daystopay);

            _interestedAmount = Math.Round(CalculateInterestedAMount(loanAmount, Convert.ToInt32(interest)), 2);
            _recAmount = Math.Round(CalculateReceivable(loanAmount, deduction), 2);
            _payable = Math.Round(CalculatePayable(loanAmount, _interestedAmount), 2);
            term = cboxTerm.Text.ToString();
            loanStatus = "UNPAID";

            txtInterestedAmount.Text = "₱ " + _interestedAmount.ToString();
            txtReceivable.Text = "₱ " + _recAmount.ToString();
            txtPayable.Text = "₱ " + _payable.ToString();
            txtDueDate.Text = calculateDueDate(Convert.ToInt32(daystopay), term).ToString("MM/dd/yyyy");
            txtStatus.Text = loanStatus;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientLoan client = new ClientLoan();

            client.ClientID = _selectedClientId;
            client.LoanAmount = loanAmount;
            client.Interest = Convert.ToInt32(interest);
            client.Term = term;
            client.NumberOfPayment = Convert.ToInt32(daystopay);
            client.Deduction = deduction;
            client.InterestedAmount = _interestedAmount;
            client.ReceivableAmount = _recAmount;
            client.TotalPayable = _payable;
            client.DueDate = calculateDueDate(Convert.ToInt32(daystopay), term);
            client.LoanStatus = loanStatus;

            _context.ClientLoans.Add(client);
            _context.SaveChanges();

            _bs.DataSource = _context.ClientLoans.ToList().Where(cl => cl.ClientID == _selectedClientId)
                                                          .ToList();

            MessageBox.Show("Loan Added Successfully!");

            List<Schedule> schedules = new List<Schedule>();

            for (int i = 1; i <= daystopay; i++)
            {
                Schedule sched = new Schedule();
                sched.LoanID = client.LoanId;
                sched.Collectibles = Math.Round((decimal)client.TotalPayable / daystopay, 2);
                sched.LoanStatus = loanStatus;

                if (term == "Daily")
                {
                    sched.PaymentSchedule = startdate.AddDays(i);
                    schedules.Add(sched);
                }
                else if (term == "Weekly")
                {
                    sched.PaymentSchedule = startdate.AddDays(i * 7);
                    schedules.Add(sched);

                }
                else if (term == "Monthly")
                {
                    sched.PaymentSchedule = startdate.AddMonths(i);
                    schedules.Add(sched);
                }
                else if (term == "Bi-monthly")
                {
                    sched.PaymentSchedule = startdate.AddDays(i * 15);
                    schedules.Add(sched);
                }

            }
            _context.Schedules.AddRange(schedules);
            _context.SaveChanges();

            this.Close();


        }

        private decimal CalculateInterestedAMount(decimal LoanAmount, int Interest)
        {
            return LoanAmount * Interest / 100;
        }
        private decimal CalculateReceivable(decimal LoanAmount, decimal Deduction)
        {
            return LoanAmount - Deduction;
        }
        private decimal CalculatePayable(decimal LoanAmount, decimal _interestedAmount)
        {
            return LoanAmount + _interestedAmount;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmAddLoan_Load(object sender, EventArgs e)
        {
            var client = _context.CLINETINFOes.
               Where(q => q.Id == _selectedClientId).
               FirstOrDefault();

            txtClientID.Text = _selectedClientId.ToString();
        }
    }
}
