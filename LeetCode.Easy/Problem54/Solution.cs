using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LeetCode.Easy.Problem54
{
    public class Solution
    {
        public IList<int> SpiralOrder(int[,] matrix) 
        {            
            if(matrix.GetLength(0) < 1 || matrix.GetLength(1) < 1)
                return new List<int>();
            
            var result = new List<int>(matrix.Length);
            
            int maxY = matrix.GetLength(0)-1;
            int maxX = matrix.GetLength(1)-1;

            int minY = 0;
            int minX = 0;

            int x = 0;
            int y = 0;

            bool horizontalMove = true;

            result.Add(matrix[x,y]);
            
            for (int i = 1; i < matrix.Length; i++)
            {                
                if (y - 1 < minY && x + 1 <= maxX) //From left to right
                {
                    x++;
                    
                    if (!horizontalMove)
                    {
                        minX++;
                        horizontalMove = true;
                    }
                }
                else if (x + 1 > maxX && y + 1 <= maxY) //From top right to bottom right  
                {
                    y++;
                    
                    if (horizontalMove)
                    {
                        minY++;
                        horizontalMove = false;
                    }
                }
                else if (y + 1 > maxY && x - 1 >= minX) //From bottom right to bottom left 
                {
                    x--;
                    
                    if (!horizontalMove)
                    {
                        maxY--;
                        horizontalMove = true;
                    }

                    if (minY - maxY == 1)
                    {
                        maxX--;
                    }
                }
                else if (x - 1 < minX && y - 1 >= minY) // Bottom left to top left
                {
                    y--;
                    
                    if (horizontalMove)
                    {
                        maxX--;
                        horizontalMove = false;
                    }
                    
                    if (maxX - minX == 0)
                    {
                        maxY--;
                    }
                }
                
                result.Add(matrix[y,x]);
            }
            
            return result;
        }
    }
}