using System;

namespace FacadeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4.5f;
            var b = 3;
            Console.WriteLine(string.Format("{0}+{1}={2}", a, b, CalculatorFacade.Instance().Add(a, b)));
            Console.WriteLine(string.Format("{0}/{1}={2}", a, b, CalculatorFacade.Instance().Divide(a, b)));
            Console.WriteLine(string.Format("{0}-{1}={2}", a, b, CalculatorFacade.Instance().Substract(a, b)));
            Console.WriteLine(string.Format("{0}*{1}={2}", a, b, CalculatorFacade.Instance().Multiply(a, b)));
            Console.WriteLine(string.Format("{0}^{1}={2}", a, b, CalculatorFacade.Instance().Power(a, b)));
        }
    }
}
