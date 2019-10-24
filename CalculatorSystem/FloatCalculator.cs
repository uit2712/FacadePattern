namespace CalculatorSystem
{
    public class FloatCalculator : SimpleCalculator<float>
    {
        private static FloatCalculator _instance;

        private FloatCalculator()
        {

        }

        public static FloatCalculator Instance()
        {
            if (_instance == null)
                _instance = new FloatCalculator();

            return _instance;
        }

        public override float Add(float number1, float number2)
        {
            return number1 + number2;
        }

        public override float Divide(float number1, float number2)
        {
            if (number2 == 0)
                return 0;

            return number1 / number2;
        }

        public override float Multiply(float number1, float number2)
        {
            return number1 * number2;
        }

        public override float Subtract(float number1, float number2)
        {
            return number1 - number2;
        }
    }
}
