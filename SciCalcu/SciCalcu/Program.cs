using System;

namespace ScientificCalculator
{

    // Presentation Layer - Handles user interaction
    public class CalculatorUI
    {
        private readonly CalculatorService _service;

        public CalculatorUI()
        {
            _service = new CalculatorService();
        }

        public void Start()
        {
            DisplayWelcomeMessage();

            while (true)
            {
                try
                {
                    DisplayMenu();
                    int operation = int.Parse(Console.ReadLine());

                    if (operation == 0)
                    {
                        Console.WriteLine("Thank you for using the Scientific Calculator. Goodbye!");
                        break;
                    }

                    double[] operands = GetOperands(operation);
                    ConsoleColor outputColor;
                    double result = _service.PerformOperation(operation, operands, out outputColor);

                    Console.ForegroundColor = outputColor;
                    Console.WriteLine($"\n-------------------------");
                    Console.WriteLine($"| Result: {result}       |");
                    Console.WriteLine("-------------------------\n");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nError: {ex.Message}\n");
                    Console.ResetColor();
                }
            }
        }

        private double[] GetOperands(int operation)
        {
            if (operation == 6 || operation == 7 || operation == 8 || operation == 9)
            {
                Console.WriteLine("Enter the number (or angle in degrees for trig functions):");
                return new[] { double.Parse(Console.ReadLine()) };
            }
            else
            {
                Console.WriteLine("Enter the first number:");
                double operand1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double operand2 = double.Parse(Console.ReadLine());
                return new[] { operand1, operand2 };
            }
        }

        private void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================");
            Console.WriteLine("     Welcome to Scientific Calculator ");
            Console.WriteLine("======================================\n");
            Console.ResetColor();
        }

        private void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nSelect an operation by pressing a number:");
            Console.WriteLine(" 1 - Add");
            Console.WriteLine(" 2 - Subtract");
            Console.WriteLine(" 3 - Multiply");
            Console.WriteLine(" 4 - Divide");
            Console.WriteLine(" 5 - Power");
            Console.WriteLine(" 6 - Square Root");
            Console.WriteLine(" 7 - Sine");
            Console.WriteLine(" 8 - Cosine");
            Console.WriteLine(" 9 - Tangent");
            Console.WriteLine(" 0 - Exit");
            Console.ResetColor();
            Console.Write("Enter your choice: ");
        }
    }

    // Program Entry Point
    class Program
    {
        static void Main(string[] args)
        {
            var calculatorUI = new CalculatorUI();
            calculatorUI.Start();
        }
    }
}
