
namespace catanafinals
{
    partial class frmPaymentSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DataGridSchedule = new System.Windows.Forms.DataGridView();
            this.paymentScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectiblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridSchedule
            // 
            this.DataGridSchedule.AllowUserToAddRows = false;
            this.DataGridSchedule.AllowUserToDeleteRows = false;
            this.DataGridSchedule.AutoGenerateColumns = false;
            this.DataGridSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentScheduleDataGridViewTextBoxColumn,
            this.collectiblesDataGridViewTextBoxColumn,
            this.loanStatusDataGridViewTextBoxColumn});
            this.DataGridSchedule.DataSource = this.scheduleBindingSource;
            this.DataGridSchedule.Location = new System.Drawing.Point(12, 12);
            this.DataGridSchedule.Name = "DataGridSchedule";
            this.DataGridSchedule.ReadOnly = true;
            this.DataGridSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridSchedule.Size = new System.Drawing.Size(349, 334);
            this.DataGridSchedule.TabIndex = 0;
            this.DataGridSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DataGridSchedule.SelectionChanged += new System.EventHandler(this.DataGridSchedule_SelectionChanged);
            // 
            // paymentScheduleDataGridViewTextBoxColumn
            // 
            this.paymentScheduleDataGridViewTextBoxColumn.DataPropertyName = "PaymentSchedule";
            this.paymentScheduleDataGridViewTextBoxColumn.HeaderText = "PaymentSchedule";
            this.paymentScheduleDataGridViewTextBoxColumn.Name = "paymentScheduleDataGridViewTextBoxColumn";
            this.paymentScheduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collectiblesDataGridViewTextBoxColumn
            // 
            this.collectiblesDataGridViewTextBoxColumn.DataPropertyName = "Collectibles";
            this.collectiblesDataGridViewTextBoxColumn.HeaderText = "Collectibles";
            this.collectiblesDataGridViewTextBoxColumn.Name = "collectiblesDataGridViewTextBoxColumn";
            this.collectiblesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanStatusDataGridViewTextBoxColumn
            // 
            this.loanStatusDataGridViewTextBoxColumn.DataPropertyName = "LoanStatus";
            this.loanStatusDataGridViewTextBoxColumn.HeaderText = "LoanStatus";
            this.loanStatusDataGridViewTextBoxColumn.Name = "loanStatusDataGridViewTextBoxColumn";
            this.loanStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(catanafinals.entities.Schedule);
            // 
            // frmPaymentSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 365);
            this.Controls.Add(this.DataGridSchedule);
            this.Name = "frmPaymentSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPaymentSchedule";
            this.Load += new System.EventHandler(this.frmPaymentSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridSchedule;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectiblesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanStatusDataGridViewTextBoxColumn;
    }
}