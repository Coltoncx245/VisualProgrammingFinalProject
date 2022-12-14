namespace VisualProgrammingFinalProject
{
    partial class BudgetCreatorForm
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
            this.lb_Income = new System.Windows.Forms.ListBox();
            this.lb_Expenses = new System.Windows.Forms.ListBox();
            this.lbl_Income = new System.Windows.Forms.Label();
            this.lbl_Expenses = new System.Windows.Forms.Label();
            this.btn_AddIncome = new System.Windows.Forms.Button();
            this.btn_AddExpense = new System.Windows.Forms.Button();
            this.btn_SaveBudget = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_BudgetName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Income
            // 
            this.lb_Income.FormattingEnabled = true;
            this.lb_Income.ItemHeight = 16;
            this.lb_Income.Location = new System.Drawing.Point(26, 49);
            this.lb_Income.Name = "lb_Income";
            this.lb_Income.Size = new System.Drawing.Size(120, 276);
            this.lb_Income.TabIndex = 0;
            // 
            // lb_Expenses
            // 
            this.lb_Expenses.FormattingEnabled = true;
            this.lb_Expenses.ItemHeight = 16;
            this.lb_Expenses.Location = new System.Drawing.Point(186, 49);
            this.lb_Expenses.Name = "lb_Expenses";
            this.lb_Expenses.Size = new System.Drawing.Size(120, 276);
            this.lb_Expenses.TabIndex = 1;
            // 
            // lbl_Income
            // 
            this.lbl_Income.AutoSize = true;
            this.lbl_Income.Location = new System.Drawing.Point(61, 30);
            this.lbl_Income.Name = "lbl_Income";
            this.lbl_Income.Size = new System.Drawing.Size(51, 16);
            this.lbl_Income.TabIndex = 2;
            this.lbl_Income.Text = "Income";
            // 
            // lbl_Expenses
            // 
            this.lbl_Expenses.AutoSize = true;
            this.lbl_Expenses.Location = new System.Drawing.Point(214, 30);
            this.lbl_Expenses.Name = "lbl_Expenses";
            this.lbl_Expenses.Size = new System.Drawing.Size(67, 16);
            this.lbl_Expenses.TabIndex = 3;
            this.lbl_Expenses.Text = "Expenses";
            // 
            // btn_AddIncome
            // 
            this.btn_AddIncome.Location = new System.Drawing.Point(26, 331);
            this.btn_AddIncome.Name = "btn_AddIncome";
            this.btn_AddIncome.Size = new System.Drawing.Size(120, 23);
            this.btn_AddIncome.TabIndex = 4;
            this.btn_AddIncome.Text = "Add Income";
            this.btn_AddIncome.UseVisualStyleBackColor = true;
            this.btn_AddIncome.Click += new System.EventHandler(this.btn_AddIncome_Click);
            // 
            // btn_AddExpense
            // 
            this.btn_AddExpense.Location = new System.Drawing.Point(186, 331);
            this.btn_AddExpense.Name = "btn_AddExpense";
            this.btn_AddExpense.Size = new System.Drawing.Size(120, 23);
            this.btn_AddExpense.TabIndex = 5;
            this.btn_AddExpense.Text = "Add Expense";
            this.btn_AddExpense.UseVisualStyleBackColor = true;
            this.btn_AddExpense.Click += new System.EventHandler(this.btn_AddExpense_Click);
            // 
            // btn_SaveBudget
            // 
            this.btn_SaveBudget.Location = new System.Drawing.Point(231, 383);
            this.btn_SaveBudget.Name = "btn_SaveBudget";
            this.btn_SaveBudget.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveBudget.TabIndex = 6;
            this.btn_SaveBudget.Text = "Save";
            this.btn_SaveBudget.UseVisualStyleBackColor = true;
            this.btn_SaveBudget.Click += new System.EventHandler(this.btn_SaveBudget_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // tb_BudgetName
            // 
            this.tb_BudgetName.Location = new System.Drawing.Point(77, 383);
            this.tb_BudgetName.Name = "tb_BudgetName";
            this.tb_BudgetName.Size = new System.Drawing.Size(148, 22);
            this.tb_BudgetName.TabIndex = 8;
            // 
            // BudgetCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.tb_BudgetName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SaveBudget);
            this.Controls.Add(this.btn_AddExpense);
            this.Controls.Add(this.btn_AddIncome);
            this.Controls.Add(this.lbl_Expenses);
            this.Controls.Add(this.lbl_Income);
            this.Controls.Add(this.lb_Expenses);
            this.Controls.Add(this.lb_Income);
            this.Name = "BudgetCreatorForm";
            this.Text = "Budget Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Income;
        private System.Windows.Forms.ListBox lb_Expenses;
        private System.Windows.Forms.Label lbl_Income;
        private System.Windows.Forms.Label lbl_Expenses;
        private System.Windows.Forms.Button btn_AddIncome;
        private System.Windows.Forms.Button btn_AddExpense;
        private System.Windows.Forms.Button btn_SaveBudget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_BudgetName;
    }
}