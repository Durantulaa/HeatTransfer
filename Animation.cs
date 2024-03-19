using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HeatTransfer
{
    public partial class Animation : UserControl
    {
        public int ballPositionY { get; set; }
        private Label lblTemp;
        private int width = 480;
        private int height = 580;
        private int padding = 10;
        private Color ballColor;
        private int r = 0;
        private int g = 0;
        private int b = 0;



        public Animation()
        {
            InitializeComponent();
            this.ballColor = Color.FromArgb(r, g, b);
            this.lblTemp = new Label();
            this.lblTemp.Location = new Point(260, 300);
            this.lblTemp.Width = 180;
            this.lblTemp.Font = new Font("Microsoft Sans Serif", 12);
            this.lblTemp.BackColor = Color.LightBlue;
            this.Controls.Add(lblTemp);
        }

        public void displayTemp(String text)
        {
            this.lblTemp.Text = text;
            r += 5;
            g += 2;
            b += 1;
            this.ballColor = Color.FromArgb(r, g, b);
            this.Invalidate();
        }
        
        private void Animation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawBeaker(g);
            DrawWater(g);
            DrawBall(g);
        }

        private void DrawBeaker(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            //SolidBrush brush = new SolidBrush(Color.Transparent);
            // left line
            g.DrawLine(pen, padding, 200, padding, height - padding);

            // bottom line
            g.DrawLine(pen, padding, height - padding, width - padding - padding, height - padding);

            // right line
            g.DrawLine(pen, width - padding - padding, 200, width - padding - padding, height - padding);
            //g.FillRectangle(brush, 0, 200, 580, 498);
        }

        private void DrawWater(Graphics g)
        {
            Pen pen = new Pen(Color.LightBlue);
            SolidBrush brush = new SolidBrush(Color.LightBlue);
            g.DrawRectangle(pen, padding + 10, 300, width - padding - padding - 30, height - padding - padding - 300);
            g.FillRectangle(brush, padding + 10, 300, width - padding - padding - 30, height - padding - padding - 300);

        }

        private void DrawBall(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(this.ballColor);
            g.DrawEllipse(pen, 200, this.ballPositionY, 50, 50);
            g.FillEllipse(brush, 200, this.ballPositionY, 50, 50);
        }
        
    }
}
