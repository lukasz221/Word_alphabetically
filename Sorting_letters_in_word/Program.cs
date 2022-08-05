using System;

namespace Sorting_letters_in_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "ZYXCBA";
            Console.WriteLine("Word is: " +word);
            
            int[] myIntArray = new int[word.Length];

            int[] array1 = StringToChar(word);

            Console.WriteLine();
            Array.Sort(array1);

            WordInAlphabetically(word, array1);
        }

        private static int LetterToNumber(char letter)
        {
            int index = char.ToUpper(letter) - 64;
            return index;
        }

        private static int[] StringToChar(string myString)
        {
            int[] myIntArray = new int[myString.Length];
            for (int i = 0; i < myString.Length; i++)
            {
                char[] myCharArray = myString.ToCharArray();
                var n = LetterToNumber((char)myCharArray[i]);
                
                myIntArray[i] = n;

            }
            return myIntArray;
        }

        static string InToChar(int index)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            index -= 1;
            var value = "";

            if (index >= letters.Length)
                value += letters[index / letters.Length - 1];

            value += letters[index % letters.Length];

            return value;
        }

        static void WordInAlphabetically(string word, int[] array1)
        {
            Console.Write("Word alphabetically is: ");
            for (int i = 0; i < word.Length; i++)
            {
                string g;
                g = InToChar(array1[i]);
                Console.Write(g);
            }
        }

    }
}
