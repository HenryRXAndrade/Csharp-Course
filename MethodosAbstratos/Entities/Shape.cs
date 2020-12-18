using System;
using System.Collections.Generic;
using System.Text;
using MethodosAbstratos.Enums;

namespace MethodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }



        public Shape(Color color)
        {
            Color = Color;
        }

        public abstract double Area();

    }
}
