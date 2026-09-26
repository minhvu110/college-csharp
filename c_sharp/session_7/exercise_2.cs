using System;


namespace Workspace
{
    class AlgorithmsDemo
    {
        static void Main2(string[] args)
        {
            int[] arr = new int[10];
            System.Console.Write("Enter 10 elements: ");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            arr = Bubble_Sort(arr);
            for (int i = 0; i < 10; i++)
            {
                System.Console.Write($"{arr[i]} ");
            }
            System.Console.WriteLine();
            System.Console.Write("Enter your line: ");
            string line = Console.ReadLine();
            System.Console.Write("Enter your word: ");
            string word_to_check = Console.ReadLine();
            string[] array = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if(LinearSearch(array,word_to_check))
            {
                System.Console.WriteLine($"the word {word_to_check} does appear in the sentence");
            }
            else
            {
                System.Console.WriteLine($"the word {word_to_check} does not appear in the sentence");
            }
        }
        static int[] Bubble_Sort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    if(array[j]>array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
        static bool LinearSearch(string[] array, string sentence)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].ToLower();
                sentence = sentence.ToLower();
                if(array[i]==sentence) return true;
            }
            return false;
        }
    }
}
