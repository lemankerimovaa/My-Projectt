using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Projectt
{
    public static class Variables
    {
        public static int Division(int a, int b)      //1.1
        {
            return a / b;
        }
        public static int Equation1(int a, int b)     //1.2
        {
            int c = (5 * a + b * b) / (b - a);
            return c;
        }
        public static int Equation2(int a, int b, int c)      //1.4
        {
            int x = (c - b) / a;
            return x;
        }
        public static string EquationofStraightLine(int x1, int y1, int x2, int y2)     //1.5
        {
            int a = (y2 - y1) / (x2 - x1);
            int b = y1 - a * x1;
            return $"y={a}x+{b}";
        }
    }
}
