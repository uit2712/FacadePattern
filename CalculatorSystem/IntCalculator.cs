namespace CalculatorSystem
{
    public class IntCalculator : SimpleCalculator<int>
    {
        private static IntCalculator _instance;

        private IntCalculator()
        {

        }

        public static IntCalculator Instance()
        {
            if (_instance == null)
                _instance = new IntCalculator();

            return _instance;
        }

        public override int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public override int Divide(int number1, int number2)
        {
            if (number2 == 0)
                return 0;

            return number1 / number2;
        }

        public override int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public override int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
