using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niespodzianka.Shapes
{
    public class AnimatedShape
    {
        public IShape StartingShape { get; set; }
        public IShape EndingShape { get; set; }
        public IShape CurrentShape { get; set; }
    }
}
