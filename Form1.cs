using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace класс_Vehicle
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car> { };
        List<Plane> planes = new List<Plane> { };
        List<Ship> ships = new List<Ship> { };
        bool f = false, t = false, tr = false;
        public Form1()
        {
            InitializeComponent();
            button6.Visible = false;
        }
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car { Name = textBox1.Text, Price = random.Next(30000,65000), Year_of_construction = random.Next(1990,2021), Speed = random.Next(0,250), CoordinateX = 0, CoordinateY = 0 };
            cars.Add(car);
            listBox1.Items.Add(car.Name);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = true;
            t = tr = false;
            int i = listBox1.SelectedIndex;
            richTextBox1.Text =
                "Название - " + cars[i].Name + Environment.NewLine +
                "Цена - " + cars[i].Price + Environment.NewLine +
                "Год выпуска - " + cars[i].Year_of_construction + Environment.NewLine +
                "Скорость - " + cars[i].Speed + Environment.NewLine +
                "X - " + cars[i].CoordinateX + "; Y - " + cars[i].CoordinateY;
            button6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ship ship = new Ship { Name = textBox1.Text, Price = random.Next(30000, 65000), Year_of_construction = random.Next(1990, 2021), Speed = random.Next(0, 250), CoordinateX = 0, CoordinateY = 0 };
            ships.Add(ship);
            listBox2.Items.Add(ship.Name);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            t = true;
            f = tr = false;
            int i = listBox2.SelectedIndex;
            richTextBox1.Text =
                "Название - " + ships[i].Name + Environment.NewLine +
                "Цена - " + ships[i].Price + Environment.NewLine +
                "Год выпуска - " + ships[i].Year_of_construction + Environment.NewLine +
                "Скорость - " + ships[i].Speed + Environment.NewLine +
                "X - " + ships[i].CoordinateX + "; Y - " + ships[i].CoordinateY;
            button6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Plane plane = new Plane { Name = textBox1.Text, Price = random.Next(30000, 65000), Year_of_construction = random.Next(1990, 2021), Speed = random.Next(0, 250), Height = 10000, CoordinateX = 0, CoordinateY = 0 };
            planes.Add(plane);
            listBox3.Items.Add(plane.Name);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (f == true)
            {
                int i = listBox1.SelectedIndex;
                String speed = Microsoft.VisualBasic.Interaction.InputBox("Введите новую скорость", "Ввод новой скорости", "", 100, 100);
                cars[i].SpeedMethod(double.Parse(speed));
            }
            if (t == true)
            {
                int i = listBox2.SelectedIndex;
                String speed = Microsoft.VisualBasic.Interaction.InputBox("Введите новую скорость", "Ввод новой скорости", "", 100, 100);
                ships[i].SpeedMethod(double.Parse(speed));
            }
            if (tr == true)
            {
                int i = listBox3.SelectedIndex;
                String speed = Microsoft.VisualBasic.Interaction.InputBox("Введите новую скорость", "Ввод новой скорости", "", 100, 100);
                planes[i].SpeedMethod(double.Parse(speed));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = listBox3.SelectedIndex;
            String height = Microsoft.VisualBasic.Interaction.InputBox("Введите новую высоту", "Ввод новой высоты", "", 100, 100);
            planes[i].HeightMethod(double.Parse(height));
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            tr = true;
            t = f = false;
            int i = listBox3.SelectedIndex;
            richTextBox1.Text =
                "Название - " + planes[i].Name + Environment.NewLine +
                "Цена - " + planes[i].Price + Environment.NewLine +
                "Год выпуска - " + planes[i].Year_of_construction + Environment.NewLine +
                "Скорость - " + planes[i].Speed+Environment.NewLine+
                "Высота - " + planes[i].Height + Environment.NewLine +
                "X - " + planes[i].CoordinateX + "; Y - " + planes[i].CoordinateY;
            button6.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (f == true)
            {
                int i = listBox1.SelectedIndex;
                String X = Microsoft.VisualBasic.Interaction.InputBox("Введите новый X", "Ввод координаты X", "", 100, 100);
                String Y = Microsoft.VisualBasic.Interaction.InputBox("Введите новый Y", "Ввод координаты Y", "", 100, 100);
                cars[i].Coordinate(double.Parse(X), double.Parse(Y));
            }
            if (t == true)
            {
                int i = listBox1.SelectedIndex;
                String X = Microsoft.VisualBasic.Interaction.InputBox("Введите новый X", "Ввод координаты X", "", 100, 100);
                String Y = Microsoft.VisualBasic.Interaction.InputBox("Введите новый Y", "Ввод координаты Y", "", 100, 100);
                ships[i].Coordinate(double.Parse(X), double.Parse(Y));
            }
            if (tr == true)
            {
                int i = listBox1.SelectedIndex;
                String X = Microsoft.VisualBasic.Interaction.InputBox("Введите новый X", "Ввод координаты X", "", 100, 100);
                String Y = Microsoft.VisualBasic.Interaction.InputBox("Введите новый Y", "Ввод координаты Y", "", 100, 100);
                planes[i].Coordinate(double.Parse(X), double.Parse(Y));
            }
        }
    }
}
