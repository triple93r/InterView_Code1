// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System;

namespace OasysTest
{
    public class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("////// REVERSE A NUMBER //////");
            Me();
            Console.WriteLine("////// REVERSE A STRING //////");
            Ke();
            Console.WriteLine("/// REVERSE STRING USING ARRAY.REVERSE()");
            Le();
            Console.ReadLine();
            Console.WriteLine("/// COUNTing LETTER TO BE SEARCHED using LINQ");
            CountLetter();
            Console.ReadLine();
            Console.WriteLine("/// ENTER THE LETTER TO BE SEARCHED");
            char b = Convert.ToChar(Console.ReadLine());
            int g = CountLetterusingForeach(b);
            Console.WriteLine("///Number of times it was founD = "+g);
            Console.ReadLine();
            Console.WriteLine("/// Counting Spaces in a sentence");
            CountSpace();
            Console.WriteLine("/// FINDING duplicate characters");
            Console.ReadLine();
            duplicatechar();
            Console.WriteLine("/// Adding Integers in a number");
            sumofintegers();
            Console.WriteLine("/// Thank you!");
        }

        static void Me()
        {
            Console.WriteLine("Enter a number to reverse");
            
            try
            {
                int Number = int.Parse(Console.ReadLine());
                int Reverse = 0;
                while (Number > 0)
                {
                    int remainder = Number % 10;
                    Reverse = (Reverse * 10) + remainder;
                    Number = Number / 10;
                }
                Console.WriteLine("Reversed number is {0}", Reverse);
                Console.ReadLine();
            }
            catch(System.FormatException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        static void Ke()
        {
            try
            {
                string str = "", reverse = "";
                int Length = 0;

                Console.WriteLine("Enter a Word");

                // Getting String (word) from Console
                str = Console.ReadLine();

                // Calculate length of string str
                Length = str.Length - 1;

                while (Length >= 0)
                {
                    reverse = reverse + str[Length];
                    Length--;
                }

                // Displaying the reverse word
                Console.WriteLine("Reverse word is {0}", reverse);
                Console.ReadLine();
            }
            catch(System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Le()
        {
            string originalString = "Hello, World!";

            // Convert the string to a char array and reverse it
            char[] charArray = originalString.ToCharArray();
            Array.Reverse(charArray);

            // Convert the reversed char array back to a string
            string reversedString = new string(charArray);

            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Reversed String: " + reversedString);
        }

        static void CountSpace()
        {
            string inputString = "This is a sample string with spaces";

            // Using LINQ to count spaces in the string
            int spaceCount = inputString.Count(char.IsWhiteSpace);

            Console.WriteLine("Original String: " + inputString);
            Console.WriteLine("Number of Spaces: " + spaceCount);
            Console.ReadKey();
        }

        static void CountLetter()
        {
            string inputSentence = "This is an example sentence with some 'a's.";

            // Using LINQ to count occurrences of 'a' in the string
            int countOfA = inputSentence.Count(c => c == 'a' || c == 'A');

            Console.WriteLine("Original Sentence: " + inputSentence);
            Console.WriteLine("Number of 'a's: " + countOfA);
        }

        static int CountLetterusingForeach(char find)
        {
            Console.WriteLine("Enter the string sentence");
            string text = Console.ReadLine();
                int count = 0;
                foreach (char ch in text)
                {
                    if (ch.Equals(find))
                    {
                        count++;
                    }
                }
                return count;
        }

        static void duplicatechar()
        {
            string inputSentence = "This is a sample sentence with some duplicate characters.";

            // Use a HashSet to keep track of unique characters
            HashSet<char> seenChars = new HashSet<char>();

            // Use a StringBuilder to build the result string
            System.Text.StringBuilder resultBuilder = new System.Text.StringBuilder();

            // Iterate through each character in the input sentence
            for (int i = 0; i < inputSentence.Length; i++)
            {
                char currentChar = inputSentence[i];

                // Check if the character has been seen before
                if (seenChars.Add(currentChar))
                {
                    // If not, add it to the result
                    resultBuilder.Append(currentChar);
                }
            }

            // Convert the StringBuilder to a string
            string result = resultBuilder.ToString();

            Console.WriteLine("Original Sentence: " + inputSentence);
            Console.WriteLine("After Removing Duplicates: " + result);
            Console.ReadLine();
        }

        static void sumofintegers()
        {
            Console.WriteLine("Enter the number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            string numberString = num.ToString();
            foreach (char digitChar in numberString)
            {
                // Convert the character to an integer and add it to the sum
                sum += Convert.ToInt32(digitChar.ToString());
            }

            Console.WriteLine("Original Number: " + num);
            Console.WriteLine("Sum of Digits: " + sum);
            Console.Read();
        }
    }
}




