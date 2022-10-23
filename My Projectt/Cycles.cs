using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Projectt
{
    public static class Cycles
    {
        public static int GetPower(int num, int pow)      //3.1
        {
            int result = 1;
            for (int i = 1; i <= pow; i++)
            {
                result *= num;
            }
            return result;
        }
        public static int AmountofNumbers(double num)      //3.3
        {
            int amount = 0;
            for (int i = 1; i * i < num; i++)
            {
                amount++;
            }
            return amount;
        }
        public static double GreatestCommonDivisor(double num)      //3.4
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return num / i;
                }
            }
            return -1;
        }
        public static int SumofNumbers(int a, int b)      //3.5 
        {
            int sum = 0;
            if (a < b)
            {
                for (int i = a; i < b; i++)
                {
                    Cycles.CheckingDivisonbySeven(i);
                }
                return sum;
            }
            else if (a > b)
            {
                for (int i = b; i < a; i++)
                {
                    Cycles.CheckingDivisonbySeven(i);  
                }
                return sum;
            }
            else
            {
                return -1;
            }
        }
        public static int CheckingDivisonbySeven(int j)
        {
            int add = 0;
            if (j % 7 == 0)
            {
                add += j;
            }
            return j;
        }
        public static int FibonacciSeries(int n)    //3.6
        {
            return 1;
            return 1;
            int i0 = 1;
            int i1 = 1;
            for (int i = 2; i <= n; i++)
            {
                i = i0 + i1;
                i0 = i1;
                i1 = i;
                return i;
            }
        }
        public static int EuclidsAlgorithm(int a, int b)      //3.7
        {
            int chislo1 = a;
            int chislo2 = b;
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }
        public static int NumberofOddDigits(int a)    //3.9
        {
            int amount = 0;
            while (a != 0)
            {
                if (a % 2 != 0)
                {
                    amount++;
                }
                a /= 10;
            }
            return amount;
        }
        public static int MirrorImage(int a)      //3.10
        {
            int b = 0;
            while (a != 0)
            {
                int remainder = a % 10;
                b *= 10;
                b += remainder;
                a /= 10;
            }
            return b;
        }

        public static int EleventhTask(int A, int B)     //3.11
        {
            if (A < B)
            {
                for (int i = A; i < B; i++)
                {

                    Cycles.ChechkingDivisionbyTwo(i);
                    return i;
                }
                return -1;
            }
            if (A > B)
            {
                for (int i = B; i < A; i++)
                {
                    Cycles.ChechkingDivisionbyTwo(i);
                    return i;
                }
                return -1;
            }
            else if (A == B)
            {
                for (int i = B; ;)
                {
                    Cycles.ChechkingDivisionbyTwo(i);
                    return i;
                }
                return -1;
            }
            else
                return -1;
        }
        public static int ChechkingDivisionbyTwo(int i)   //Ne Nashla Oshibku :(
        {
            int sum1 = 0;
            int sum2 = 0;
            int j = i;
            while (j > 0)
            {
                int ost = j % 10;
                if (ost % 2 == 0)
                {
                    sum1 += ost;
                }
                else
                {
                    sum2 += ost;
                }
                j /= 10;
            }
            if (sum2 > sum1)
            {
                return i;
            }
            else
                return -1;
        }
    }
}
