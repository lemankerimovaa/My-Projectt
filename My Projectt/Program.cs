using My_Projectt;
//Dz 1.1
#region
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int C = A / B;
int D = A % B;
Console.WriteLine(C);
Console.WriteLine(D);*/
#endregion

//Dz 1.2
#region
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int C = (5 * A + Convert.ToInt32(Math.Pow(B, 2)) / (B - A));
Console.WriteLine(C);*/
#endregion

//Dz 1.3
#region
/*Console.WriteLine("Введите строку A");
string A = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите строку B");
string B = Convert.ToString(Console.ReadLine());
string C;
C=A;
A=B;
B = C;
Console.WriteLine("A= " + A);
Console.WriteLine("B= " + B);*/
#endregion

//Dz 1.4
#region
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C");
int C = Convert.ToInt32(Console.ReadLine());
int X=(C-B)/ A;
Console.WriteLine("X= "+X);*/

#endregion

//Dz 1.5
#region
/*Console.WriteLine("Введите число X1");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y1");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число X2");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y2");
int Y2 = Convert.ToInt32(Console.ReadLine());
int A = (Y2 - Y1) / (X2 - X1);
int B = Y1 - A * X1;
int X, Y;
Console.WriteLine("Y="+A+"X+"+B);*/
#endregion

//Dz 2.1
#region
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B) 
{
    Console.WriteLine(A + B);  
}
else if (A == B)
{
    Console.WriteLine(A * B);
}
else
{
    Console.WriteLine(A-B);
}*/
#endregion

//Dz 2.2
#region
/*Console.WriteLine("Введите число X");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y");
int Y= Convert.ToInt32(Console.ReadLine());
if (X>0 && Y>0)
{
    Console.WriteLine("Точка принадлежит 1 четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка принадлежит 2 четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка принадлежит 3 четверти");
}
else 
{
    Console.WriteLine("Точка принадлежит 4 четверти");
}
*/
#endregion

//Dz 2.3
#region
/*Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C ");
int C = Convert.ToInt32(Console.ReadLine());
if(A<B && A<C)
{
    Console.WriteLine(A);
    Console.WriteLine(Math.Min(B,C));
    Console.WriteLine(Math.Max(B, C));
}
else if (B < A && B < C)
{
    Console.WriteLine(B);
    Console.WriteLine(Math.Min(A, C));
    Console.WriteLine(Math.Max(A, C));
}
else
{
    Console.WriteLine(C);
    Console.WriteLine(Math.Min(A, B));
    Console.WriteLine(Math.Max(A, B));
}
*/
#endregion

//Dz 2.4
#region
/*Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C ");
int C = Convert.ToInt32(Console.ReadLine());
double D = Convert.ToDouble(Math.Pow(B, 2)) - (4 * A * C);
if (D>0)
{
    double X1 = (-B + Convert.ToDouble(Math.Sqrt(D))) / (2 * A);
    double X2 = (-B - Convert.ToDouble(Math.Sqrt(D))) / (2 * A);
    Console.WriteLine("X1= " + X1 + "X2= " + X2);
}
else if (D==0)
{
    double X = (-B) / (2 * A);
    Console.WriteLine("X= " + X);
}
else
{
    Console.WriteLine("Ошибка!");
}*/
#endregion

//Dz 2.5
#region
/*Console.WriteLine("Vvedite chislo");
int A = Convert.ToInt32(Console.ReadLine());
int desatki = A / 10;
int edinici = A % 10;
if (A>=20)
{
    if (desatki==2)
    {
        Console.WriteLine("двадцадь ");
    }
    else if (desatki == 3)
        Console.WriteLine("тридцадь ");
    else if (desatki == 4)
        Console.WriteLine("сорок ");
    else if (desatki == 5)
        Console.WriteLine("пятьдесят ");
    else if (desatki == 6)
        Console.WriteLine("шестьдесят ");
    else if (desatki == 7)
        Console.WriteLine("семьдесят ");
    else if (desatki == 8)
        Console.WriteLine("восемьдесят ");
    else  
        Console.WriteLine("девяносто ");

    if (edinici == 0)
    {
        Console.WriteLine(" ");
    }
    else if (edinici == 1)
        Console.WriteLine("один ");
    else if (edinici == 2)
        Console.WriteLine("два ");
    else if (edinici == 3)
        Console.WriteLine("три ");
    else if (edinici == 4)
        Console.WriteLine("четыре ");
    else if (edinici == 5)
        Console.WriteLine("пять ");
    else if (edinici == 6)
        Console.WriteLine("шесть ");
    else if (edinici == 7)
        Console.WriteLine("семь ");
    else if (edinici == 8)
        Console.WriteLine("восемь ");
    else 
        Console.WriteLine("девядь ");
}
else if (A==10)
{
    Console.WriteLine("десять ");
}
else if (A == 11)
    Console.WriteLine("одиннадцать ");
else if (A == 12)
    Console.WriteLine("двенадцать ");
else if (A == 13)
    Console.WriteLine("тринадцать ");
else if (A == 14)
    Console.WriteLine("четырнадцать ");
else if (A == 15)
    Console.WriteLine("пятнадцать ");
else if (A == 16)
    Console.WriteLine("шестнадцать ");
else if (A == 17)
    Console.WriteLine("семнадцать ");
else if (A == 18)
    Console.WriteLine("восемнадцать ");
else 
    Console.WriteLine("девятнадцать ");*/
#endregion

//Dz 3.1
#region
/*Console.WriteLine("Введите число A ");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень B ");
int B=Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < B; i++)
{
    result *= A;
}
Console.WriteLine("{0}^{1}={2}",A,B,result);*/
#endregion

//Dz 3.2
#region
/*Console.WriteLine("Введите число A ");
int A=Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=1000; i++)
{
   if (i%A==0)
    {
        Console.WriteLine(i);
    }                                                                                                                                                                                                                                                    
}*/
#endregion

//Dz 3.3
#region
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
int kol = 0;
for (int i = 1; i < A; i++)
{
    i *= i;
    kol += 1;
}
Console.WriteLine($"Количество чисел квадрат которых меньше {A} = " + kol);*/
#endregion

//Dz 3.4
#region
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < A; i++)
{
    if (A % i == 0)
    {
        Console.WriteLine(i);
    }
}*/
#endregion

//Dz 3.5
#region
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B= Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (A<B)
{
    for (int i = A; i < B; i++)
    {
        if (i % 7 == 0)
        {
            sum += i;
        }
    }
}
else if (A>B)
{
    for (int i = B; i < A; i++)
    {
        if (i % 7 == 0)
        {
            sum += i;
        }
    }
}
else
{
    Console.WriteLine("Ошибка!");
}
Console.WriteLine(sum);*/
#endregion

//Dz 3.6  
#region
/*Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1");
Console.WriteLine("1");
int i0 = 1;
int i1 = 1;
for (int i = 2; i <= n; i++)
{
    i = i0 + i1;
    i0 = i1;
    i1 = i;
    Console.WriteLine(i);
}*/
#endregion

//Dz 3.7
#region
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int chislo1 = A;
int chislo2 = B;
while (A != B)
{
    if (A > B)
    {
        A = A - B;
    }
    else 
    {
        B = B - A;
    }
}
Console.WriteLine($"Наибольший общий делитель {chislo1}, {chislo2} = {A}");*/
#endregion

//Dz 3.8 Ne sdelala:(

//Dz 3.9
#region
/*Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
int kol = 0;
while(A!=0)
{
    if (A%2!=0)
    {
        kol += 1;
    }
    A /= 10;
}
Console.WriteLine($"Количество нечетных чисел = {kol}");
*/
#endregion

//Dz 3.10
#region
/*Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
int B = 0;
while (A!=0)
{
    int ostatok = A % 10;
    B*=10;
    B+=ostatok;
    A /= 10;
}
Console.WriteLine(B);*/
#endregion

//Dz 3.11  
#region
/*Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

if (A<B)
{
    for (int i = A; i < B; i++)
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
        if (sum1 > sum2)
        {
            Console.WriteLine(i);
        }

    }
}
if (A > B)
{
    for (int i = B; i < A; i++)
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
        if (sum1 > sum2)
        {
            Console.WriteLine(i);
        }

    }
}
else
{
    for (int i = B; ; )
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
        if (sum1 > sum2)
        {
            Console.WriteLine(i);
        }

    }
}
*/
#endregion

//Dz 3.12 Ne sdelala:(



/*Console.WriteLine(Variables.Division(11, 2));
Console.WriteLine(Variables.Equation1(4, 7));
Console.WriteLine(Variables.Equation2(30, 6, 9));
Variables.EquationofStraightLine(-54, 85, -6, 23);

Console.WriteLine(Conditions.Condition1(8, 4));
Conditions.WhichQuarter(25, -10);
Conditions.TwoDigitNumber(63);

Console.WriteLine(Cycles.GetPower(3, 3));
Console.WriteLine(Cycles.AmountofNumbers(50));
Console.WriteLine(Cycles.GreatestCommonDivisor(12));
Console.WriteLine(Cycles.SumofNumbers(3, 30));
Console.WriteLine(Cycles.FibonacciSeries(15));
Console.WriteLine(Cycles.EuclidsAlgorithm(12,26));
Console.WriteLine(Cycles.NumberofOddDigits(63));
Console.WriteLine(Cycles.MirrorImage(1234));*/
Cycles.EleventhTask(120,130);


/*Console.WriteLine(Arrays.GettheMinimumElement(2, 6, 3));*/
