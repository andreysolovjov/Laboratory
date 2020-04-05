using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_N4
{
    public partial class Form1 : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);

        bool Rectangle_click = false;
        bool Circle_click = false;
        bool Square_click = false;

        int RectangleX = 0;
        int RectangleY = 0;
        int CircleX = 0;
        int CircleY = 0;
        int SquareX = 0;
        int SquareY = 0;

        int X, Y, dX, dY;
        int LastClicked = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (LastClicked==1)
            {
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);

            } 
            
            if(LastClicked==2)
            {
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillEllipse(Brushes.Red, Circle);
            }    
            
            if (LastClicked==3)
            {
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
            }    
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if((e.X<Rectangle.X + Rectangle.Width) && (e.X>Rectangle.X))
            {
                if((e.Y<Rectangle.Y + Rectangle.Height) && (e.Y>Rectangle.Y))
                {
                    Rectangle_click = true;
                    RectangleX = e.X - Rectangle.X;
                    RectangleY = e.Y - Rectangle.Y;

                }
            }

            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    Circle_click = true;
                    CircleX = e.X - Circle.X;
                    CircleY = e.Y - Circle.Y;
                }
            }

            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    Square_click = true;
                    SquareX = e.X - Square.X;
                    SquareY = e.Y - Square.Y;
                }
            }
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            if (LastClicked == 1)
            {
                if ((label2.Location.X < Rectangle.X + Rectangle.Width) && (label2.Location.X > Rectangle.X))
                {
                    if ((label2.Location.Y < Rectangle.Y + Rectangle.Height) && (label2.Location.Y > Rectangle.Y))
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CircleX;
                        dY = CircleY;
                        Circle.X = Rectangle.X;
                        Circle.Y = Rectangle.Y;
                        CircleX = RectangleX;
                        CircleY = RectangleY;

                        Rectangle.X = X;
                        Rectangle.Y = Y;
                        RectangleX = dX;
                        RectangleY = dY;
                    }
                }
            }


            if (LastClicked== 2)
            {
                if((label2.Location.X< Circle.X+Circle.Width) &&(label2.Location.X>Circle.X))
                {
                    if ((label2.Location.Y < Circle.Y + Circle.Height) && (label2.Location.Y> Circle.Y))
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CircleX;
                        dY = CircleY;
                        Circle.X = Square.X;
                        Circle.Y = Square.Y;
                        CircleX = SquareX;
                        CircleY = SquareY;

                        Square.X = X;
                        Square.Y = Y;
                        SquareX = dX;
                        SquareY = dY;
                    }
                }
            }

            if (LastClicked == 3)
            {
                if ((label2.Location.X < Square.X + Square.Width) && (label2.Location.X > Square.X))
                {
                    if ((label2.Location.Y < Square.Y + Square.Height) && (label2.Location.Y > Square.Y))
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CircleX;
                        dY = CircleY;
                        Circle.X = Square.X;
                        Circle.Y = Square.Y;
                        CircleX = SquareX;
                        CircleY = SquareY;

                        Square.X = X;
                        Square.Y = Y;
                        SquareX = dX;
                        SquareY = dY;
                    }
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Rectangle_click = false;
            Circle_click = false;
            Square_click = false;
        }

        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Circle_click)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
                LastClicked = 2;
            }

            if (Rectangle_click)
            {
                Rectangle.X = e.X - RectangleX;
                Rectangle.Y = e.Y - RectangleY;
                LastClicked = 1;
            }

            if (Square_click)
            {
                Square.X = e.X - SquareX;
                Square.Y = e.Y - SquareY;
                LastClicked = 3;

            }
            pictureBox1.Invalidate();

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((label1.Location.X < Square.X + Square.Width) && (label1.Location.X>Square.X))
            {
                if ((label1.Location.Y< Square.Y + Square.Height) && (label1.Location.Y>Square.Y))
                {
                    label1.Text = "Синий квадрат";
                }    
            }

            if ((label1.Location.X < Rectangle.X + Rectangle.Width) && (label1.Location.X > Rectangle.X))
            {
                if ((label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                {
                    label1.Text = "Желтый прямоугольник";
                }
            }

            if ((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X))
            {
                if ((label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                {
                    label1.Text = "Красный круг";
                }
            }
        }
    }
}
