namespace VisualProgrammingFinalProject
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBudgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSavedBudgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblContributors = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBudgetToolStripMenuItem,
            this.loadSavedBudgetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newBudgetToolStripMenuItem
            // 
            this.newBudgetToolStripMenuItem.Name = "newBudgetToolStripMenuItem";
            this.newBudgetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBudgetToolStripMenuItem.Text = "New Budget";
            this.newBudgetToolStripMenuItem.Click += new System.EventHandler(this.newBudgetToolStripMenuItem_Click);
            // 
            // loadSavedBudgetToolStripMenuItem
            // 
            this.loadSavedBudgetToolStripMenuItem.Name = "loadSavedBudgetToolStripMenuItem";
            this.loadSavedBudgetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadSavedBudgetToolStripMenuItem.Text = "Load Saved Budget";
            this.loadSavedBudgetToolStripMenuItem.Click += new System.EventHandler(this.loadSavedBudgetToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Malgun Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(455, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ENTER PROJ TITLE HERE";
            // 
            // lblContributors
            // 
            this.lblContributors.AutoSize = true;
            this.lblContributors.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContributors.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblContributors.Location = new System.Drawing.Point(18, 74);
            this.lblContributors.Name = "lblContributors";
            this.lblContributors.Size = new System.Drawing.Size(270, 17);
            this.lblContributors.TabIndex = 2;
            this.lblContributors.Text = "Created by Colton Cox and Connor Karow";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblContributors);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBudgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSavedBudgetToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblContributors;
    }
}

