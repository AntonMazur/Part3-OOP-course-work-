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

        private void button_clear_Click(object sender, EventArgs e)
        {
            dGV_adjacMatrix.Columns.Clear();
        }

        private void button_addVertex_Click(object sender, EventArgs e)
        {
            GraphReaderWriter.addVertex(dGV_adjacMatrix);
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            GraphReaderWriter.getAdjacancyMatrix(dGV_adjacMatrix);
        }

        private void button_loadExample_Click(object sender, EventArgs e)
        {
            GraphReaderWriter.loadExample(dGV_adjacMatrix);
        }
    }
}
