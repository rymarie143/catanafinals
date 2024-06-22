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
    public partial class frmTransactionHistory : Form
    {
        public catanaswordEntities _context = new catanaswordEntities();
        public int _loanID;
        public frmTransactionHistory()
        {
            InitializeComponent();
        }
        public frmTransactionHistory(int selectedloanID) : this()
        {
            _loanID = selectedloanID;
        }

        private void frmTransactionHistory_Load(object sender, EventArgs e)
        {
            transactBindingSource.DataSource = _context.Transacts.
               Where(t => t.LoanID == _loanID).ToList();
        }
    }
}
