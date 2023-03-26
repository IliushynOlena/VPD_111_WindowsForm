using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_GraphicsGDI
{
    public partial class Form1 : Form
    {
        enum Types { Rectangle, Line, Ellipse };
        Point StartLocation;
        int redraw_count = 0;
        List<Point> points = new List<Point>();
        List<MyShape> shapes = new List<MyShape>();
        public Form1()
        {
            InitializeComponent();
            colorList.Items.Add(Color.Green);
            colorList.Items.Add(Color.Red);
            colorList.Items.Add(Color.Fuchsia);
            colorList.Items.Add(Color.Gold);
            colorList.SelectedIndex = 0;

            foreach (var item in Enum.GetValues(typeof(Types)))
            {
                typeComboBox.Items.Add(item);
            }
            typeComboBox.SelectedIndex = 0;
        }
        private void DrawBtn_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int x = 50, y = 50;
            int height = 300, width = 300;
            Pen pen = new Pen(Brushes.Green, 6);
            Point point = new Point(10, 10);
            Size size = new Size(600, 600);
            Rectangle rectangle1 = new Rectangle(point, size);
            Rectangle rectangle2 = new Rectangle(x, y, width, height);
            g.DrawEllipse(pen, rectangle1);
            g.FillEllipse(Brushes.Gold, rectangle2);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //this.Text = $" {redraw_count++}";
            //Graphics g = e.Graphics;
            //int x = 50, y = 50;
            //int height = 300, width = 300;
            //Pen pen = new Pen(Brushes.Green, 6);
            //Point point = new Point(10, 10);
            //Size size = new Size(600, 600);
            //Rectangle rectangle1 = new Rectangle(point, size);
            //Rectangle rectangle2 = new Rectangle(x, y, width, height);
            //g.DrawEllipse(pen, rectangle1);
            //g.FillEllipse(Brushes.Gold, rectangle2);

            //using (Graphics g = e.Graphics)
            //{
            //    Pen pen = new Pen(Color.Green, 20);
            //    pen.StartCap = LineCap.SquareAnchor;
            //    pen.EndCap = LineCap.ArrowAnchor;
            //    pen.DashStyle = DashStyle.Custom;
            //    pen.DashCap = DashCap.Triangle;

            //    g.DrawLine(pen, 20, 200, 1000, 200);


            //    Pen p = new Pen(Brushes.Chartreuse, 10);
            //    p.DashStyle = DashStyle.Dash;
            //    int x = 30, y = 30, height = 200, width = 200;
            //    Rectangle rect = new Rectangle(x, y, width, height);
            //    g.DrawEllipse(p, rect);

            //}//Dispose();

            PrintPoints(e.Graphics);
            PrintFigures(e.Graphics);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Graphics g = e.Graphics;
        }
        private void PrintPoints(Graphics g)
        {
            foreach (Point p in points)
            {
                g.FillEllipse(Brushes.Teal, p.X - 10, p.Y - 10, 20, 20);
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Point p = e.Location;
            //this.CreateGraphics().FillEllipse(Brushes.Teal, p.X-10, p.Y-10, 20, 20);
            //points.Add(p);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "Down";
            StartLocation = e.Location;
        }
        private void PrintFigures(Graphics g)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(g);
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Text = "Up";
            Point end = e.Location;
            Graphics g = this.CreateGraphics();
            Color color = (Color)colorList.SelectedItem;
            var type = (Types)typeComboBox.SelectedItem;
            MyShape shape = null;
            if (type == Types.Rectangle || type == Types.Ellipse)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.X = StartLocation.X < end.X ? StartLocation.X : end.X;
                rectangle.Y = StartLocation.Y < end.Y ? StartLocation.Y : end.Y;
                rectangle.Width = Math.Abs(e.X - StartLocation.X);
                rectangle.Height = Math.Abs(e.Y - StartLocation.Y);

                if (type == Types.Rectangle)
                    shape = new MyRectangle(color, rectangle); 
                else
                    shape = new MyEllipse(color, rectangle);             
               
            }
            else if (type == Types.Line)
            {
                shape = new MyLine(color, StartLocation, end);
                
            }
            shape.Draw(g);
            shapes.Add(shape);


        }
    }
    abstract class MyShape
    {
        public abstract void Draw(Graphics g);
    }
    class MyRectangle : MyShape
    {
        public Brush Brush { get; set; }
        public Rectangle Rectangle { get; set; }
        public MyRectangle() { }
        public MyRectangle(Color Color, Rectangle Rectangle)
        {
            this.Brush = new SolidBrush(Color);
            this.Rectangle = Rectangle;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brush, this.Rectangle);
        }
    }
    class MyEllipse : MyRectangle
    {
        public MyEllipse() {  }
        public MyEllipse(Color color,  Rectangle r): base(color, r)  {  }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(Brush, Rectangle);
        }
    }
    class MyLine : MyShape
    {
        public Pen Pen { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }
        public MyLine(Color c, Point s, Point e)
        {
            Pen = new Pen(c);
            Start = s;
            End = e;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(Pen, Start, End);
        }
    }
}
