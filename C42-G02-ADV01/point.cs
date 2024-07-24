using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV01
{
    internal class point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public point(int x,int y) {
            X = x;
            Y = y;
        }
        public override string ToString() {
            return $"{X},{Y}";
        }
    }
}
