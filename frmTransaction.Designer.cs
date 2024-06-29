
namespace catanafinals
{
    partial class frmTransaction
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboxPayType = new System.Windows.Forms.ComboBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schedIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectiblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Outstanding Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Term of Payment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Payment Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Transaction Amount:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Olive;
            this.button1.Location = new System.Drawing.Point(122, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 56);
            this.button1.TabIndex = 25;
            this.button1.Text = "PROCEED";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(189, 278);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(218, 25);
            this.txtAmount.TabIndex = 16;
            // 
            // cboxPayType
            // 
            this.cboxPayType.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPayType.FormattingEnabled = true;
            this.cboxPayType.Items.AddRange(new object[] {
            "PARTIAL PAYMENT",
            "FULL PAYMENT"});
            this.cboxPayType.Location = new System.Drawing.Point(189, 225);
            this.cboxPayType.Margin = new System.Windows.Forms.Padding(2);
            this.cboxPayType.Name = "cboxPayType";
            this.cboxPayType.Size = new System.Drawing.Size(218, 25);
            this.cboxPayType.TabIndex = 17;
            // 
            // txtTerm
            // 
            this.txtTerm.Enabled = false;
            this.txtTerm.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerm.Location = new System.Drawing.Point(189, 173);
            this.txtTerm.Margin = new System.Windows.Forms.Padding(2);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.ReadOnly = true;
            this.txtTerm.Size = new System.Drawing.Size(218, 25);
            this.txtTerm.TabIndex = 23;
            // 
            // txtBalance
            // 
            this.txtBalance.Enabled = false;
            this.txtBalance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(189, 119);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(2);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(218, 25);
            this.txtBalance.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 42);
            this.label5.TabIndex = 21;
            this.label5.Text = "Transaction Portal";
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(catanafinals.entities.Schedule);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loanIDDataGridViewTextBoxColumn,
            this.schedIDDataGridViewTextBoxColumn,
            this.paymentScheduleDataGridViewTextBoxColumn,
            this.collectiblesDataGridViewTextBoxColumn,
            this.loanStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scheduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(412, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(441, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // loanIDDataGridViewTextBoxColumn
            // 
            this.loanIDDataGridViewTextBoxColumn.DataPropertyName = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.HeaderText = "LoanID";
            this.loanIDDataGridViewTextBoxColumn.Name = "loanIDDataGridViewTextBoxColumn";
            this.loanIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.loanIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // schedIDDataGridViewTextBoxColumn
            // 
            this.schedIDDataGridViewTextBoxColumn.DataPropertyName = "SchedID";
            this.schedIDDataGridViewTextBoxColumn.HeaderText = "SchedID";
            this.schedIDDataGridViewTextBoxColumn.Name = "schedIDDataGridViewTextBoxColumn";
            this.schedIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxPayType);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboxPayType;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectiblesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanStatusDataGridViewTextBoxColumn;
    }
}