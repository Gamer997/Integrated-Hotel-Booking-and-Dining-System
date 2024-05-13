using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    public class RoundPictureBox : PictureBox
    {
        private RoundPanel roundPanel1;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
                Region = new Region(path);
                pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                pe.Graphics.DrawEllipse(new Pen(Color.Black, 1), 0, 0, Width - 1, Height - 1);
            }
        }

        private void InitializeComponent()
        {
            this.roundPanel1 = new CustomControls.RoundPanel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.CornerRadius = 10;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(200, 100);
            this.roundPanel1.TabIndex = 0;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
