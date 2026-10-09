using System;


namespace Workspace
{
    class Program
    {
        static string NhapXuatString(string str)
        {
            return str;

        }
        static int CharLength(string str)
        {
            int Length = 0;
            foreach (char c in str)
            {
                Length++;
            }
            return Length;
        }
        static string SeparateString(string str)
        {
            string output = "";
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    continue;
                }
                output += c + " ";
            }
            return output;
        }
        static string SeparateStringInReverseOrder(string str)
        {
            string output = "";
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    continue;
                }
                output = c + " " + output;
            }
            return output;
        }
        static int WordCounter(string str)
        {
            int count = 0;
            bool isWord = false;
            str = str.Trim();
            foreach (char c in str)
            {

                if (c == ' ')
                {
                    isWord = false;
                }
                else if (isWord == false)
                {
                    count++;
                    isWord = true;
                }
            }
            return count;
        }
        static int StringComparer(string a, string b)
        {
            int minLength = Math.Min(a.Length, b.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (a[i] != b[i])
                {
                    return a[i] - b[i];
                }
            }
            if (a.Length == b.Length)
            {
                return 0;
            }
            else if (a.Length > b.Length)
            {
                return 1;
            }
            else return -1;
        }
        static void ComponentsCounter(string a, out int alphabets, out int digits, out int specialChars)
        {

            alphabets = 0;
            digits = 0;
            specialChars = 0;
            foreach (char c in a)
            {
                if (char.IsLetter(c))
                {
                    alphabets++;
                }
                else if (char.IsNumber(c))
                {
                    digits++;
                }
                else
                {
                    specialChars++;
                }
            }
        }
        static bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
        static void VowelsAndConsonats(string input, out int vowels, out int consonants)
        {

            vowels = 0;
            consonants = 0;
            input = input.ToLower();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (IsVowel(c))
                    {
                        vowels++;
                    }
                    else consonants++;

                }
            }
        }
        static int position(string input, string substring)
        {
            return input.IndexOf(substring);
        }
        static bool isContained(string input, string lookup)
        {
            return input.Contains(lookup);
        }
        static int isAlphabets(char input)
        {
            if (char.IsLetter(input))
            {
                if (char.IsUpper(input))
                {
                    return 1;
                }
                else return 0;
            }
            return -1;
        }
        static int SubStringCounter(string input, string target)
        {
            int count = 0;
            int start = input.IndexOf(target);
            while (start != -1)
            {
                count++;
                start = input.IndexOf(target, start + target.Length);
            }
            return count;
        }
        static string InsertBeforeFirst(string input, string target, string newText)
        {
            int index = input.IndexOf(target);
            if (index > -1)
            {
                return input.Insert(index, newText);
            }
            return input;
        }
        static void Main(string[] args)
        {
            //-to input a string and print it.
            System.Console.Write("enter your string: ");
            string str = Console.ReadLine();
            System.Console.WriteLine($"your output string: {NhapXuatString(str)}");
            //-to find the length of a string without using a library function.
            System.Console.WriteLine($"your string length: {CharLength(str)}");
            //-to separate individual characters from a string.
            System.Console.WriteLine(SeparateString(str));
            //-to print individual characters of the string in reverse order.
            System.Console.WriteLine(SeparateStringInReverseOrder(str));
            //-to count the total number of words in a string.
            System.Console.WriteLine($"Total words are: {WordCounter(str)}");
            //-to compare two strings without using a string library functions.
            System.Console.Write("enter string 1:");
            string string1 = Console.ReadLine();
            System.Console.Write("enter string 2:");
            string string2 = Console.ReadLine();
            int resault = StringComparer(string1, string2);
            if (resault == 0)
            {
                System.Console.WriteLine("both strings are equal");
            }
            else System.Console.WriteLine("both strings arent equal");
            //-to count the number of alphabets, digits, and special characters in a string.
            System.Console.Write("enter your string: ");
            string stringcount = Console.ReadLine();
            int letters = 0;
            int digits = 0;
            int specials = 0;
            ComponentsCounter(stringcount, out letters, out digits, out specials);
            Console.WriteLine($"Alphabets: {letters}");
            Console.WriteLine($"Digits: {digits}");
            Console.WriteLine($"Special Characters: {specials}");
            //-to count the number of vowels or consonants in a string.
            int vowels;
            int consonants;
            System.Console.Write("enter your string: ");
            string vowels_consonats = Console.ReadLine();
            VowelsAndConsonats(vowels_consonats, out vowels, out consonants);
            System.Console.WriteLine($"consonants = {consonants}");
            System.Console.WriteLine($"vowels = {vowels}");
            // -to check whether a given substring is present in the given string.
            System.Console.Write("enter your string: ");
            string mainstring = Console.ReadLine();
            System.Console.Write("enter your sub-string: ");
            string substring = Console.ReadLine();
            System.Console.WriteLine(isContained(mainstring, substring));
            //to search for the position of a substring within a string.
            if (position(mainstring, substring) >= 0)
                System.Console.WriteLine($"the positon is: {position(mainstring, substring)}");
            else System.Console.WriteLine($"isnt there");
            //to check whether a character is an alphabet and not and if so, check for the case.
            System.Console.Write("enter the char: ");
            char c = (char)Console.Read();
            if (isAlphabets(c) == 1)
            {
                System.Console.WriteLine($"{c} is an alphabet and upper");
            }
            else if (isAlphabets(c) == 0)
            {
                System.Console.WriteLine($"{c} is an alphabet and lower");
            }
            else System.Console.WriteLine("non of the above");
            //-to find the number of times a substring appears in a given string.
            System.Console.Write("enter your string: ");
            string mainstring1 = Console.ReadLine();
            System.Console.Write("enter your sub-string: ");
            string substring1 = Console.ReadLine();
            System.Console.WriteLine($"the number of times that {substring1} appears: {SubStringCounter(mainstring1, substring1)}");
            //-to insert a substring before the first occurrence of a string.
            System.Console.Write("enter your string: ");
            string source = Console.ReadLine();
            System.Console.Write("enter your target to insert: ");
            string target = Console.ReadLine();
            System.Console.Write("enter your string to insert: ");
            string text = Console.ReadLine();
            System.Console.WriteLine($"new text: {InsertBeforeFirst(source, target, text)}");
            Console.ReadKey();
        }
    }
}
