using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Triangle : IFigure
{
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetArea()
    {
        double s = (a + b + c) / 2; // Полупериметр
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); // Формула Герона
    }

    public double GetPerimeter()
    {
        return a + b + c;
    }
}

