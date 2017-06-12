using System.Drawing;

namespace Niespodzianka
{
    public interface IShape
    {
        void Draw(Graphics graphics, int lineWidth);
        void SetFirstPoint(Point p);
        void SetSecondPoint(Point p);
        Point GetFirstPoint();
        Point GetSecondPoint();
        IShape Clone();
        Color Color { get; set; }
    }
}