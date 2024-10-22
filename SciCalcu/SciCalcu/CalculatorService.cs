using System;

namespace ScientificCalculator
{
    // Service Layer - Processes input and communicates with Core
    public class CalculatorService
    {
        private readonly CalculatorLogic _logic;

        public CalculatorService()
        {
            _logic = new CalculatorLogic();
        }

        public double PerformOperation(int operation, double[] operands, out ConsoleColor outputColor)
        {
            outputColor = ConsoleColor.White; // Default to white in case something goes wrong.

            switch (operation)
            {
                case 1:
                    outputColor = ConsoleColor.Green;
                    return _logic.Add(operands[0], operands[1]);
                case 2:
                    outputColor = ConsoleColor.Yellow;
                    return _logic.Subtract(operands[0], operands[1]);
                case 3:
                    outputColor = ConsoleColor.Magenta;
                    return _logic.Multiply(operands[0], operands[1]);
                case 4:
                    outputColor = ConsoleColor.Blue;
                    return _logic.Divide(operands[0], operands[1]);
                case 5:
                    outputColor = ConsoleColor.Cyan;
                    return _logic.Power(operands[0], operands[1]);
                case 6:
                    outputColor = ConsoleColor.DarkYellow;
                    return _logic.SquareRoot(operands[0]);
                case 7:
                case 8:
                case 9:
                    outputColor = ConsoleColor.White; // Default color for trigonometric functions

                    switch (operation)
                    {
                        case 7:
                            return _logic.Sine(operands[0]);
                        case 8:
                            return _logic.Cosine(operands[0]);
                        case 9:
                            return _logic.Tangent(operands[0]);
                        default:
                            throw new InvalidOperationException("Invalid trigonometric operation.");
                    }
                default:
                    throw new InvalidOperationException("Invalid operation.");
            }
        }
    }
}
