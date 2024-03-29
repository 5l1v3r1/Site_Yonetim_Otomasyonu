﻿using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Site_Yonetim_Otomasyonu
{
    public class GradientPanel : Panel
    {
        public Color TopColor { get; set; }
        public Color BottomColor { get; set; }

        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angle);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);


            base.OnPaint(e);
        }

    }
}