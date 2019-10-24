using System;

namespace CalculatorSystem
{
    public class FloatComplexCalculator : ComplexCalculator<float>
    {
        private static FloatComplexCalculator _instance;

        private FloatComplexCalculator()
        {

        }

        public static FloatComplexCalculator Instance()
        {
            if (_instance == null)
                _instance = new FloatComplexCalculator();

            return _instance;
        }

        public override float Power(float number, float index)
        {
            float result = 1;
            for (int i = 0; i < index; i++)
                result *= number;

            return result;
        }
    }
}
