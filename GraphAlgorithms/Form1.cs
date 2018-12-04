using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GraphAlgorithms.Graphs;
using GraphAlgorithms.Graphs.Algorithms.HamiltoneCycle.AntColonyOptimization;
using AnnealingAlgorithm = GraphAlgorithms.Graphs.Algorithms.HamiltoneCycle.SimulatedAnnealing.Algorithm;
using NearestNeightbourAlgorithm = GraphAlgorithms.Graphs.Algorithms.HamiltoneCycle.NearestNeighbour.Algorithm;

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
            var adjMatrix = GraphReaderWriter.getAdjacancyMatrix(dGV_adjacMatrix);

            if (rbtn_ant.Checked)
            {
                string[] algParams = tb_antAlg.Text.Split(';');

                MessageBox.Show(GraphReaderWriter.vertSeqToReadableForm(
                dGV_adjacMatrix,
                new ACOAlgorithm(
                    adjMatrix,
                    double.Parse(algParams[0]),
                    double.Parse(algParams[1]),
                    double.Parse(algParams[2]),
                    double.Parse(algParams[3]))
                    .findHamiltoneCycle()));
            }

            if (rbtn_annealingAlg.Checked)
            {
                string[] algParams = tB_annealingAlg.Text.Split(';');

                MessageBox.Show(GraphReaderWriter.vertSeqToReadableForm(
                dGV_adjacMatrix,
                new AnnealingAlgorithm(
                    adjMatrix,
                    double.Parse(algParams[0]),
                    double.Parse(algParams[1]),
                    GraphReaderWriter.convertPath(algParams[2], dGV_adjacMatrix),
                    int.Parse(algParams[3]))
                    .findHamiltoneCycle()));
            }

            if (rbtn_nearestNeighbourAlg.Checked)
            {
                MessageBox.Show(
                    GraphReaderWriter.vertSeqToReadableForm(
                        dGV_adjacMatrix,
                        new NearestNeightbourAlgorithm(adjMatrix).findHamiltoneCycle()));

            }

          

        }

        private void button_loadExample_Click(object sender, EventArgs e)
        {
            GraphReaderWriter.loadExample(dGV_adjacMatrix);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(tb_antAlg, "Формат ввода: \"" +
                "<коэфф. испарения>(вещ.);\n" +
                "<коэфф. влияния длины ребра на кол-во ферромона>(вещ.);\n" +
                "<коэфф. важности длины ребра>(вещ.);\n" +
                "<коэфф. важности кол-ва ферромона>(вещ.)\"");

            toolTip.SetToolTip(tB_annealingAlg, "Формат ввода: \"" +
                "<начальная температура>(вещ.);\n" +
                "<коэффициент уменьшения темепературы на каждом шаге>(вещ.);\n" +
                "<существующее решение в виде v1-v4-v3 ...>;\n" +
                "<количество итераций>(цел.)\"");

            rbtn_ant.Checked = true;
        }
    }
}
