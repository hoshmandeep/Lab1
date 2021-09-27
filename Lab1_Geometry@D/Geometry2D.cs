using System;
using System.Collections.Generic;
using System.Text;
using Geometry2D;

namespace Geometry2D
{
   
        public class Point
        {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x =0, double y =0)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Get both X and Y coordinate from 0
        /// </summary>
        public void GetCoords(out double x, out double y)
        {
            x = X;
            y = Y;
        }
        /// <summary>
        /// Allow the user to set 1 coordinate or the other
        /// </summary>
       

        public void SetCoords(double? x, double? y)
        {
            X = x ?? X;
            Y = y ?? Y;
        }

        public override string ToString() => $"({X}, {Y}";
    }
    public class Vector
    {
      public double DX { get; private set; }
        public double DY { get; private set; }

        public Vector(double dx = 0, double dy =0)
        {
            DX = dx;
            DY = dy;
            Set(dx, dy);
        }
        /// <summary>
        /// Sets the x and y components of the vector 
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dx"><</param>
        /// <exception cref="ArgumentOutOfRangeException">Will throw if dx or dy is outside the range [-1, 1]</exception>
        public void Set(double dx, double dy)
        {
            DX = dx;
            DY = dy;
            //if dx or dy <= -1 or > = 1 -> throw exception
            if (dx <= -1 || dy <= -1 || dx >= 1 || dy >= 1)
            {
                throw new ArgumentOutOfRangeException(); 
            }
            
        }
        public override string ToString() => $"({DX}, {DY})";
       
    }

    /// <summary>
    /// An immutable rectangle. the lenght and width
    /// </summary>
    public class Rectangle
    {
      public double Length { get; }
        public double Width { get; }
        public double Area { get; }
        public Rectangle(double length, double width)
        {
            // length and width to calculate area. 
            Length = length;
            Width = width;
            Area = length * width;

        }
    }

    
    
}
