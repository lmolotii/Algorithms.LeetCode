using System;
using System.Collections.Generic;
using System.Data;

namespace LeetCode.Exercises.Queues
{
    public class NumberOfIslands
    {
        public int NumIslands(char[,] grid)
        {
            int maxY = grid.GetLength(0);
            int maxX = grid.GetLength(1);
            
            bool[,] visited = new bool[maxY,maxX];

            int numberOfIslands = 0;

            for (int x = 0; x < maxX; x++)
            {
                for (int y = 0; y < maxY; y++)
                {
                    var land = new Land(x, y, grid[y, x]);
                    if (land.IsLand && !visited[y,x])
                    {
                        numberOfIslands++;
                        OutlineIsland(land, grid, visited);
                    }
                    if (!land.IsLand && !visited[y,x])
                    {
                        visited[y, x] = true;
                    }
                }
            }

            return numberOfIslands;
        }

        private void OutlineIsland(Land landToStart, char[,] grid, bool[,] visitedPlaces)
        {
            var queue = new Queue<Land>();
            
            int maxY = grid.GetLength(0);
            int maxX = grid.GetLength(1);

            
            queue.Enqueue(landToStart);

            while (queue.TryDequeue(out Land land))
            {
                int x = land.X;
                int y = land.Y;
                
                if (land.X + 1 < maxX)
                {
                    x = land.X + 1;
                    y = land.Y;
                    
                    ProcessLand(x, y, grid[y, x],queue,visitedPlaces);
                }

                if (land.X - 1 >= 0)
                {
                    x = land.X - 1;
                    y = land.Y;
                    
                    ProcessLand(x, y, grid[y, x],queue,visitedPlaces);
                }

                if (land.Y + 1 < maxY)
                {
                    x = land.X;
                    y = land.Y + 1;
                    
                    ProcessLand(x, y, grid[y, x],queue,visitedPlaces);
                }

                if (land.Y - 1 >= 0)
                {
                    x = land.X;
                    y = land.Y - 1;
                    
                    ProcessLand(x, y, grid[y, x],queue,visitedPlaces);
                }
            }
        }

        private void ProcessLand(int x, int y, char symbol, Queue<Land> queue, bool[,] visitedPlaces)
        {
            var newLand = new Land(x, y, symbol);

            if (!visitedPlaces[y, x])
            {
                visitedPlaces[y, x] = true;
                if (newLand.IsLand)
                    queue.Enqueue(newLand); 
            }
        }

        public class Land
        {
            public readonly int Y;
            public readonly int X;
            public readonly char Symbol;

            public bool IsLand => Symbol == '1';

            public Land(int x, int y, char symbol)
            {
                Y = y;
                X = x;
                Symbol = symbol;
            }
        }
    }
}