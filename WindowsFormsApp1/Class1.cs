using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle : IFigure
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

