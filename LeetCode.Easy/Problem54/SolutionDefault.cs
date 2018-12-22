using System.Collections.Generic;

namespace LeetCode.Easy.Problem54
{
    public class SolutionDefault
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var ans = new List<int>();
            
            if (matrix.Length == 0) 
                return ans;

            int rMax = matrix.GetLength(0);
            int cMax = matrix.GetLength(1);
            
            bool [,] seen = new bool[rMax,cMax];
            
            int[] dr = {0, 1, 0, -1};
            int[] dc = {1, 0, -1, 0};
            
            int r = 0, c = 0, di = 0;
            
            
            for (int i = 0; i < matrix.Length; i++) 
            {
                ans.Add(matrix[r,c]);
                seen[r,c] = true;
                
                int cr = r + dr[di];
                int cc = c + dc[di];
                
                if (cr >= 0 && cr < rMax && cc >= 0 && cc < cMax && !seen[cr,cc])
                {
                    r = cr;
                    c = cc;
                } 
                else 
                {
                    di = (di + 1) % 4;
                    r += dr[di];
                    c += dc[di];
                }
            }
            return ans;
        }
    }
}