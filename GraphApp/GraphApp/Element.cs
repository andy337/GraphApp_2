using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphApp
{
    public class Element : Button
    {
        public int X, Y;

        public Element(int index, int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            var graphicsPath = new GraphicsPath();
            Width = 35;
            Height = 35;
            Location = new Point(X - 15, Y - 15);
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Gray;
            Text = index.ToString();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new Region(graphicsPath);
        }

    }
}
