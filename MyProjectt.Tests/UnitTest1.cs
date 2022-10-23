using My_Projectt;
using NUnit.Framework;
namespace MyProjectt.Tests
{
    public class VariablesTests
    {
        [TestCase(11, 2, 5)]
        public void DivisionTests(int a, int b, int expected)   //1.1
        {
            int actual = Variables.Division(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 2, 9)]
        public void Equation1Test(int a, int b, int expected)    //1.2
        {

            int actual = Variables.Equation1(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 2, 3, 1)]
        public void Equation2Tests(int a, int b, int c, int expected)     //1.4
        {

            int actual = Variables.Equation2(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 5, 2, 6, "y=1x+4" )]
        public void EquationofStraightLineTests(int x1, int y1, int x2, int y2, string expected)   //1.5
        {

            string actual = Variables.EquationofStraightLine(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }
    }
    public class ConditionsTests
    {
        [TestCase(2,2,4)]
        public void Condition1Tests(int a, int b, int expected)     //2.1
        {

            int actual = Conditions.Condition1(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 2, "“очка принадлежит 1 четверти")]
        public void WhichQuarterTests(int x, int y, string expected)     //2.2
        {

            string actual = Conditions.WhichQuarter(x,y);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(16, "шестнадцать ")]
        public void TwoDigitNumberTests(int A, string expected)     //2.5
        {

            string actual = Conditions.TwoDigitNumber(A);
            Assert.AreEqual(expected, actual);
        }
    }
    public class CyclesTests
    {
        [TestCase(2, 10, 1024)]
        [TestCase(5, 3, 125)]
        public void GetPowerTests(int num, int pow, int expected)     //3.1
        {

            int actual = Cycles.GetPower(num, pow);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10, 3)]
        public void AmountofNumbersTests(int num, int expected)     //3.3
        {

            int actual = Cycles.AmountofNumbers(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(20, 10)]
        public void GreatestsCommonDivisorTests(int num, int expected)     //3.4
        {

            double actual = Cycles.GreatestCommonDivisor(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 15, 21)]
        public void SumofNumbersTests(int a, int b, int expected)     //3.5
        {

            int actual = Cycles.SumofNumbers(a,b);
            Assert.AreEqual(expected, actual);
        }
        /*[TestCase(6,1,1,2,3,5,8)]     kak ukazat otvet
        public void FibonacciSeriesTest(int n, int expected)      3.6
        {
            int actual = Cycles.FibonacciSeries(n);
            Assert.AreEqual(expected, actual);
        }*/
        [TestCase(18, 44, 2)]
        public void EuclidsAlgorithmTests(int a, int b, int expected)     //3.7
        {

            int actual = Cycles.EuclidsAlgorithm(a, b);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(123, 2)]
        public void NumberofOddDigitsTests(int a, int expected)     //3.9
        {

            int actual = Cycles.NumberofOddDigits(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(123, 321)]
        public void MirrorImageTests(int a, int expected)     //3.10
        {

            int actual = Cycles.MirrorImage(a);
            Assert.AreEqual(expected, actual);
        }
        /*[TestCase(120, 125, 120, 122, 124)]   kak ukazat otvet
        public void EleventhTaskTests(int a, int b, int expected)     3.11
        {
            int actual = Cycles.EleventhTask(a,b);
            Assert.AreEqual(expected, actual);
        }*/
    }
}