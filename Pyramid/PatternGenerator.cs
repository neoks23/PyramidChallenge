using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid
{
    public class PatternGenerator
    {
        public string ReverseMarioStairs(int n)
        {
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                result += new string('*', i) + "\n";
            }

            return result;
        }
        
        public string MarioStairs(int n)
        {
            return "";
        }
        public string Pyramid(int n)
        {
            return "";
        }
        public string SteepPyramid(int n)
        {
            return "";
        }
        public string Diamond(int n)
        {
            return "";
        }
    }
}
