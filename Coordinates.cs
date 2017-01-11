using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalogClock
{
    public class Coordinates
    {
        public Coordinates()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xx">x-coordinate</param>
        /// <param name="yy">y-coordinate</param>
        public Coordinates(int xx, int yy)
        {
            x = xx;
            y = yy;
        }

        public int x { get; set; }
        public int y { get; set; }
    }
}
