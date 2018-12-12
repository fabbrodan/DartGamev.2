using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DartGame
{
    public static class DartBoard
    {
        private static int[] PointLabels = new int[] { 20, 1, 18, 4, 13, 6, 10, 15, 2, 17, 3, 19, 7, 16, 8, 11, 14, 9, 12, 5 };
        private static List<KeyValuePair<int, GraphicsPath>> gpList = new List<KeyValuePair<int, GraphicsPath>>();
        public static void DrawBoard(PaintEventArgs e, PictureBox pictureBox1)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle outerRect = new Rectangle(
                pictureBox1.ClientRectangle.Location.X + 25,
                pictureBox1.ClientRectangle.Location.Y + 25,
                pictureBox1.ClientRectangle.Width - 50,
                pictureBox1.ClientRectangle.Height - 50);
            float angle = 360f / 20;
            float startAngle = 270f - (angle / 2);
            Pen pen = new Pen(Color.Red);
            
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), pictureBox1.ClientRectangle);

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    e.Graphics.FillPie(new SolidBrush(Color.Black), outerRect, startAngle, angle);
                }
                else
                {
                    e.Graphics.FillPie(new SolidBrush(Color.White), outerRect, startAngle, angle);
                }
                GraphicsPath gp = new GraphicsPath();
                gp.AddPie(outerRect, startAngle, angle);
                KeyValuePair<int, GraphicsPath> kp = new KeyValuePair<int, GraphicsPath>(PointLabels[i], gp);
                gpList.Add(kp);
                startAngle += angle;
            }
            /*
            for(int i = 0; i < 20; i++)
            {
                e.Graphics.DrawString(PointLabels[i].ToString(),
                    new Font("Calibri", 12f, FontStyle.Regular),
                    new SolidBrush(Color.Red),
                    new Point((int)(gpList[i].Value.PathPoints[0].X + angle), (int)(gpList[i].Value.PathPoints[0].Y + angle)));
            }
            */
            e.Graphics.DrawEllipse(pen, outerRect);
        }

        public static int Throw(int X, int Y)
        {
            Random random = new Random();
            int rng = random.Next(0, 101);
            Point click = new Point(X, Y);
            foreach (KeyValuePair<int, GraphicsPath> kp in gpList)
            {
                if (kp.Value.IsVisible(click))
                {
                    if (rng < 61)
                    {
                        return kp.Key;
                    }
                    else if (rng > 60 && rng < 76)
                    {
                        if (gpList.IndexOf(kp) == 0)
                        {
                            return gpList[gpList.Count - 1].Key;
                        }
                        else if (gpList.IndexOf(kp) == gpList.Count -1)
                        {
                            return gpList[0].Key;
                        }
                        return gpList[gpList.IndexOf(kp) - 1].Key;
                    }
                    else if (rng > 75 && rng < 91)
                    {
                        if (gpList.IndexOf(kp) == 0)
                        {
                            return gpList[gpList.Count - 1].Key;
                        }
                        else if (gpList.IndexOf(kp) == gpList.Count - 1)
                        {
                            return gpList[19].Key;
                        }
                        return gpList[gpList.IndexOf(kp) + 1].Key;
                    }
                    else if (rng > 90 && rng < 96)
                    {
                        int rng1 = random.Next(0, 20);
                        return gpList[rng1].Key;
                    }
                }
            }
            return 0;
        }
    }
}
