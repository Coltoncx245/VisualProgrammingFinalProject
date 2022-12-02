namespace VisualProgrammingFinalProject
{
    partial class NewIncomeBill
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_IncomeName = new System.Windows.Forms.TextBox();
            this.tb_IncomeAmount = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.cal_NewIncomeCalendar = new System.Windows.Forms.MonthCalendar();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.cb_Recurring = new System.Windows.Forms.CheckBox();
            this.ud_Recurring = new System.Windows.Forms.DomainUpDown();
            this.btn_SubmitNewIncomeBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(12, 29);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 16);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // tb_IncomeName
            // 
            this.tb_IncomeName.Location = new System.Drawing.Point(78, 23);
            this.tb_IncomeName.Name = "tb_IncomeName";
            this.tb_IncomeName.Size = new System.Drawing.Size(219, 22);
            this.tb_IncomeName.TabIndex = 1;
            // 
            // tb_IncomeAmount
            // 
            this.tb_IncomeAmount.Location = new System.Drawing.Point(78, 56);
            this.tb_IncomeAmount.Name = "tb_IncomeAmount";
            this.tb_IncomeAmount.Size = new System.Drawing.Size(111, 22);
            this.tb_IncomeAmount.TabIndex = 3;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(12, 62);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(52, 16);
            this.lbl_Amount.TabIndex = 2;
            this.lbl_Amount.Text = "Amount";
            // 
            // cal_NewIncomeCalendar
            // 
            this.cal_NewIncomeCalendar.Location = new System.Drawing.Point(35, 115);
            this.cal_NewIncomeCalendar.MaxSelectionCount = 1;
            this.cal_NewIncomeCalendar.Name = "cal_NewIncomeCalendar";
            this.cal_NewIncomeCalendar.TabIndex = 5;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(14, 90);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(36, 16);
            this.lbl_Date.TabIndex = 6;
            this.lbl_Date.Text = "Date";
            // 
            // cb_Recurring
            // 
            this.cb_Recurring.AutoSize = true;
            this.cb_Recurring.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_Recurring.Location = new System.Drawing.Point(17, 361);
            this.cb_Recurring.Name = "cb_Recurring";
            this.cb_Recurring.Size = new System.Drawing.Size(87, 20);
            this.cb_Recurring.TabIndex = 7;
            this.cb_Recurring.Text = "Recurring";
            this.cb_Recurring.UseVisualStyleBackColor = true;
            this.cb_Recurring.CheckedChanged += new System.EventHandler(this.cb_Recurring_CheckedChanged);
            // 
            // ud_Recurring
            // 
            this.ud_Recurring.Items.Add("Daily");
            this.ud_Recurring.Items.Add("Weekly");
            this.ud_Recurring.Items.Add("Bi-Weekly");
            this.ud_Recurring.Items.Add("Monthly");
            this.ud_Recurring.Items.Add("Yearly");
            this.ud_Recurring.Location = new System.Drawing.Point(110, 359);
            this.ud_Recurring.Name = "ud_Recurring";
            this.ud_Recurring.Size = new System.Drawing.Size(120, 22);
            this.ud_Recurring.TabIndex = 8;
            this.ud_Recurring.Visible = false;
            // 
            // btn_SubmitNewIncomeBill
            // 
            this.btn_SubmitNewIncomeBill.Location = new System.Drawing.Point(155, 412);
            this.btn_SubmitNewIncomeBill.Name = "btn_SubmitNewIncomeBill";
            this.btn_SubmitNewIncomeBill.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitNewIncomeBill.TabIndex = 9;
            this.btn_SubmitNewIncomeBill.Text = "Submit";
            this.btn_SubmitNewIncomeBill.UseVisualStyleBackColor = true;
            this.btn_SubmitNewIncomeBill.Click += new System.EventHandler(this.btn_SubmitNewIncomeBill_Click);
            // 
            // NewIncomeBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 469);
            this.Controls.Add(this.btn_SubmitNewIncomeBill);
            this.Controls.Add(this.ud_Recurring);
            this.Controls.Add(this.cb_Recurring);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.cal_NewIncomeCalendar);
            this.Controls.Add(this.tb_IncomeAmount);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.tb_IncomeName);
            this.Controls.Add(this.lbl_Name);
            this.Name = "NewIncomeBill";
            this.Text = "New Income/Expense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_IncomeName;
        private System.Windows.Forms.TextBox tb_IncomeAmount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.MonthCalendar cal_NewIncomeCalendar;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.CheckBox cb_Recurring;
        private System.Windows.Forms.DomainUpDown ud_Recurring;
        private System.Windows.Forms.Button btn_SubmitNewIncomeBill;
    }
}