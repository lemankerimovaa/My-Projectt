using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Projectt
{
    public static class Conditions
    {
        public static int Condition1(int a, int b)    //2.1
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }
        }
        public static string WhichQuarter(int x, int y)   //2.2
        {
            if (x > 0 && y > 0)
            {
                return "Точка принадлежит 1 четверти";
            }
            else if (x < 0 && y > 0)
            {
                return "Точка принадлежит 2 четверти";
            }
            else if (x < 0 && y < 0)
            {
                return "Точка принадлежит 3 четверти";
            }
            else if (x > 0 && y < 0)
            {
                 return "Точка принадлежит 4 четверти";
            }
            else 
            {
                return "Начало координата";
            }
        }
        public static string TwoDigitNumber(int A)      //2.5
        {
            int desatki = A / 10;
            int edinici = A % 10;
            if (A >= 20)
            {
                if (desatki == 2)
                {
                    return "двадцадь";
                }
                else if (desatki == 3)
                    return "тридцадь ";
                else if (desatki == 4)
                    return "сорок ";
                else if (desatki == 5)
                    return "пятьдесят ";
                else if (desatki == 6)
                    return "шестьдесят ";
                else if (desatki == 7)
                    return "семьдесят ";
                else if (desatki == 8)
                    return "восемьдесят ";
                else
                    return "девяносто ";

                if (edinici == 0)
                {
                    return " ";
                }
                else if (edinici == 1)
                    return "один ";
                else if (edinici == 2)
                    return "два ";
                else if (edinici == 3)
                    return "три ";
                else if (edinici == 4)
                    return "четыре ";
                else if (edinici == 5)
                    return "пять ";
                else if (edinici == 6)
                    return "шесть ";
                else if (edinici == 7)
                    return "семь ";
                else if (edinici == 8)
                    return "восемь ";
                else
                    return "девядь ";
            }
            else if (A == 10)
            {
                return "десять ";
            }
            else if (A == 11)
                return "одиннадцать ";
            else if (A == 12)
                return "двенадцать ";
            else if (A == 13)
                return "тринадцать ";
            else if (A == 14)
                return "четырнадцать ";
            else if (A == 15)
                return "пятнадцать ";
            else if (A == 16)
                return "шестнадцать ";
            else if (A == 17)
                return "семнадцать ";
            else if (A == 18)
                return "восемнадцать ";
            else
                return "девятнадцать ";
        }
    }
}
