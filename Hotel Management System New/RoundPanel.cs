using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    public class RoundPanel : Panel
    {

        public int CornerRadius { get; set; } = 10; // Adjust the corner radius as needed

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                int width = Width;
                int height = Height;
                int radius = CornerRadius;
                path.StartFigure();
                path.AddArc(0, 0, 2 * radius, 2 * radius, 180, 90); // Top-left corner
                path.AddArc(width - 2 * radius, 0, 2 * radius, 2 * radius, 270, 90); // Top-right corner
                path.AddArc(width - 2 * radius, height - 2 * radius, 2 * radius, 2 * radius, 0, 90); // Bottom-right corner
                path.AddArc(0, height - 2 * radius, 2 * radius, 2 * radius, 90, 90); // Bottom-left corner
                path.CloseFigure();

                Region = new Region(path);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPath(new SolidBrush(BackColor), path);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
