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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBudgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBudgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_BudgetName = new System.Windows.Forms.Label();
            this.chart_main = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.expenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseChart)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBudgetToolStripMenuItem,
            this.loadBudgetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newBudgetToolStripMenuItem
            // 
            this.newBudgetToolStripMenuItem.Name = "newBudgetToolStripMenuItem";
            this.newBudgetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newBudgetToolStripMenuItem.Text = "New Budget";
            this.newBudgetToolStripMenuItem.Click += new System.EventHandler(this.newBudgetToolStripMenuItem_Click);
            // 
            // loadBudgetToolStripMenuItem
            // 
            this.loadBudgetToolStripMenuItem.Name = "loadBudgetToolStripMenuItem";
            this.loadBudgetToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.loadBudgetToolStripMenuItem.Text = "Load Budget";
            this.loadBudgetToolStripMenuItem.Click += new System.EventHandler(this.loadBudgetToolStripMenuItem_Click);
            // 
            // lbl_BudgetName
            // 
            this.lbl_BudgetName.AutoSize = true;
            this.lbl_BudgetName.Location = new System.Drawing.Point(9, 32);
            this.lbl_BudgetName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_BudgetName.Name = "lbl_BudgetName";
            this.lbl_BudgetName.Size = new System.Drawing.Size(72, 13);
            this.lbl_BudgetName.TabIndex = 1;
            this.lbl_BudgetName.Text = "Budget Name";
            // 
            // chart_main
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_main.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_main.Legends.Add(legend1);
            this.chart_main.Location = new System.Drawing.Point(28, 89);
            this.chart_main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart_main.Name = "chart_main";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "BudgetNet";
            this.chart_main.Series.Add(series1);
            this.chart_main.Size = new System.Drawing.Size(212, 219);
            this.chart_main.TabIndex = 2;
            this.chart_main.Text = "chart1";
            // 
            // expenseChart
            // 
            chartArea2.Name = "ChartArea1";
            this.expenseChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.expenseChart.Legends.Add(legend2);
            this.expenseChart.Location = new System.Drawing.Point(316, 75);
            this.expenseChart.Name = "expenseChart";
            this.expenseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Expenses";
            this.expenseChart.Series.Add(series2);
            this.expenseChart.Size = new System.Drawing.Size(304, 233);
            this.expenseChart.TabIndex = 3;
            this.expenseChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 402);
            this.Controls.Add(this.expenseChart);
            this.Controls.Add(this.chart_main);
            this.Controls.Add(this.lbl_BudgetName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBudgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBudgetToolStripMenuItem;
        private System.Windows.Forms.Label lbl_BudgetName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_main;
        private System.Windows.Forms.DataVisualization.Charting.Chart expenseChart;
    }
}

