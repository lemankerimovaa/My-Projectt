using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Projectt
{
    public static int FibonacciSeries(int[] myarray)      //3.6
    {

    }
    public static class Arrays
    {
        public static int GettheMinimumElement(int[] myarray)     //4.1
        {
            int min = myarray[0];
            for (int i = 1; i < myarray.Length; i++)
            {
                if (myarray[i] < myarray[0])
                {
                    min= myarray[i];
                }
            }
            return min;
        }
        public static int GettheMaximumElement(int[] myarray)       //4.2
        {
            int max = myarray[0];
            for (int i = 1; i < myarray.Length; i++)
            {
                if (myarray[i] > myarray[0])
                {
                    max = myarray[i];
                }
            }
            return max;
        }
        
    }
}
