namespace LeetCode.Medium.Problem73
{
    using System.Collections.Generic;
    using System.Text;
    
    public class SolutionDefault
    {
        public string SimplifyPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return path;
            }

            const string moveUp = "..";
            const string current = ".";
            const string slash = "/";
            
            string[] split = path.Split('/');

            var stack = new Stack<string>(path.Length);
            
            for (int i = 0; i < split.Length; i++)
            {
                string subtext = split[i];
                
                if(string.IsNullOrEmpty(subtext) || subtext.Equals(current)) 
                    continue;

                if (subtext.Equals(moveUp)) 
                {
                    if(stack.Count > 0) stack.Pop();
                    
                    continue;
                }

                if (subtext.Contains(moveUp))
                {
                    return path.TrimEnd(slash[0]);
                }
                
                stack.Push(subtext);
            }

            var resultList = new List<string>(stack);
            var result = new StringBuilder();
            result.Append(slash);
            
            for (int i = resultList.Count - 1; i >= 0; i--)
            {
                result.Append(resultList[i]);
                if (i - 1 >= 0) result.Append(slash);
            }

            return result.ToString();
        }
    }
}