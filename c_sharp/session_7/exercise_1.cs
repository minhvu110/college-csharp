using System;


namespace Workspace
{
    class Program
    {
        // 1.to calculate the average value of array elements.
        static double Avg_Cal(int[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return (double)sum / array.Length;
        }
        // 2.to test if an array contains a specific value.
        static bool Containted(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (n == array[i]) return true;
            }
            return false;
        }
        static int Find_Index(int[] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (n == array[i]) return i;
            }
            return -1;
        }
        static int[] Remove_an_element(int[] array, int n)
        {
            int index = Find_Index(array, n);
            if (index == -1)
            {
                return array;
            }
            int[] resault = new int[array.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index) continue;
                resault[j] = array[i];
                j++;
            }
            return resault;
        }
        static int Find_Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
            }
            return min;
        }
        static int Find_Max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
            }
            return max;
        }
        static int[] Reverse_the_array(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp = array[array.Length - 1 - i];
                array[array.Length - i - 1] = array[i];
                array[i] = temp;
            }
            return array;
        }
        static int[] Find_The_Duplicate(int[] array)
        {
            int count = 0;
            int[] temp = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        bool is_in = false;
                        for (int k = 0; k < count; k++)
                        {
                            if (temp[k] == array[i])
                            {
                                is_in = true; break;
                            }
                        }
                        if (is_in == false)
                        {
                            temp[count] = array[i];
                            count++;
                        }
                        break;
                    }
                }
            }
            int[] resault = new int[count];
            for (int i = 0; i < count; i++)
            {
                resault[i] = temp[i];
            }
            return resault;
        }
        static int[] Remove_The_Duplicates(int[] array)
        {
            int[] duplicates = Find_The_Duplicate(array);
            for (int i = 0; i < duplicates.Length; i++)
           {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if(duplicates[i]==array[j])
                    {
                        count++;
                    }
                }
                while(count>1)
                {
                    array = Remove_an_element(array,duplicates[i]);
                    count--;
                }
            }

            return array;
        }
        static void Main1(string[] args)
        {
            int[] arr = new int[Random.Shared.Next(5, 20)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Shared.Next(5, 15);
            }
            System.Console.WriteLine(Avg_Cal(arr));

            System.Console.Write("enter your number: ");
            int number_to_check = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Contain {number_to_check}? {Containted(arr, number_to_check)}");


            int target = Find_Index(arr, number_to_check);
            if (target != -1)
            {
                System.Console.WriteLine($"index of {number_to_check} is {target}");
            }
            else
            {
                System.Console.WriteLine("not in the array");
            }
            System.Console.WriteLine("before");
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write($"{arr[i]} ");
            }
            System.Console.WriteLine();
            arr = Remove_an_element(arr, number_to_check);
            System.Console.WriteLine("after");
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write($"{arr[i]} ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Min = {Find_Min(arr)}");
            System.Console.WriteLine($"Max = {Find_Max(arr)}");

            arr = Reverse_the_array(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write($"{arr[i]} ");
            }
            System.Console.WriteLine();
            int[] duplicates = Find_The_Duplicate(arr);
            for (int i = 0; i < duplicates.Length; i++)
            {
                System.Console.Write($"{duplicates[i]} ");
            }
            System.Console.WriteLine();
            arr = Remove_The_Duplicates(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write($"{arr[i]} ");
            }
            System.Console.WriteLine();

        }
    }
}
