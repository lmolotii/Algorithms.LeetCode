using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium.Problem73
{
    public class Solution
    {
        public string SimplifyPath(string path)
        {
            if (string.IsNullOrEmpty(path))
                return path;

            var simplifiedPath = new Stack<string>(path.Length);

            const char dot = '.';
            const char slash = '/';
            
            char previousSymbol = slash;
            simplifiedPath.Push(slash.ToString());
            
            StringBuilder word = new StringBuilder();
            
            for (int i = 1; i < path.Length; i++)
            {
                char currentSymbol = path[i];
                
                if (previousSymbol == slash && currentSymbol == slash)
                    continue;
                
                if (previousSymbol == dot && currentSymbol == dot)
                {
                    simplifiedPath.Pop();
                    simplifiedPath.Pop();
                    simplifiedPath.TryPop(out var item);

                    if (simplifiedPath.Count == 0)
                    {
                        simplifiedPath.Push(slash.ToString());
                    }
                    
                    previousSymbol = simplifiedPath.Peek()[0];
                    
                    continue;
                }
                else if(previousSymbol == dot && currentSymbol == slash)
                {
                    simplifiedPath.Pop();
                }
                else if (currentSymbol != slash && currentSymbol != dot)
                {
                    word.Append(currentSymbol);
                }
                else if (currentSymbol == slash && word.Length > 0)
                {
                    simplifiedPath.Push(word.ToString());
                    simplifiedPath.Push(currentSymbol.ToString());
                    
                   word = new StringBuilder();
                }
                else if(currentSymbol != slash && i != path.Length - 1)
                {
                    simplifiedPath.Push(currentSymbol.ToString());
                }

                previousSymbol = currentSymbol;
            }

            if (previousSymbol == slash && simplifiedPath.Count > 1) 
                simplifiedPath.Pop();
            
            var result = new List<string>(simplifiedPath);
            StringBuilder resultBuilder = new StringBuilder();

            string value;
            for (int i = simplifiedPath.Count -1 ; i >= 0 ; i--)
            {
                resultBuilder.Append(result[i]);
            }

            return resultBuilder.ToString();
        }
    }
}