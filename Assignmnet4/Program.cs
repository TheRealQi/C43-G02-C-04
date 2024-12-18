namespace Assignmnet4;

class Program
{
    static void Main(string[] args)
    {
        #region Q1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
        
        Console.WriteLine("Q1 - Please enter a number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < number1; i++)
        {
            Console.Write($"{i}, ");
        }
        
        Console.WriteLine($"{number1}");
        
        #endregion
        
        #region Q2 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.
        
        Console.WriteLine("Q2 - Please enter a number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"{number2 * i} ");
        }
        
        #endregion
        
        #region Q3 - Write a program that allows to user to insert number then print all even numbers between 1 to this number
        
        Console.WriteLine("\nQ3 - Please enter a number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < number3; ++i)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }
        }
        
        #endregion
        
        #region Q4 - Write a program that takes two integers then prints the power.
        
        Console.WriteLine("\nQ4 - Please enter number the numbers seperated by a space: ");
        string[] input4 = Console.ReadLine().Split(' ');
        int number41 = Convert.ToInt32(input4[0]);
        int number42 = Convert.ToInt32(input4[1]);
        Console.WriteLine($"{Math.Pow(number41, number42)}");
        
        #endregion
        
        #region Q5 - Write a program to enter marks of five subjects and calculate total, average and percentage.
        
        Console.WriteLine("Q5 - Please enter the marks of the five subjects sperated by a space: ");
        string[] input5 = Console.ReadLine().Split(' ');
        int subject1Marks = Convert.ToInt32(input5[0]);
        int subject2Marks = Convert.ToInt32(input5[1]);
        int subject3Marks = Convert.ToInt32(input5[2]);
        int subject4Marks = Convert.ToInt32(input5[3]);
        int subject5Marks = Convert.ToInt32(input5[4]);
        double totalMarks = subject1Marks + subject2Marks + subject3Marks + subject4Marks + subject5Marks;
        double averageMarks = totalMarks / 5;
        double percentage = totalMarks / 500 * 100;
        Console.WriteLine($"Total Marks: {totalMarks}\n" +
                          $"Average Marks: {averageMarks}\n" +
                          $"Percentage: {percentage}");
        
        #endregion
        
        #region Q6 - Write a program to allow the user to enter a string and print the REVERSE of it.
        
        Console.WriteLine("Q6 - Please enter a string: ");
        string input6 = Console.ReadLine();
        for (int i = input6.Length - 1; i >= 0; i--)
        {
            Console.Write(input6[i]);
        }
        
        #endregion

        #region Q7 - Write a program to allow the user to enter int and print the REVERSED of it.
        
        Console.WriteLine("\nQ7 - Please enter a number: ");
        int number7 = Convert.ToInt32(Console.ReadLine());
        string reversedNumber = "";
        while (number7 > 0)
        {
            reversedNumber += number7 % 10;
            number7 /= 10;
        }
        
        Console.WriteLine(reversedNumber);
        
        #endregion
        
        #region Q8 - Write a program in C# Sharp to find prime numbers within a range of numbers.
        
        Console.WriteLine("\nQ8 - Please enter the range numbers starting seperated by a space: ");
        string[] input8 = Console.ReadLine().Split(' ');
        int number8Start = Convert.ToInt32(input8[0]);
        int number8End = Convert.ToInt32(input8[1]);
        for (int i = number8Start; i <= number8End; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        
            if (isPrime)
            {
                Console.Write($"{i} ");
            }
        }
        
        #endregion
        
        #region Q9 - Write a program in C# Sharp to convert a decimal number into binary without using an array.
        
        Console.WriteLine("\nQ9 - Please enter a number: ");
        int number9 = Convert.ToInt32(Console.ReadLine());
        string binaryNumber = Convert.ToString(number9, 2);
        Console.WriteLine(binaryNumber);
        
        #endregion

        #region Q10 - Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
        
        Console.WriteLine("\nQ10 - Please enter the first point seperated by a space (x,y): ");
        string[] input11 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(input11[0]);
        int y1 = Convert.ToInt32(input11[1]);
        Console.WriteLine("\nQ11 - Please enter the third point seperated by a space (x,y): ");
        string[] input12 = Console.ReadLine().Split(' ');
        int x2 = Convert.ToInt32(input12[0]);
        int y2 = Convert.ToInt32(input12[1]);
        Console.WriteLine("\nQ12 - Please enter the second point seperated by a space (x,y): ");
        string[] input13 = Console.ReadLine().Split(' ');
        int x3 = Convert.ToInt32(input13[0]);
        int y3 = Convert.ToInt32(input13[1]);
        
        if ((y1 - y2) * (x1 - x3) == (y1 - y3) * (x1 - x2))
        {
            Console.WriteLine("The points lie on a single straight line.");
        }
        else
        {
            Console.WriteLine("The points do not lie on a single straight line.");
        }
        
        #endregion

        #region Q11 - Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

        Console.WriteLine("\nQ11 - Please enter a number: ");
        int number11 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < number11; i++)
        {
            for (int j = 0; j < number11; j++)
            {
                if (i == j)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }

            Console.WriteLine();
        }

        #endregion

        #region Q12 - Write a program in C# Sharp to find the sum of all elements of the array.

        int[] array12 = { 1, 2, 3, 4, 5 };
        int sum = 0;
        for (int i = 0; i < array12.Length; i++)
        {
            sum += array12[i];
        }

        Console.WriteLine(sum);

        #endregion

        #region Q13 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

        int[] array131 = { 1, 3, 5, 7, 9 };
        int[] array132 = { 2, 4, 6, 8, 10 };
        int[] mergedArray = new int[array131.Length + array132.Length];

        for (int i = 0; i < array131.Length; i++)
        {
            mergedArray[i] = array131[i];
        }

        for (int i = 0; i < array132.Length; i++)
        {
            mergedArray[i + array131.Length] = array132[i];
        }

        Array.Sort(mergedArray);

        for (int i = 0; i < mergedArray.Length; i++)
        {
            Console.Write($"{mergedArray[i]} ");
        }

        #endregion

        #region Q14 - Write a program in C# Sharp to count the frequency of each element of an array.

        int[] array14 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
        for (int i = 0; i < array14.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < array14.Length; j++)
            {
                if (array14[i] == array14[j])
                {
                    count++;
                }
            }

            Console.WriteLine($"{array14[i]}: {count}");
        }

        #endregion

        #region Q15 - Write a program in C# Sharp to find maximum and minimum element in an array

        int[] array15 = { 90, 2, 3, 20, 4, 5, 6, 100, 8, 9, 10 };
        int max = Int32.MinValue;
        int min = Int32.MaxValue;
        for (int i = 0; i < array15.Length; i++)
        {
            if (array15[i] > max)
            {
                max = array15[i];
            }

            if (array15[i] < min)
            {
                min = array15[i];
            }
        }

        Console.WriteLine($"Max: {max}\nMin: {min}");

        #endregion

        #region Q16 - Write a program in C# Sharp to find the second largest element in an array.

        int[] array16 = { 90, 2, 3, 20, 4, 5, 6, 100, 8, 9, 10 };
        Array.Sort(array16);
        int secondLargest = array16[array16.Length - 2];
        Console.WriteLine(secondLargest);

        #endregion

        #region Q17 - Consider an Array of Integer values with size N, having values as in this Example 7 write a program find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).

        Console.WriteLine("\nQ17 - Please enter the size of the array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the elements of the array seperated by a space: ");
        string[] input17 = Console.ReadLine().Split(' ');
        int[] array17 = new int[n];
        for (int i = 0; i < n; i++)
        {
            array17[i] = Convert.ToInt32(input17[i]);
        }

        int maxDistance = 0;
        for (int i = 0; i < array17.Length; i++)
        {
            for (int j = i + 1; j < array17.Length; j++)
            {
                if (array17[i] == array17[j])
                {
                    if (j - i > maxDistance)
                    {
                        maxDistance = j - 1 - i;
                    }
                }
            }
        }

        Console.WriteLine(maxDistance);

        #endregion

        #region Q18 - Given a list of space separated words, reverse the order of the words.

        Console.WriteLine("\nQ18 - Please enter a list of space seperated words: ");
        string[] input18 = Console.ReadLine().Split(' ');
        Array.Reverse(input18);
        string reversedWords = string.Join(" ", input18);
        Console.WriteLine(reversedWords);

        #endregion

        #region Q19 - Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

        Console.WriteLine("\nQ19 - Please enter the size of the arrays and sub-arrays seperated by a space: ");
        string[] input19 = Console.ReadLine().Split(' ');
        int n19 = Convert.ToInt32(input19[0]);
        int m19 = Convert.ToInt32(input19[1]);

        int[,] array191 = new int[n19, m19];
        int[,] array192 = new int[n19, m19];

        for (int i = 0; i < n19; i++)
        {
            Console.WriteLine($"Please enter the elements of the {i + 1}th sub-array seperated by a space: ");
            string[] input191 = Console.ReadLine().Split(' ');
            for (int j = 0; j < m19; j++)
            {
                array191[i, j] = Convert.ToInt32(input191[j]);
            }
        }

        Array.Copy(array191, array192, n19*m19);
        
        for (int i = 0; i < n19; i++)
        {
            Console.Write("{ ");
            for (int j = 0; j < m19; j++)
            {
                Console.Write($"{array192[i, j]} ");
            }
            Console.WriteLine("}");
        }
        
        #endregion

        #region Q20 - Write a Program to Print One Dimensional Array in Reverse Order

        int[] array20 = { 1, 2, 3, 4, 5 };
        Array.Reverse(array20);
        for (int i = 0; i < array20.Length; i++)
        {
            Console.Write($"{array20[i]} ");
        }

        #endregion
    }
}