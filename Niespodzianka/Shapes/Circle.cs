using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niespodzianka
{
    public class Circle : IShape
    {
        public Color Color { get; set; }
        public int Radius { get; set; }
        public Point Center { get; set; }

        public void SetRadius(Point p)
        {
            int diffX = p.X - Center.X;
            int diffY = p.Y - Center.Y;
            Radius = (int)Math.Sqrt(diffX * diffX + diffY * diffY);
        }

        public void Draw(Graphics graphics, int lineWidth)
        {
            Pen p = new Pen(Color, lineWidth);
            int r = Radius;
            graphics.DrawEllipse(p, Center.X - r, Center.Y - r,
                  2 * r, 2 * r);
        }

        public void SetSecondPoint(Point p)
        {
            SetRadius(p);
        }

        public IShape Clone()
        {
            return new Circle()
            {
                Center = Center,
                Color = Color,
                Radius = Radius
            };
        }

        public void SetFirstPoint(Point p)
        {
            Center = p;
        }

        public Point GetFirstPoint()
        {
            return Center;
        }

        public Point GetSecondPoint()
        {
            return new Point(Center.X + Radius, Center.Y);
        }
    }
}
