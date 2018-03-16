using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class XY
    {
        public int X;
        public int Y;

        public XY(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class XYComparer : EqualityComparer<XY>
    {
        public override bool Equals(XY a, XY b)
        {
            if (a.X == b.X && a.Y == b.Y) return true;
            else return false;
        }

        public override int GetHashCode(XY obj)
        {
            string seed = obj.X.ToString() + ":" + obj.Y.ToString();
            return seed.GetHashCode();
        }
    }
}
