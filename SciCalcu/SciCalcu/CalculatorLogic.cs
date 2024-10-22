using System;

namespace ScientificCalculator
{
    // Core Layer - Business Logic
    public class CalculatorLogic
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }

        public double Power(double baseNum, double exponent) => Math.Pow(baseNum, exponent);
        public double SquareRoot(double a) => Math.Sqrt(a);
        public double Sine(double angleInDegrees) => Math.Sin(angleInDegrees * (Math.PI / 180));
        public double Cosine(double angleInDegrees) => Math.Cos(angleInDegrees * (Math.PI / 180));
        public double Tangent(double angleInDegrees) => Math.Tan(angleInDegrees * (Math.PI / 180));
    }
}
