using System;
using System.Linq;

namespace AssignmentSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            Console.Write("Enter a number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 % 3 == 0 && number1 % 4 == 0 ? "Yes" : "No");
            #endregion

            #region Question2
            Console.Write("Enter an integer: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number2 < 0 ? "Negative" : "Positive");
            #endregion

            #region Question3
            Console.WriteLine("Enter three integers separated by space: ");
            int[] numbers3 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine($"Max element = {numbers3.Max()}");
            Console.WriteLine($"Min element = {numbers3.Min()}");
            #endregion

            #region Question4
            Console.Write("Enter an integer: ");
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine(number4 % 2 == 0 ? "Even" : "Odd");
            #endregion

            #region Question5
            Console.Write("Enter a character: ");
            char ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("aeiou".Contains(ch) ? "Vowel" : "Consonant");
            #endregion

            #region Question6
            Console.Write("Enter a number: ");
            int number6 = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", Enumerable.Range(1, number6)));
            #endregion

            #region Question7
            Console.Write("Enter a number for multiplication table: ");
            int number7 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number7} x {i} = {number7 * i}");
            }
            #endregion

            #region Question8
            Console.Write("Enter a number: ");
            int number8 = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", Enumerable.Range(1, number8).Where(n => n % 2 == 0)));
            #endregion

            #region Question9
            Console.Write("Enter base and exponent separated by space: ");
            var inputs9 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Pow(inputs9[0], inputs9[1]));
            #endregion

            #region Question10
            Console.WriteLine("Enter marks for five subjects separated by space: ");
            int[] marks = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int total = marks.Sum();
            double average = marks.Average();
            double percentage = (total / (5.0 * 100)) * 100;
            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average marks = {average}");
            Console.WriteLine($"Percentage = {percentage}%");
            #endregion

            #region Question11
            Console.Write("Enter month number: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine($"Days in Month: {DateTime.DaysInMonth(2024, month)}");
            #endregion

            #region Question12
            Console.WriteLine("Enter first number, operator (+, -, *, /), and second number separated by space:");
            string[] calcInput = Console.ReadLine().Split();
            double num1 = double.Parse(calcInput[0]);
            char oper = calcInput[1][0];
            double num2 = double.Parse(calcInput[2]);
            Console.WriteLine(oper switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num2 != 0 ? num1 / num2 : throw new DivideByZeroException(),
                _ => "Invalid operator"
            });
            #endregion

            // Add other questions similarly...
        }
    }
}
