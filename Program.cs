using System;

namespace ArRaY
{
    class Program
    {
        static void Main(string[] args)
        {
            //    System.Console.WriteLine("How many number you wish to enter: ");
            //    int number = int.Parse(Console.ReadLine());
            //    int[] num = new int[number];
            //    int a = 0;  
            //    for (int i = 0; i < num.Length; i++)
            //    {
            //         System.Console.WriteLine("Enter the numbers: ");
            //         num[i] = int.Parse(Console.ReadLine());
            //         a= num[i] *5;
            //    }
            //    System.Console.WriteLine(a);

            // int[] num = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            // int[] num1 = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            // for (int i = 0; i < num.Length; i++)
            // {
            //     if (num[i] == num1[i])
            //     {
            //         System.Console.WriteLine($"The numbers at the both arrays are equal");
            //     }
            //     else System.Console.WriteLine("They are not the same");
            // }

            //     int a = 1;
            //     int b = 1;
            //     int c = 0;
            //     System.Console.WriteLine("Enter the length of the array: ");
            //     int sum = int.Parse(System.Console.ReadLine());
            //     int[] num = new int[sum];

            //    for (int i = 0; i < num.Length-1; i++)
            //    {
            //         System.Console.WriteLine("Enter the number at index of {0}: ", i);
            //         num[i] = int.Parse(System.Console.ReadLine());
            //    }
            //    for (int i = 0; i < num.Length-1; i++)
            //    {
            //         if (num[i] == num[i+1]) b++;
            //         else b = 1;
            //         if (b > a)
            //         {
            //             a = b;
            //             c = num[i];
            //         }
            //    }
            //    for (int i = 0; i < a; i++)
            //    {
            //         System.Console.WriteLine("{0}",c);
            //    }

            // int a = 1, b = 1, c = 0, d = 0;
            // Console.WriteLine("Enter the length of the array: ");
            // int sum = int.Parse(Console.ReadLine());
            // int[] num = new int[sum];

            // for (int i = 0; i < num.Length; i++)
            // {
            //     System.Console.WriteLine("Enter the numbers: ");
            //     num[i] = int.Parse(Console.ReadLine());
            // }
            // for (int i = 0; i < num.Length - 1; i++)
            // {
            //     if (num[i] + 1 == num[i + 1])
            //     {
            //         a++;
            //         if (a > b)
            //         {
            //             b = a;
            //             d = i + 1;
            //             c = d - b + 1;
            //         }
            //         else a = 1;
            //     }
            // }
            // for (int i = c; i < b + c; i++)
            // {
            //     Console.Write("{0}, ", num[i]);
            // }

            // int a = 1, b = 1, c = 0, d = 0;
            // System.Console.WriteLine("Enter the length of the array: ");
            // int h = int.Parse(Console.ReadLine());
            // int[] num = new int[h];
            // for (int i = 0; i < num.Length; i++)
            // {
            //     System.Console.WriteLine("Enter the elements of the array: ");
            //     num[i] = int.Parse(Console.ReadLine());
            // }
            // for (int i = 0; i < num.Length - 1; i++)
            // {
            //     if (num[i] % 2 == 0)
            //     {
            //         a++;
            //         if (a > b)
            //         {
            //             b = a;
            //             d = i + 1;
            //             c = d - b + 1;
            //         }
            //         else a = 1;
            //     }
            // }
            // for (int i = c; i < b + c; i++)
            // {
            //     Console.Write("{0}, ", num[i]);
            // }


            // Console.WriteLine("Enter the length of the array: ");
            // int h = int.Parse(Console.ReadLine());
            // int[] num = new int[h];
            // // int[] num1 = new int[h];

            // for (int i = 0; i < num.Length; i++)
            // {
            //     System.Console.WriteLine("Enter the elements: ");
            //     num[i] = int.Parse(Console.ReadLine());
            //     for (int j = 0; j < num.Length-1; j++)
            //     {
            //         System.Console.WriteLine("Enter the elements: ");
            //         num[j] = int.Parse(Console.ReadLine());
            //     }
            // }


            // int sum = 0;

            // Console.Write("Enter your number: ");
            // int n = Int32.Parse(Console.ReadLine());
            // Console.Write("Enter your number: ");
            // int k = Int32.Parse(Console.ReadLine());

            // int[] arr = new int[n];

            // for (int i = 0; i < n; i++)
            // {
            //     Console.Write("Enter {0} element: ", i);
            //     arr[i] = Int32.Parse(Console.ReadLine());
            // }

            // Array.Sort(arr);

            // for (int i = 0; i < k; i++)
            // {
            //     sum += arr[i];
            // }
            // Console.WriteLine("\nBiggest sum is {0}", sum);



            // System.Console.WriteLine("Enter the length of the array");
            // int h = int.Parse(Console.ReadLine());
            // int[] num = new int[h];
            // for (int i = 0; i < num.Length; i++)
            // {
            //     System.Console.WriteLine("Enter the elements of the array");
            //     num[i]= int.Parse(Console.ReadLine());

            // }
            // for (int i = 0; i < num.Length-1; i++)
            // {
            //     Array.Sort(num);
            // }
            // foreach (var item in num)
            // {
            //     System.Console.WriteLine(item);
            // }

            // int a = 0, b = 0;

            // Console.Write("Enter array length: ");
            // int length = Int32.Parse(Console.ReadLine());

            // int[] arr = new int[length];

            // for (int i = 0; i < length; i++)
            // {
            //     Console.Write("Enter {0} element: ", i);
            //     arr[i] = Int32.Parse(Console.ReadLine());
            // }

            // for (int i = 0; i < length - 1; i++)
            // {
            //     b = arr[i];

            //     for (int j = i + 1; j < length; j++)
            //     {
            //         b += arr[j];
            //         if (b > a)
            //         {
            //             a = b;
            //         }
            //     }
            // }

            // Console.WriteLine("Result is {0}. ", a);


            // int a = 0, b = 1, c = 0;

            // Console.Write("Enter array length: ");
            // int m = Int32.Parse(Console.ReadLine());

            // int[] num = new int[m];

            // for (int i = 0; i < num.Length; i++)
            // {
            //     Console.Write("Enter {0} element: ", i);
            //     num[i] = Int32.Parse(Console.ReadLine());
            // }

            // Array.Sort(num);

            // for (int i = 0; i < num.Length - 1; i++)
            // {
            //     if (num[i] == num[i + 1]) b++;
            //     else b = 1;
            //     if (b > a)
            //     {
            //         a = b;
            //         c = arr[i];
            //     }
            // }

            // Console.WriteLine("{0} was found {1} times.", c, a);
        }

    }
}