using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        bool isPaint = false;
        Point _x, _y;
        Pen pen = new Pen(Color.Black, 1);
        Pen silgi = new Pen(Color.White, 10);
        int secilen;
        int x, y, sX, sY, cX, cY;
        ColorDialog colorDialog = new ColorDialog();
        Color güncelRenk;
        Size firstSize;
        public Form1()
        {
            InitializeComponent();
             firstSize = this.Size;
            bitmap = new Bitmap(picBox.Width, picBox.Height);
           
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
         
            picBox.Image = bitmap;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secilen = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secilen = 4;
        }

        private void picBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (isPaint)
            {
                if (secilen == 3)
                {
                    graphics.DrawEllipse(pen, cX, cY, sX, sY);
                }
                if (secilen == 4)
                {
                    graphics.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (secilen == 5)
                {
                    graphics.DrawLine(pen, cX, cY, x, y);
                    
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            picBox.Image = bitmap;
            this.Size = firstSize;           
            secilen = 0;
        }

        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            güncelRenk = colorDialog.Color;
            renkSec.BackColor = güncelRenk;
            pen.Color = güncelRenk;
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            secilen = 7;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Png Files (*png) | *.png";
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.AddExtension = true; 
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void btnCizgi_Click(object sender, EventArgs e)
        {
            secilen = 5;
        }

        private void penSize_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = Convert.ToInt32(penSize.Value);
        }

        private void btnResimYükle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap original = new Bitmap(openFileDialog.FileName);
                this.Size = original.Size;
                bitmap = new Bitmap(original, new Size(picBox.Size.Width , picBox.Size.Height));
                graphics = Graphics.FromImage(bitmap);
                picBox.Image = bitmap;
            }
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            isPaint = true;
            _y = e.Location;
            cY = e.Y;
            cX = e.X;
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPaint)
            {
                 if(secilen == 1)
                {
                    _x = e.Location;
                    graphics.DrawLine(pen, _x, _y);
                    _y = _x;
                }
                if (secilen == 2)
                {
                    _x = e.Location; 
                    graphics.DrawLine(silgi, _x, _y);
                    _y = _x;
                }
            }
            picBox.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }
        static Point set_point(PictureBox pb , Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void picBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(secilen ==7)
            {
                Point point = set_point(picBox, e.Location);
                Doldur(bitmap, point.X, point.Y, güncelRenk);
            }
        }

        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPaint = false;

            sX = x - cX;
            sY = y - cY;
            if(secilen == 3)
            {
                graphics.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if (secilen == 4)
            {
                graphics.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if (secilen == 5)
            {
                graphics.DrawLine(pen, cX, cY, x, y);
            }
        }

        private void btnKalem_Click(object sender, EventArgs e)
        {
            secilen = 1;
        }
        private void validate(Bitmap bitmap, Stack<Point> stackPoint,int x , int y , Color previous_color, Color new_color)
        {
            Color ekrandanAlinan = bitmap.GetPixel(x, y);
            if(ekrandanAlinan == previous_color)
            {
                stackPoint.Push(new Point(x, y)); 
                bitmap.SetPixel(x, y, new_color);
            }
        }
        public void Doldur(Bitmap bitmap , int x , int y, Color new_color)
        {
            Color pre_color = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitmap.SetPixel(x, y, new_color);
            if (pre_color == new_color)
                return;
            while(pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if(pt.X>0 && pt.Y >0 && pt.X < bitmap.Width-1 && pt.Y <bitmap.Height - 1)
                {
                    validate(bitmap, pixel, pt.X-1, pt.Y, pre_color, new_color);
                    validate(bitmap, pixel, pt.X, pt.Y-1, pre_color, new_color);
                    validate(bitmap, pixel, pt.X+1, pt.Y, pre_color, new_color);
                    validate(bitmap, pixel, pt.X, pt.Y+1, pre_color, new_color);
                }
            }
        }
        private void btnSilgi_Click(object sender, EventArgs e)
        {
            secilen = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
