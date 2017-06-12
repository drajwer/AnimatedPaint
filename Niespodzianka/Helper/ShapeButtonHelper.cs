using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niespodzianka.Helper
{
    public class ShapeButtonHelper
    {
        public enum Position
        {
            Start,
            End
        }

        private readonly Position _position;
        private readonly IShape _shape;
        public Point MouseDownLocation { get; set; }
        public ShapeButtonHelper(Position position, IShape shape)
        {
            _position = position;
            _shape = shape;
        }

        public void MoveShape(Point positionPoint)
        {
            if(_position == Position.Start)
                _shape.SetFirstPoint(positionPoint);
            else
                _shape.SetSecondPoint(positionPoint);
        }

    }
}
