namespace VisualProgrammingFinalProject
{
    partial class NewIncomeForm
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
            this.btn_SubmitNewIncome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(9, 24);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // tb_IncomeName
            // 
            this.tb_IncomeName.Location = new System.Drawing.Point(58, 19);
            this.tb_IncomeName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_IncomeName.Name = "tb_IncomeName";
            this.tb_IncomeName.Size = new System.Drawing.Size(165, 20);
            this.tb_IncomeName.TabIndex = 1;
            this.tb_IncomeName.TextChanged += new System.EventHandler(this.tb_IncomeName_TextChanged);
            // 
            // tb_IncomeAmount
            // 
            this.tb_IncomeAmount.Location = new System.Drawing.Point(58, 46);
            this.tb_IncomeAmount.Margin = new System.Windows.Forms.Padding(2);
            this.tb_IncomeAmount.Name = "tb_IncomeAmount";
            this.tb_IncomeAmount.Size = new System.Drawing.Size(84, 20);
            this.tb_IncomeAmount.TabIndex = 3;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(9, 50);
            this.lbl_Amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_Amount.TabIndex = 2;
            this.lbl_Amount.Text = "Amount";
            // 
            // cal_NewIncomeCalendar
            // 
            this.cal_NewIncomeCalendar.Location = new System.Drawing.Point(58, 73);
            this.cal_NewIncomeCalendar.Margin = new System.Windows.Forms.Padding(7);
            this.cal_NewIncomeCalendar.MaxSelectionCount = 1;
            this.cal_NewIncomeCalendar.Name = "cal_NewIncomeCalendar";
            this.cal_NewIncomeCalendar.TabIndex = 5;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(10, 73);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(30, 13);
            this.lbl_Date.TabIndex = 6;
            this.lbl_Date.Text = "Date";
            // 
            // cb_Recurring
            // 
            this.cb_Recurring.AutoSize = true;
            this.cb_Recurring.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_Recurring.Location = new System.Drawing.Point(13, 251);
            this.cb_Recurring.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Recurring.Name = "cb_Recurring";
            this.cb_Recurring.Size = new System.Drawing.Size(72, 17);
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
            this.ud_Recurring.Location = new System.Drawing.Point(82, 249);
            this.ud_Recurring.Margin = new System.Windows.Forms.Padding(2);
            this.ud_Recurring.Name = "ud_Recurring";
            this.ud_Recurring.Size = new System.Drawing.Size(90, 20);
            this.ud_Recurring.TabIndex = 8;
            this.ud_Recurring.Visible = false;
            // 
            // btn_SubmitNewIncome
            // 
            this.btn_SubmitNewIncome.Location = new System.Drawing.Point(116, 292);
            this.btn_SubmitNewIncome.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SubmitNewIncome.Name = "btn_SubmitNewIncome";
            this.btn_SubmitNewIncome.Size = new System.Drawing.Size(56, 19);
            this.btn_SubmitNewIncome.TabIndex = 9;
            this.btn_SubmitNewIncome.Text = "Submit";
            this.btn_SubmitNewIncome.UseVisualStyleBackColor = true;
            this.btn_SubmitNewIncome.Click += new System.EventHandler(this.btn_SubmitNewIncome_Click);
            // 
            // NewIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 340);
            this.Controls.Add(this.btn_SubmitNewIncome);
            this.Controls.Add(this.ud_Recurring);
            this.Controls.Add(this.cb_Recurring);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.cal_NewIncomeCalendar);
            this.Controls.Add(this.tb_IncomeAmount);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.tb_IncomeName);
            this.Controls.Add(this.lbl_Name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewIncomeForm";
            this.Text = "NewIncomeForm";
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
        private System.Windows.Forms.Button btn_SubmitNewIncome;
    }
}