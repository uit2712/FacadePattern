using CalculatorSystem;

namespace FacadeDemo
{
    class CalculatorFacade
    {
        private static CalculatorFacade _instance;

        private CalculatorFacade()
        {

        }

        public static CalculatorFacade Instance()
        {
            if (_instance == null)
                _instance = new CalculatorFacade();

            return _instance;
        }

        public int Add(int number1, int number2)
        {
            return IntCalculator.Instance().Add(number1, number2);
        }

        public float Add(float number1, float number2)
        {
            return FloatCalculator.Instance().Add(number1, number2);
        }

        public int Substract(int number1, int number2)
        {
            return IntCalculator.Instance().Subtract(number1, number2);
        }

        public float Substract(float number1, float number2)
        {
            return FloatCalculator.Instance().Subtract(number1, number2);
        }

        public int Divide(int number1, int number2)
        {
            return IntCalculator.Instance().Divide(number1, number2);
        }

        public float Divide(float number1, float number2)
        {
            return FloatCalculator.Instance().Divide(number1, number2);
        }

        public int Multiply(int number1, int number2)
        {
            return IntCalculator.Instance().Multiply(number1, number2);
        }

        public float Multiply(float number1, float number2)
        {
            return FloatCalculator.Instance().Multiply(number1, number2);
        }

        public int Power(int number1, int number2)
        {
            return IntComplexCalculator.Instance().Power(number1, number2);
        }

        public float Power(float number1, float number2)
        {
            return FloatComplexCalculator.Instance().Power(number1, number2);
        }
    }
}
