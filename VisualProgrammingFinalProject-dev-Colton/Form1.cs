﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingFinalProject
{
    public partial class Form1 : Form
    {
        List<Budget> availableBudgets; // Saved budgets available to load into main view form
        public Form1()
        {
            InitializeComponent();
        }

        private void newBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BudgetCreatorForm budgetCreatorForm = new BudgetCreatorForm();
            budgetCreatorForm.ShowDialog();
        }

        private void loadSavedBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileDirectory = openFileDialog1.FileName;
                
                StreamReader reader;
                string currentLine;
                reader = File.OpenText(fileDirectory);
                currentLine = reader.ReadLine();
                if(currentLine == "CCOXCKAROW_VPFINALPROJECT_2022") //the first line of .txt file should contain this
                {

                }
                else MessageBox.Show("Please find a .txt file generated by this program!");
            } 
        }
    }
}
