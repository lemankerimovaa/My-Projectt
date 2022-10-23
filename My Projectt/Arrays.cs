using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Projectt
{
    public static class Arrays
    {
        public static int GettheMinimumElement(int[] myarray)
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
    }
}
