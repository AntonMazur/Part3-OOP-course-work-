﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace GraphAlgorithms.Graphs
{
    class GraphReaderWriter
    {

        public static void addVertex(DataGridView dGV)
        {
            addColumnToDGV(dGV, "V" + +(dGV.ColumnCount + 1));
            addRowToDGV(dGV, "V" + +(dGV.ColumnCount));
            dGV.Rows[dGV.RowCount - 1]
                .Cells[dGV.RowCount - 1].Value = "-";
        }

        private static void addColumnToDGV(DataGridView dGV, string header)
        {
            dGV.Columns.Add("col" + (dGV.ColumnCount + 1), header);
        }

        private static void addRowToDGV(DataGridView dGV, string header)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.HeaderCell.Value = header;
            dGV.Rows.Add(row);
        }

        private static void addRowToDGV(DataGridView dGV, string header, params Object[] rowContent)
        {
            dGV.Rows.Add(rowContent);
            dGV.Rows[dGV.RowCount - 1].HeaderCell.Value = header;
        }

        public static string vertSeqToReadableForm(DataGridView dGV, (int[], int) res)
        {
            var vertSeq = res.Item1.Select(vIdx =>(string) dGV.Rows[vIdx].HeaderCell.Value);

            StringBuilder sb = new StringBuilder();

            sb.Append(String.Join("-", vertSeq));

            sb.Append("\nДлина минимального гамильтонового цикла: " 
                + res.Item2);

            return sb.ToString();
        }


        public static int[,] getAdjacancyMatrix(DataGridView dGV)
        {
            int dim = dGV.ColumnCount;
            int[,] adjMatrix = new int[dim, dim];
            string cellVal;

            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    cellVal = (string)dGV.Rows[i].Cells[j].Value;

                    if (!int.TryParse(cellVal, out adjMatrix[i, j]))
                    {
                        adjMatrix[i, j] = -1;
                    }

                }
            }
            return adjMatrix;
        }

        public static int[] convertPath(string path, DataGridView dGV)
        {
            var rowNames = new string[dGV.Rows.Count];

            for (int i = 0; i < rowNames.Length; i++)
            {
                rowNames[i] = (string) dGV.Rows[i].HeaderCell.Value;
            }

            return path.Split('-').Select(strComp => convertPathComponent(strComp, rowNames)).ToArray();
        }

        private static int convertPathComponent(string comp, string[] rowNames)
        {
            int compIdx = -1;

            for (int i = 0; i < rowNames.Length; i++)
            {
                if (rowNames[i].Equals(comp))
                {
                    return i;
                }
            }

            return compIdx;
        }

        public static void loadExample(DataGridView dGV)
        {
            addColumnToDGV(dGV, "A");
            addColumnToDGV(dGV, "B");
            addColumnToDGV(dGV, "C");
            addColumnToDGV(dGV, "D");
            addColumnToDGV(dGV, "F");
            addColumnToDGV(dGV, "G");

            addRowToDGV(dGV, "A", "-", "3", "", "", "6", "3");
            addRowToDGV(dGV, "B", "5", "-", "6", "", "", "3");
            addRowToDGV(dGV, "C", "", "2", "-", "2", "", "6");
            addRowToDGV(dGV, "D", "", "", "3", "-", "5", "2");
            addRowToDGV(dGV, "F", "5", "", "", "3", "-", "5");
            addRowToDGV(dGV, "G", "5", "5", "2", "3", "", "-");
        }
    }
}
