using System;

namespace CalculatorSystem
{
    public class IntComplexCalculator : ComplexCalculator<int>
    {
        private static IntComplexCalculator _instance;

        private IntComplexCalculator()
        {

        }

        public static IntComplexCalculator Instance()
        {
            if (_instance == null)
                _instance = new IntComplexCalculator();

            return _instance;
        }

        public override int Power(int number, int index)
        {
            int result = 1;
            for (int i = 0; i < index; i++)
                result *= number;

            return result;
        }
    }
}
