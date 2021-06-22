using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphApp
{
    delegate void Mode();
    delegate string Operation(int vertex);

    public partial class Form1 : Form
    {
        List<Element> elements = new List<Element>();
        Point[] points = new Point[2];
        int[] element = new int[2];
        private Graph graph;
        int index, count = 0;
        Mode mod;
        Operation[] op;

        public Form1()
        {
            InitializeComponent();
        }
        // Кнопки-режими
        // //////////////////////////////////////////////////////////

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            mod = Empty;
            panel1.MouseDown += Panel1_MouseDown;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Element el = new Element(index, e.X, e.Y);
            panel1.Controls.Add(el);
            elements.Add(el);
            el.Click += El_Click;
            index++;
        }

        private void AddEdgeButton_Click_1(object sender, EventArgs e)
        {
            mod = AddEdge;
        }

        private void RemoveEdgeButton_Click(object sender, EventArgs e)
        {
            mod = RemoveEdge;
        }

        private void ShowGraphButton_Click(object sender, EventArgs e)
        {
            richTextBox.Text = graph.Print();
        }

        private void SaveGrapButton_Click(object sender, EventArgs e)
        {
            graph = new GraphMatrix(index);
            op = new Operation[]
            {
                graph.InDegree,
                graph.OutDegree,
                graph.IsIsolated,
                graph.MatrixDistance
            };
            panel1.MouseDown -= Panel1_MouseDown;
        }

        // ////////////////////////////////////////////////////////////

        private void El_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] == sender)
                {
                    element[count] = i;
                    points[count] = new Point(elements[i].X, elements[i].Y);
                    count++;
                }
            }

            if (count == 2)
            {
                mod();
                count = 0;
            }
        }

        private void AddEdge()
        {
            Graphics g = panel1.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.Black, 3);
            g.DrawLine(pen, points[0], points[1]);
            graph.AddEdge(element[0], element[1]);

            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            pen.CustomEndCap = bigArrow;


            Point point_arrow = new Point((points[0].X + points[1].X) / 2, (points[0].Y + points[1].Y) / 2);
            g.DrawLine(pen, points[0], point_arrow);

        }

        private void RemoveEdge()
        {
            Graphics g = panel1.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.White, 4);
            g.DrawLine(pen, points[0], points[1]);

            AdjustableArrowCap bigArrow = new AdjustableArrowCap(6, 5);
            pen.CustomEndCap = bigArrow;


            Point point_arrow = new Point((points[0].X + points[1].X) / 2, (points[0].Y + points[1].Y) / 2);
            g.DrawLine(pen, points[0], point_arrow);

            graph.RemoveEdge(element[0], element[1]);
        }

        private void DoButton_Click(object sender, EventArgs e)
        {
            richTextBox.Text = op[comboBox1.SelectedIndex](element[0]);
            count = 0;
        }

        private void Empty() // костиль
        {
            count = 0;
        }
    }
}
