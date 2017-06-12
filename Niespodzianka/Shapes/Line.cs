using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Niespodzianka
{
    public class Line : IShape
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public Color Color { get; set; }
        public void Draw(Graphics graphics, int lineWidth)
        {
            Pen p = new Pen(Color, lineWidth);
            graphics.DrawLine(p, Start, End);
            p.Dispose();
        }

        public void SetSecondPoint(Point p)
        {
            End = p;
        }

        public void SetFirstPoint(Point p)
        {
            Start = p;
        }

        public IShape Clone()
        {
            return new Line()
            {
                Color = Color,
                Start = Start,
                End = End
            };
        }

        public Point GetFirstPoint()
        {
            return Start;
        }

        public Point GetSecondPoint()
        {
            return End;
        }
    }

}
