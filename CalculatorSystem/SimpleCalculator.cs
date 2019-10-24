namespace CalculatorSystem
{
    public abstract class SimpleCalculator<T>
    {
        public abstract T Add(T number1, T number2);
        public abstract T Subtract(T number1, T number2);
        public abstract T Divide(T number1, T number2);
        public abstract T Multiply(T number1, T number2);
    }
}
