namespace Session5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Question 1
            // 1. Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            /*
             * Passing by Value
                 When a parameter is passed by value, a copy of the actual value is made and passed to the method.
                 Changes made to the parameter inside the method do not affect the original variable.


             * Passing by Reference
                 When a parameter is passed by reference, the method receives a reference to the original variable.
                 Changes made to the parameter inside the method directly affect the original variable.
             */
            //int value = 10;

            //Console.WriteLine("Before PassByValue: " + value);
            //PassByValue(value);
            //Console.WriteLine("After PassByValue: " + value);

            //Console.WriteLine();

            //Console.WriteLine("Before PassByReference: " + value);
            //PassByReference(ref value);
            //Console.WriteLine("After PassByReference: " + value);
            #endregion

            #region Question  2
            //Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            /**
             * 


             Passing Reference Type by Value
                 When a reference type is passed by value, a copy of the reference (not the object itself) is made and passed to the method.
                 The method can modify the object's contents because the reference points to the same object.
                 However, if the method reassigns the reference to a new object, it does not affect the original reference outside the method.
             *
             *
             *
             *
             *Passing Reference Type by Reference
                When a reference type is passed by reference, the method operates directly on the original reference.
                Changes to the object’s contents and reassigning the reference itself affect the original reference outside the method.
             */
            //MyClass obj = new MyClass { Value = 10 };

            //Console.WriteLine("Before PassByValue: " + obj.Value);
            //PassByValue(obj);
            //Console.WriteLine("After PassByValue: " + obj.Value);

            //Console.WriteLine();

            //Console.WriteLine("Before PassByReference: " + obj.Value);
            //PassByReference(ref obj);
            //Console.WriteLine("After PassByReference: " + obj.Value);
            #endregion


            #region Question 3

            //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            // Prompt user for input
            //Console.WriteLine("Enter the first number for summation:");
            //int sumNum1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number for summation:");
            //int sumNum2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the first number for subtraction:");
            //int subNum1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number for subtraction:");
            //int subNum2 = int.Parse(Console.ReadLine());

            //// Call the function and get results
            //var (sumResult, subResult) = Calculate(sumNum1, sumNum2, subNum1, subNum2);

            //// Display the results
            //Console.WriteLine($"The sum of {sumNum1} and {sumNum2} is: {sumResult}");
            //Console.WriteLine($"The subtraction of {subNum1} and {subNum2} is: {subResult}");

            #endregion


            #region Question 4

            // Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            // Prompt the user to enter a number
            //Console.WriteLine("Enter a number:");
            //int number = int.Parse(Console.ReadLine());

            //// Call the function and display the result
            //int sum = CalculateDigitSum(number);
            //Console.WriteLine($"The sum of the digits of {number} is: {sum}");

            #endregion

            #region Question 5

            // Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            // Prompt the user to enter a number
            //Console.WriteLine("Enter a number to check if it is prime:");
            //int number = int.Parse(Console.ReadLine());

            //// Call the IsPrime function and display the result
            //bool isPrime = IsPrime(number);
            //if (isPrime)
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}

            #endregion

            #region Question 6

            // Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //// Example array
            //int[] numbers = { 12, 7, 22, 3, 15, 9 };

            //// Variables to store the results
            //int min = 0;
            //int max = 0;

            //// Call the MinMaxArray function
            //MinMaxArray(numbers, ref min, ref max);

            //// Display the results
            //Console.WriteLine($"Minimum value: {min}");
            //Console.WriteLine($"Maximum value: {max}");

            #endregion


            #region Question 7
            // Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //// Prompt the user for input
            //Console.WriteLine("Enter a number to calculate its factorial:");
            //int number = int.Parse(Console.ReadLine());

            //// Call the iterative factorial function and display the result
            //long factorial = CalculateFactorial(number);
            //Console.WriteLine($"The factorial of {number} is: {factorial}");

            #endregion

            #region Question 8
            ////Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //// Example input
            //Console.WriteLine("Enter the original string:");
            //string inputString = Console.ReadLine();

            //Console.WriteLine("Enter the position to modify (0-based index):");
            //int position = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the new character:");
            //char newChar = Console.ReadLine()[0];

            //// Call the ChangeChar function
            //string modifiedString = ChangeChar(inputString, position, newChar);

            //// Display the modified string
            //Console.WriteLine($"Modified string: {modifiedString}");
            #endregion 
        }

        // Passing by value
        static void PassByValue(int number)
        {
            number += 10;
            Console.WriteLine("Inside PassByValue: " + number);
        }

        // Passing by reference
        static void PassByReference(ref int number)
        {
            number += 10;
            Console.WriteLine("Inside PassByReference: " + number);
        }


        // Passing reference type by value
        static void PassByValue(MyClass obj)
        {
            obj.Value += 10; // This changes the object's contents
            Console.WriteLine("Inside PassByValue (After Modification): " + obj.Value);

            obj = new MyClass { Value = 50 }; // This does not affect the original reference
            Console.WriteLine("Inside PassByValue (After Reassignment): " + obj.Value);
        }

        // Passing reference type by reference
        static void PassByReference(ref MyClass obj)
        {
            obj.Value += 10; // This changes the object's contents
            Console.WriteLine("Inside PassByReference (After Modification): " + obj.Value);

            obj = new MyClass { Value = 50 }; // This reassigns the original reference
            Console.WriteLine("Inside PassByReference (After Reassignment): " + obj.Value);
        }

        static (int sum, int difference) Calculate(int num1, int num2, int num3, int num4)
        {
            int sum = num1 + num2;
            int difference = num3 - num4;
            return (sum, difference);
        }

        // Function to calculate the sum of the individual digits of a number
        static int CalculateDigitSum(int num)
        {
            int sum = 0;

            // Ensure the number is positive
            num = Math.Abs(num);

            while (num > 0)
            {
                sum += num % 10; // Add the last digit to the sum
                num /= 10;       // Remove the last digit
            }

            return sum;
        }


        // Function to check if a number is prime
        static bool IsPrime(int num)
        {
            // Numbers less than 2 are not prime
            if (num < 2)
            {
                return false;
            }

            // Check for divisors from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; // If divisible, it's not prime
                }
            }

            return true; // If no divisors found, it's prime
        }


        // Function to find the minimum and maximum values in an array
        static void MinMaxArray(int[] array, ref int min, ref int max)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty.");
            }

            // Initialize min and max with the first element
            min = array[0];
            max = array[0];

            // Loop through the array to find min and max
            foreach (int number in array)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
        }

        // Iterative function to calculate factorial
        static long CalculateFactorial(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            long result = 1; // Initialize result to 1

            for (int i = 1; i <= num; i++)
            {
                result *= i; // Multiply result by the current number
            }

            return result;
        }

        // Function to modify a character in a string at a specific position
        static string ChangeChar(string str, int position, char newChar)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("String must not be null or empty.");
            }

            if (position < 0 || position >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of the string's bounds.");
            }

            // Convert the string to a character array for modification
            char[] charArray = str.ToCharArray();

            // Replace the character at the specified position
            charArray[position] = newChar;

            // Return the modified string
            return new string(charArray);
        }
    }
}
