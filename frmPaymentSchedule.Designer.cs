
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.DataGridSchedule.Location = new System.Drawing.Point(12, 58);
            this.DataGridSchedule.Name = "DataGridSchedule";
            this.DataGridSchedule.ReadOnly = true;
            this.DataGridSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridSchedule.Size = new System.Drawing.Size(349, 334);
            this.DataGridSchedule.TabIndex = 0;
            this.DataGridSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loan ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Transact";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "History";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.ClientSize = new System.Drawing.Size(373, 404);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridSchedule);
            this.Name = "frmPaymentSchedule";
            this.Text = "frmPaymentSchedule";
            this.Load += new System.EventHandler(this.frmPaymentSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridSchedule;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectiblesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loanStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}