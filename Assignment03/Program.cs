namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //// Prompt the user to enter a number
            //Console.Write("Enter a number: ");

            //// Read the input number from the user
            //string input = Console.ReadLine();
            //int number;

            //// Validate input and check divisibility
            //if (int.TryParse(input, out number))
            //{
            //    if (number % 3 == 0 && number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}

            #endregion

            #region Q2

            //// Prompt the user to enter an integer
            //Console.Write("Enter an integer: ");

            //// Read the input integer from the user
            //string input2 = Console.ReadLine();
            //int number2;

            //// Validate input and check if negative or positive
            //if (int.TryParse(input2, out number2))
            //{
            //    if (number2 < 0)
            //    {
            //        Console.WriteLine("negative");
            //    }
            //    else
            //    {
            //        Console.WriteLine("positive");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Q3

            //// Prompt the user to enter three integers
            //Console.Write("Enter three integers separated by spaces: ");

            //// Read the input integers from the user
            //string input3 = Console.ReadLine();
            //string[] inputs = input3.Split(' ');
            //int number3, number4, number5;

            //// Validate input and find max and min elements
            //if (inputs.Length == 3 && int.TryParse(inputs[0], out number3) && int.TryParse(inputs[1], out number4) && int.TryParse(inputs[2], out number5))
            //{
            //    int max = Math.Max(number3, Math.Max(number4, number5));
            //    int min = Math.Min(number3, Math.Min(number4, number5));

            //    Console.WriteLine($"Max element = {max}");
            //    Console.WriteLine($"Min element = {min}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter three valid integers separated by spaces.");
            //}

            #endregion

            #region Q4
            //Console.WriteLine("Please enter an integer number:");
            //int number = int.Parse(Console.ReadLine());
            //#endregion

            //#region EvenOrOddCheck
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine($"{number} is an even number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is an odd number.");
            //}
            #endregion

            #region Q5
            //Console.WriteLine("Please enter a character:");
            //char character = char.ToLower(Console.ReadKey().KeyChar);
            //Console.WriteLine();
            //if ("aeiou".Contains(character))
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}
            #endregion

            #region Q6
            //Console.WriteLine("Please enter an integer:");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(i + (i < number ? ", " : "\n"));
            //}
            #endregion

            #region Q7
            //Console.WriteLine("Please enter an integer:");
            //int multiplier = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(multiplier * i + (i < 12 ? " " : "\n"));
            //}
            #endregion

            #region Q8
            //Console.WriteLine("Please enter an integer:");
            //int maxNumber = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= maxNumber; i += 2)
            //{
            //    Console.Write(i + (i < maxNumber - 1 ? " " : "\n"));
            //}
            #endregion

            #region Q9
            //    Console.WriteLine("Please enter two integers (base and exponent):");
            //    Console.WriteLine("Enter the base number: ");
            //    int baseNumber = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the exponent: ");
            //    int exponent = int.Parse(Console.ReadLine());

            //    int result = CalculatePower(baseNumber, exponent);

            //    Console.WriteLine($"The result of {baseNumber}^{exponent} is: {result}");
            //}

            //static int CalculatePower(int baseNumber, int exponent)
            //{
            //    int result = 1;

            //    for (int i = 0; i < exponent; i++)
            //    {
            //        result *= baseNumber;
            //    }

            //    return result;
            #endregion

            #region Q10
            ////    Console.WriteLine("Enter Marks of five subjects (separated by spaces): ");
            ////    string input = Console.ReadLine();

            ////    string[] marksArray = input.Split(' ');

            ////    int[] marks = new int[5];
            ////    for (int i = 0; i < marksArray.Length; i++)
            ////    {
            ////        marks[i] = int.Parse(marksArray[i]);
            ////    }

            ////    int totalMarks = CalculateTotalMarks(marks);
            ////    int averageMarks = CalculateAverageMarks(marks);
            ////    int percentage = CalculatePercentage(totalMarks);

            ////    Console.WriteLine($"Total marks = {totalMarks}");
            ////    Console.WriteLine($"Average Marks = {averageMarks}");
            ////    Console.WriteLine($"Percentage = {percentage}");
            ////}

            ////static int CalculateTotalMarks(int[] marks)
            ////{
            ////    int total = 0;
            ////    foreach (int mark in marks)
            ////    {
            ////        total += mark;
            ////    }

            ////    return total;
            ////}

            ////static int CalculateAverageMarks(int[] marks)
            ////{
            ////    int totalMarks = CalculateTotalMarks(marks);
            ////    int average = totalMarks / marks.Length;

            ////    return average;
            ////}

            ////static int CalculatePercentage(int totalMarks)
            ////{
            ////    int percentage = totalMarks / 5;

            ////    return percentage;
            #endregion

            #region Q11
            //    Console.WriteLine("Enter the month number (1-12): ");
            //    int monthNumber = int.Parse(Console.ReadLine());

            //    int numberOfDays = GetNumberOfDaysInMonth(monthNumber);

            //    Console.WriteLine($"Days in Month: {numberOfDays}");
            //}

            //static int GetNumberOfDaysInMonth(int monthNumber)
            //{
            //    switch (monthNumber)
            //    {
            //        case 1: // January
            //        case 3: // March
            //        case 5: // May
            //        case 7: // July
            //        case 8: // August
            //        case 10: // October
            //        case 12: // December
            //            return 31;

            //        case 4: // April
            //        case 6: // June
            //        case 9: // September
            //        case 11: // November
            //            return 30;

            //        case 2: // February
            //                // Check if it's a leap year
            //            Console.WriteLine("Enter the year: ");
            //            int year = int.Parse(Console.ReadLine());
            //            bool isLeapYear = DateTime.IsLeapYear(year);
            //            return isLeapYear ? 29 : 28;

            //        default:
            //            return -1; // Invalid month number

            #endregion

            #region Q12

            //Console.WriteLine("Simple Calculator");

            //Console.WriteLine("Enter the first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the operator (+, -, *, /): ");
            //char operation = char.Parse(Console.ReadLine());

            //double result = 0;

            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;

            //    case '-':
            //        result = num1 - num2;
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //            return;
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Error: Invalid operator.");
            //        return;
            //}

            //Console.WriteLine($"Result: {result}");

            #endregion

            #region Q13

            //    Console.WriteLine("Enter a string: ");
            //    string input = Console.ReadLine();

            //    string reversedString = ReverseString(input);

            //    Console.WriteLine($"Reversed string: {reversedString}");
            //}

            //static string ReverseString(string input)
            //{
            //    char[] charArray = input.ToCharArray();
            //    Array.Reverse(charArray);

            //    return new string(charArray);

            #endregion

            #region Q14

            //Console.WriteLine("Enter an integer:");
            //string input = Console.ReadLine();

            //// Reverse the input string
            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //string reversedInput = new string(charArray);

            //// Print the reversed string
            //Console.WriteLine("Reversed integer: " + reversedInput);

            #endregion

            #region Q15

            //    Console.Write("Input starting number of range: ");
            //    int start = int.Parse(Console.ReadLine());

            //    Console.Write("Input ending number of range: ");
            //    int end = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"The prime numbers between {start} and {end} are:");

            //    for (int num = start; num <= end; num++)
            //    {
            //        if (IsPrime(num))
            //        {
            //            Console.Write(num + " ");
            //        }
            //    }
            //}

            //static bool IsPrime(int number)
            //{
            //    if (number <= 1)
            //    {
            //        return false;
            //    }

            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            return false;
            //        }
            //    }

            //    return true;

            #endregion

            #region Q16

            //    Console.Write("Enter a number to convert: ");
            //    int number = int.Parse(Console.ReadLine());

            //    string binary = ConvertToBinary(number);

            //    Console.WriteLine($"The Binary of {number} is {binary}");
            //}

            //static string ConvertToBinary(int num)
            //{
            //    if (num == 0) return "0";

            //    string binary = string.Empty;
            //    while (num > 0)
            //    {
            //        binary = (num % 2) + binary;
            //        num /= 2;
            //    }

            //    return binary;

            #endregion

            #region Q17

            //    // Input points from user
            //    Console.Write("Enter x1: ");
            //    double x1 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter y1: ");
            //    double y1 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter x2: ");
            //    double x2 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter y2: ");
            //    double y2 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter x3: ");
            //    double x3 = double.Parse(Console.ReadLine());

            //    Console.Write("Enter y3: ");
            //    double y3 = double.Parse(Console.ReadLine());

            //    // Determine if the points are on a single straight line
            //    if (ArePointsOnLine(x1, y1, x2, y2, x3, y3))
            //    {
            //        Console.WriteLine("The points lie on a single straight line.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The points do not lie on a single straight line.");
            //    }
            //}

            //static bool ArePointsOnLine(double x1, double y1, double x2, double y2, double x3, double y3)
            //{
            //    // Calculate the area of the triangle formed by the points
            //    double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            //    // If the area is zero, the points are collinear
            //    return Math.Abs(area) < 1e-10;

            #endregion

            #region Q18

            //// Prompt user for the time taken to complete the task
            //Console.Write("Enter the time taken to complete the task (in hours): ");
            //double timeTaken = double.Parse(Console.ReadLine());

            //// Determine the efficiency level based on the time taken
            //if (timeTaken >= 2 && timeTaken < 3)
            //{
            //    Console.WriteLine("The worker is highly efficient.");
            //}
            //else if (timeTaken >= 3 && timeTaken < 4)
            //{
            //    Console.WriteLine("The worker should increase their speed.");
            //}
            //else if (timeTaken >= 4 && timeTaken < 5)
            //{
            //    Console.WriteLine("The worker should be provided with training to enhance their speed.");
            //}
            //else if (timeTaken >= 5)
            //{
            //    Console.WriteLine("The worker should leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a time greater than or equal to 2 hours.");

                #endregion

            }
        }
    }
}
