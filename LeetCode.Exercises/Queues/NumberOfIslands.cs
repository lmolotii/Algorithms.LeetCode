using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LeetCode.Exercises.Queues
{
    public class NumberOfIslands
    {
        public int NumIslands(char[,] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;


            int islandsNumber = 0;
            
            var stack = new Queue<Land>();
            var visited = new HashSet<Land>();

            int maxRow = grid.GetLength(0);
            int maxColumn = grid.GetLength(1);

            var defaultLand = new Land(0, 0, grid[0, 0]);
            if (defaultLand.IsLand)
                islandsNumber++;
                
            stack.Enqueue(defaultLand);

            while (stack.Count > 0)
            {
                var item = stack.Dequeue();

                int newRow = item.Row + 1;
                int newColumn = item.Column + 1;

                var landRigh = new Land(newRow, item.Column, grid[newRow, item.Column]);
                var landBottom = new Land(item.Row, newColumn, grid[item.Row, newColumn]);
                    
                if (newRow < maxRow && !visited.Contains(landRigh))
                    stack.Enqueue(landRigh);

                if (newColumn < maxColumn && !visited.Contains(landBottom))
                    stack.Enqueue(landBottom);

                visited.Add(item);
            }

            return islandsNumber;
        }
        
        public struct Land
        {
            public readonly int Row;
            public readonly int Column;
            public readonly char Symbol;

            public bool IsLand => Symbol == '1';

            public Land(int row, int column, char symbol)
            {
                Row = row;
                Column = column;
                Symbol = symbol;
            }

            public override int GetHashCode()
            {
                return 424576 + Row.GetHashCode()
                            + Column.GetHashCode() 
                            + Symbol.GetHashCode();
            }
        }
    }
}