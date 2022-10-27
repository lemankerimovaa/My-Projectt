using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Projectt
{
    public static class Arrays
    {
        public static int[] Fibonacci(int n)      //3.6 Второй способ
        {
            int[] myarray = new int[n];
            int i0 = 0;
            int i1 = 1;
            for (int i = 0; i < myarray.Length; i++)
            {
                int j = i0 + i1;
                i0 = i1;
                i1 = j;
                myarray[i] = i0;
            }
            
            return myarray;
        }
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
      /*  public static int GettheMinimumIndex(int[] myarray)
        {
            int min = myarray[0];
            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] > myarray[0])
                {
                    min = myarray[i];
                }
            }
            Index myindex = i;
            return min;
        }*/
        
    }
}
