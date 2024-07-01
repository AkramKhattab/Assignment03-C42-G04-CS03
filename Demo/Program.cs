using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Formating

            //// Example: Using String.Format
            //string name = "John";
            //int age = 25;
            //string formattedString = string.Format("Name: {0}, Age: {1}", name, age);
            //Console.WriteLine(formattedString);

            #endregion

            #region 02 Control Statements (Introductions)

            //// Example: Using an if statement
            //int number = 10;
            //if (number > 5)
            //{
            //    Console.WriteLine("The number is greater than 5.");
            //}


            #endregion

            #region 03 Conditional Statements - If, Switch [Numeric Datatypes]

            //// Example: Using switch with numeric data types
            //int day = 3;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    default:
            //        Console.WriteLine("Another day");
            //        break;
            //}


            #endregion

            #region 04 Conditional Statements - If, Switch [String Datatype]

            //// Example: Using switch with string data types
            //string fruit = "apple";
            //switch (fruit)
            //{
            //    case "apple":
            //        Console.WriteLine("Apple");
            //        break;
            //    case "banana":
            //        Console.WriteLine("Banana");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown fruit");
            //        break;
            //}


            #endregion

            #region 05 Switch with goto

            //// Example: Using switch with goto
            //int option = 2;
            //switch (option)
            //{
            //    case 1:
            //        Console.WriteLine("Option 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Option 2");
            //        goto case 1;
            //    default:
            //        Console.WriteLine("Default Option");
            //        break;
            //}


            #endregion

            #region 06 Switch [Numeric Datatypes (Comparison Operators)]

            //// Example: Using switch with comparison operators
            //int score = 85;
            //switch (score)
            //{
            //    case int n when (n >= 90):
            //        Console.WriteLine("Grade: A");
            //        break;
            //    case int n when (n >= 80):
            //        Console.WriteLine("Grade: B");
            //        break;
            //    case int n when (n >= 70):
            //        Console.WriteLine("Grade: C");
            //        break;
            //    default:
            //        Console.WriteLine("Grade: F");
            //        break;
            //}


            #endregion

            #region 07 Evolution of Switch in C# 7.0

            //// Example: Using switch with pattern matching in C# 7.0
            //object obj = 5;
            //switch (obj)
            //{
            //    case int i:
            //        Console.WriteLine($"It's an integer: {i}");
            //        break;
            //    case string s:
            //        Console.WriteLine($"It's a string: {s}");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown type");
            //        break;
            //}


            #endregion

            #region 08 Evolution of Switch in C# 8.0

            //// Example: Using switch expressions in C# 8.0
            //int month = 5;
            //string season = month switch
            //{
            //    12 or 1 or 2 => "Winter",
            //    3 or 4 or 5 => "Spring",
            //    6 or 7 or 8 => "Summer",
            //    9 or 10 or 11 => "Autumn",
            //    _ => "Unknown"
            //};
            //Console.WriteLine(season);


            #endregion

            #region 09 Loop Statements - For, Foreach

            //// Example: Using a for loop
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Iteration: {i}");
            //}

            //// Example: Using a foreach loop
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine($"Number: {number}");
            //}


            #endregion

            #region 10 Loop Statements - Do While, While

            //// Example: Using a while loop
            //int count = 0;
            //while (count < 5)
            //{
            //    Console.WriteLine($"Count: {count}");
            //    count++;
            //}

            //// Example: Using a do-while loop
            //int number = 0;
            //do
            //{
            //    Console.WriteLine($"Number: {number}");
            //    number++;
            //} while (number < 5);


            #endregion

            #region 11 String

            //// Example: Basic string operations
            //string greeting = "Hello, World!";
            //string upperGreeting = greeting.ToUpper();
            //string lowerGreeting = greeting.ToLower();
            //Console.WriteLine(upperGreeting);
            //Console.WriteLine(lowerGreeting);

            #endregion

            #region 12 StringBuilder

            //// Example: Using StringBuilder for efficient string manipulation
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello");
            //sb.Append(" ");
            //sb.Append("World");
            //sb.Append("!");
            //string result = sb.ToString();
            //Console.WriteLine(result);


            #endregion


        }
    }
}
