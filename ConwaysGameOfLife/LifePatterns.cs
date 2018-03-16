using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public static class LifePatterns
    {
        public static List<string> Patterns = new List<string>()
        {
             "Acorn", "Century", "Die Hard", "Queen Bee", "R-Pentomino", "Thunderbird"
        };

        public static HashSet<XY> GetPattern (string name)
        {
            switch (name)
            {
                case "R-Pentomino":
                    return RPentomino;
                case "Die Hard":
                    return DieHard;
                case "Acorn":
                    return Acorn;
                case "Thunderbird":
                    return Thunderbird;
                case "Century":
                    return Century;
                case "Queen Bee":
                    return QueenBee;
                default:
                    return RPentomino;
            }
        }

        public static HashSet<XY> RPentomino = new HashSet<XY>(new XYComparer())
        {
            new XY(0,1), new XY(1,1), new XY(-1, 0), new XY(0,0), new XY(0,-1)
        };

        public static HashSet<XY> DieHard = new HashSet<XY>(new XYComparer())
        {
            new XY(-3,0), new XY(-2, 0), new XY(-2, -1), new XY(2, -1), new XY(3, 1), new XY(3, -1), new XY(4, -1)
        };

        public static HashSet<XY> Acorn = new HashSet<XY>(new XYComparer())
        {
            new XY(-3, -1), new XY(-2, -1), new XY(-2, 1), new XY(0, 0), new XY(1, -1), new XY(2, -1), new XY(3, -1)
        };

        public static HashSet<XY> Thunderbird = new HashSet<XY>(new XYComparer())
        {
            new XY(-1, 2), new XY(0,2), new XY(1, 2), new XY(0, 0), new XY(0, -1), new XY(0, -2)
        };

        public static HashSet<XY> Century = new HashSet<XY>(new XYComparer())
        {
            new XY(-1, 0), new XY(0, 0), new XY(0, -1), new XY(1, 1), new XY(1, 0), new XY(2, 1)
        };

        public static HashSet<XY> QueenBee = new HashSet<XY>(new XYComparer())
        {
            new XY(-2, 3), new XY(-2, 2), new XY(-2, -2), new XY(-2, -3), new XY(-1, 1), new XY(-1, 0), new XY(-1, -1),
            new XY(0, 2), new XY(0, -2), new XY(1, 1), new XY(1, -1), new XY(2, 0)
        };
    }
}
