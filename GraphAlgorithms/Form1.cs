using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GraphAlgorithms.Graphs;

namespace GraphAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MinHamilCycleFinder min = new MinHamilCycleFinder(getAdjacencyMatrix());
            MessageBox.Show(min.testMethod()[0].ToString());
        }

        private int[,] getAdjacencyMatrix()
        {
            int[,] adjcMatrix = new int[6, 6];
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <=6; j++)
                {
                    string tBoxContent = getTextBoxContent(i, j);
                    if (tBoxContent == "")
                    {
                        adjcMatrix[i - 1, j - 1] = -1;
                        continue;
                    }
                    else
                    {
                        adjcMatrix[i - 1, j - 1] = int.Parse(tBoxContent);
                    }                
                }
            }

            return adjcMatrix;
        }

        private string getTextBoxContent(int row, int column)
        {
            string text;
            try
            {
                text = ((TextBox)tableLayoutPanel_graph.GetControlFromPosition(column, row)).Text;
            } catch(Exception e)
            {
                text = "";   
            }
            return text;
        }
    }
}
