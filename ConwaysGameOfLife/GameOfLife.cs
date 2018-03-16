using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    class GameOfLife
    {

        XYComparer xyComparer = new XYComparer();
        HashSet<XY> liveCells;
        HashSet<XY> deadCells;

        public HashSet<XY> LiveCells { get { return liveCells; } }
        public HashSet<XY> DeadCells { get { return deadCells; } }

        int underPopulation = 1;
        int overPopulation = 4;
        int[] birthPopulation = new int[] { 3 };

        public int UnderPopulation { get { return underPopulation; } set { underPopulation = value; } }
        public int OverPopulation { get { return overPopulation; } set { overPopulation = value; } }
        public int[] BirthPopulation { get { return birthPopulation; } set { birthPopulation = value; } }

        int generation = 0;
        public int Generation { get { return generation; } }

        public GameOfLife()
        {
            liveCells = new HashSet<XY>(xyComparer);
            deadCells = new HashSet<XY>(xyComparer);
        }

        public void Clear()
        {
            liveCells.Clear();
            deadCells.Clear();
            generation = 0;
        }

        public void LoadPattern(string name)
        {
            liveCells.Clear();
            deadCells.Clear();
            generation = 0;
            liveCells.UnionWith(LifePatterns.GetPattern(name));
        }

        public void SwitchCell(XY cell)
        {
            if (liveCells.Contains(cell))
            {
                liveCells.Remove(cell);
                deadCells.Add(cell);
            }
            else
            {
                liveCells.Add(cell);
                deadCells.ExceptWith(liveCells);
            }
        }

        public void NextGeneration()
        {
            HashSet<XY> nextGen = new HashSet<XY>(xyComparer);
            HashSet<XY> maybeBaby = new HashSet<XY>(xyComparer);

            // for all live cells, see if they survive (if so add to next gen) and mark their dead neighbours as possible babies
            foreach (XY cell in liveCells)
            {
                HashSet<XY> deadNeighbours = GetDeadNeighbours(cell);

                if ((8 - deadNeighbours.Count) > underPopulation && 
                    (8 - deadNeighbours.Count) < overPopulation)
                {
                    nextGen.Add(cell);
                }
                else
                {
                    deadCells.Add(cell);
                }

                maybeBaby.UnionWith(deadNeighbours);
            }
            // for all maybe babies, see if they are babies
            foreach (XY cell in maybeBaby)
            {
                if (birthPopulation.Contains(GetLiveNeighbourCount(cell)))
                {
                    nextGen.Add(cell);
                }
            }

            liveCells = nextGen;
            deadCells.ExceptWith(liveCells);
        }

        private HashSet<XY> GetDeadNeighbours(XY cell)
        {
            HashSet<XY> deadNeighbours = new HashSet<XY>(xyComparer);

            if (!liveCells.Contains(new XY(cell.X-1, cell.Y))) { deadNeighbours.Add(new XY(cell.X - 1, cell.Y)); } // W
            if (!liveCells.Contains(new XY(cell.X - 1, cell.Y - 1))) { deadNeighbours.Add(new XY(cell.X - 1, cell.Y - 1)); } // NW
            if (!liveCells.Contains(new XY(cell.X, cell.Y - 1))) { deadNeighbours.Add(new XY(cell.X, cell.Y - 1)); } // N
            if (!liveCells.Contains(new XY(cell.X + 1, cell.Y - 1))) { deadNeighbours.Add(new XY(cell.X + 1, cell.Y - 1)); } // NE
            if (!liveCells.Contains(new XY(cell.X + 1, cell.Y))) { deadNeighbours.Add(new XY(cell.X + 1, cell.Y)); } // E
            if (!liveCells.Contains(new XY(cell.X + 1, cell.Y + 1))) { deadNeighbours.Add(new XY(cell.X + 1, cell.Y + 1)); } // SE
            if (!liveCells.Contains(new XY(cell.X, cell.Y + 1))) { deadNeighbours.Add(new XY(cell.X, cell.Y + 1)); } // S
            if (!liveCells.Contains(new XY(cell.X - 1, cell.Y + 1))) { deadNeighbours.Add(new XY(cell.X - 1, cell.Y + 1)); } // SW

            return deadNeighbours;
        }

        private int GetLiveNeighbourCount(XY cell)
        {
            int count = 0;

            if (liveCells.Contains(new XY(cell.X - 1, cell.Y))) { count++; } // W
            if (liveCells.Contains(new XY(cell.X - 1, cell.Y - 1))) { count++; } // NW
            if (liveCells.Contains(new XY(cell.X, cell.Y - 1))) { count++; } // N
            if (liveCells.Contains(new XY(cell.X + 1, cell.Y - 1))) { count++; } // NE
            if (liveCells.Contains(new XY(cell.X + 1, cell.Y))) { count++; } // E
            if (liveCells.Contains(new XY(cell.X + 1, cell.Y + 1))) { count++; } // SE
            if (liveCells.Contains(new XY(cell.X, cell.Y + 1))) { count++; } // S
            if (liveCells.Contains(new XY(cell.X - 1, cell.Y + 1))) { count++; } // SW

            return count;
        }
    }
}
