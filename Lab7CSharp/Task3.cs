using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Task3 : Form
    {
        Random random = new Random();
        Shape[] shapes = new Shape[100]; 
        int shapeCount = 0;

        public Task3()
        {
            InitializeComponent();
            exitProgramButton.Click += exitProgramButton_Click;

            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            inputNewElemIntoMassiveButton.Visible = false;
            drawPictureButton.Visible = false;
        }

        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openColorDialog1Button_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                openColorDialog1Button.BackColor = colorDialog1.Color;
            }
        }

        private void drawPictureButton_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White); 

            for (int i = 0; i < shapeCount; i++)
            {
                shapes[i].Draw(g);
            }

            g.Dispose();
        }

        private void inputNewElemIntoMassiveButton_Click(object sender, EventArgs e)
        {
            if(CountOfElemntsPictureTextBox.Text == "")
            {
                MessageBox.Show("Введіть кількість елементів");
                return;
            }

            int count = int.Parse(CountOfElemntsPictureTextBox.Text);
            for (int i = 0; i < count; i++)
            {
                Shape newShape = null;

                if (squareRadioButton.Checked )
                {
                    if (!string.IsNullOrWhiteSpace(sideSquareTextBox.Text))
                    {
                        newShape = new Square();
                        int size = int.Parse(sideSquareTextBox.Text);
                        ((Square)newShape).Size = size;
                    }
                    else
                    {
                        MessageBox.Show("Введіть сторону квадрата");
                        return;
                    }
                }
                else if (rectangleRadioButton.Checked)
                {
                    if(side1textBox.Text == "" || side2textBox.Text == "")
                    {
                        MessageBox.Show("Введіть сторони прямокутника");
                        return;
                    }
                    newShape = new RectangleShape();
                    int width = int.Parse(side1textBox.Text); 
                    int height = int.Parse(side2textBox.Text);
                    ((RectangleShape)newShape).Width = width;
                    ((RectangleShape)newShape).Height = height;
                }
                else if (equilateralTriangleRadioButton.Checked)
                {
                    if(sideTriangleTextBox.Text == "")
                    {
                        MessageBox.Show("Введіть сторону рівностороннього трикутника");
                        return; 
                    }
                    newShape = new EquilateralTriangle();
                    int size = int.Parse(sideTriangleTextBox.Text); 
                    ((EquilateralTriangle)newShape).Size = size;
                }
                else if (circleRadioButton.Checked)
                {
                    if(radiusTextBox.Text == "")
                    {
                        MessageBox.Show("Введіть радіус кола");
                        return;
                    }
                    newShape = new Circle();
                    int diameter = int.Parse(radiusTextBox.Text); 
                    ((Circle)newShape).Diameter = diameter;
                }
                else
                {
                    MessageBox.Show("Виберіть фігуру та введіть всі необхідні параметри");
                    return;
                }

                if (newShape != null)
                {
                    newShape.Color = openColorDialog1Button.BackColor; 
                    newShape.Position = new Point(random.Next(pictureBox1.Width), random.Next(pictureBox1.Height)); 
                    newShape.Text = textOfElementTextBox.Text; 
                    shapes[shapeCount++] = newShape; 
                }
            }
        }


        abstract class Shape
        {
            public Color Color { get; set; }
            public Point Position { get; set; }
            public string Text { get; set; }

            public abstract void Draw(Graphics g);
        }
       
        class Square : Shape
        {
            public int Size { get; set; }

            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color);
                Brush brush = new SolidBrush(Color.FromArgb(128, Color));
                g.FillRectangle(brush, Position.X, Position.Y, Size, Size);
                g.DrawRectangle(pen, Position.X, Position.Y, Size, Size);
                if (!string.IsNullOrEmpty(Text))
                    g.DrawString(Text, SystemFonts.DefaultFont, Brushes.Black, Position.X + 10, Position.Y + 20);
            }
        }

        class RectangleShape : Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color);
                Brush brush = new SolidBrush(Color.FromArgb(128, Color));
                g.FillRectangle(brush, Position.X, Position.Y, Width, Height);
                g.DrawRectangle(pen, Position.X, Position.Y, Width, Height);
                if (!string.IsNullOrEmpty(Text))
                    g.DrawString(Text, SystemFonts.DefaultFont, Brushes.Black, Position.X + 10, Position.Y + 20);
            }
        }

        class EquilateralTriangle : Shape
        {
            public int Size { get; set; }

            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color);
                Brush brush = new SolidBrush(Color.FromArgb(128, Color));
                Point[] points = { new Point(Position.X + Size / 2, Position.Y), new Point(Position.X, Position.Y + Size), new Point(Position.X + Size, Position.Y + Size) };
                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
                if (!string.IsNullOrEmpty(Text))
                    g.DrawString(Text, SystemFonts.DefaultFont, Brushes.Black, Position.X + 10, Position.Y + 20);
            }
        }

        class Circle : Shape
        {
            public int Diameter { get; set; }

            public override void Draw(Graphics g)
            {
                Pen pen = new Pen(Color);
                Brush brush = new SolidBrush(Color.FromArgb(128, Color));
                g.FillEllipse(brush, Position.X, Position.Y, Diameter, Diameter);
                g.DrawEllipse(pen, Position.X, Position.Y, Diameter, Diameter);
                if (!string.IsNullOrEmpty(Text))
                    g.DrawString(Text, SystemFonts.DefaultFont, Brushes.Black, Position.X + 10, Position.Y + 20);
            }
        }

        private void rectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox6.Visible = false;
            inputNewElemIntoMassiveButton.Visible = true;
            drawPictureButton.Visible = true;
        }

        private void equilateralTriangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            groupBox6.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            inputNewElemIntoMassiveButton.Visible = true;
            drawPictureButton.Visible = true;

        }

        private void squareRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox6.Visible = false;
            inputNewElemIntoMassiveButton.Visible = true;
            drawPictureButton.Visible = true;

        }

        private void circleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            inputNewElemIntoMassiveButton.Visible = true;
            drawPictureButton.Visible = true;

        }
    }
}