namespace VisualProgrammingFinalProject
{
    partial class SelectBudgetForm
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
            this.lb_AvailableBudgets = new System.Windows.Forms.ListBox();
            this.btn_LoadBudget = new System.Windows.Forms.Button();
            this.btnSaveBudget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_AvailableBudgets
            // 
            this.lb_AvailableBudgets.FormattingEnabled = true;
            this.lb_AvailableBudgets.Location = new System.Drawing.Point(41, 25);
            this.lb_AvailableBudgets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_AvailableBudgets.Name = "lb_AvailableBudgets";
            this.lb_AvailableBudgets.Size = new System.Drawing.Size(138, 303);
            this.lb_AvailableBudgets.TabIndex = 0;
            // 
            // btn_LoadBudget
            // 
            this.btn_LoadBudget.Location = new System.Drawing.Point(41, 343);
            this.btn_LoadBudget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LoadBudget.Name = "btn_LoadBudget";
            this.btn_LoadBudget.Size = new System.Drawing.Size(137, 19);
            this.btn_LoadBudget.TabIndex = 1;
            this.btn_LoadBudget.Text = "Load Budget";
            this.btn_LoadBudget.UseVisualStyleBackColor = true;
            this.btn_LoadBudget.Click += new System.EventHandler(this.btn_LoadBudget_Click);
            // 
            // btnSaveBudget
            // 
            this.btnSaveBudget.Location = new System.Drawing.Point(42, 366);
            this.btnSaveBudget.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveBudget.Name = "btnSaveBudget";
            this.btnSaveBudget.Size = new System.Drawing.Size(137, 19);
            this.btnSaveBudget.TabIndex = 2;
            this.btnSaveBudget.Text = "Save Budget";
            this.btnSaveBudget.UseVisualStyleBackColor = true;
            this.btnSaveBudget.Click += new System.EventHandler(this.btnSaveBudget_Click);
            // 
            // SelectBudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 400);
            this.Controls.Add(this.btnSaveBudget);
            this.Controls.Add(this.btn_LoadBudget);
            this.Controls.Add(this.lb_AvailableBudgets);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SelectBudgetForm";
            this.Text = "SelectBudgetForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_AvailableBudgets;
        private System.Windows.Forms.Button btn_LoadBudget;
        private System.Windows.Forms.Button btnSaveBudget;
    }
}