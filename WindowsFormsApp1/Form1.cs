using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public interface IFigure
{
    double GetArea();
    double GetPerimeter();
}
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxFigureType.Items.AddRange(new string[] { "Круг", "Прямоугольник", "Треугольник" });
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string selectedFigure = comboBoxFigureType.SelectedItem?.ToString();

            try
            {
                if (selectedFigure == "Круг")
                {
                    double radius = Convert.ToDouble(textBox1.Text);
                    IFigure circle = new Circle(radius);
                    ShowResult(circle);
                }
                else if (selectedFigure == "Прямоугольник")
                {
                    double width = Convert.ToDouble(textBox1.Text);
                    double height = Convert.ToDouble(textBox2.Text);
                    IFigure rectangle = new Rectangle(width, height);
                    ShowResult(rectangle);
                }
                else if (selectedFigure == "Треугольник")
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double c = Convert.ToDouble(textBox3.Text);
                    IFigure triangle = new Triangle(a, b, c);
                    ShowResult(triangle);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите тип фигуры.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        private void ShowResult(IFigure figure)
        {
            labelAreaResult.Text = "Площадь: " + figure.GetArea().ToString();
            labelPerimeterResult.Text = "Периметр: " + figure.GetPerimeter().ToString();
        }
    }
}

