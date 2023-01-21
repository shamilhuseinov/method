//1
//using System;
//namespace test
//{
//    public class Program
//    {
//        static void Main()
//        {
//            FindNearestNumber(17);
//        }
//        static void FindNearestNumber(int n)
//        {
//            if (n==0)
//            {
//                Console.WriteLine(7); ;
//            }
//            else if (n%7==0)
//            {
//                Console.WriteLine(n); ;
//            }
//            else if ((n-1)%7==0 || (n-2)%7==0 || (n-3)%7==0)
//            {
//                for (int i = 3; i > 0; i--)
//                {
//                    if ((n - i) % 7 == 0)
//                    {
//                        Console.WriteLine(n-i); ;
//                    }
//                }
//            }
//            else
//            {
//                for (int i = 0; i < 7; i++)
//                {
//                    if ((n+i)%7==0)
//                    {
//                        Console.WriteLine(n+i); ;
//                    }
//                }
//            }

//        }
//    }
//}


//2
//using System;
//namespace test
//{
//    public class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine(FindSumOfNumbers(5)); 
//        }
//        static int FindSumOfNumbers(int n)
//        {
//            int sum = 0;
//            for (int i = 0; i <n; i++)
//            {
//                sum += i;
//            }
//            return sum;
//        }
//    }
//}

//3
using System;
namespace test
{
    public class Program
    {
        static void Main()
        {
            FindLongerOne("salam", "Azerbaycan");
        }
        static void FindLongerOne(string n1, string n2)
        {
            int count1 = 0;
            int count2 = 0;
            foreach (var n1Item in n1)
            {
                count1++;
            }
            foreach (var n2Item in n2)
            {
                count2++;
            }
            if (count1==count2)
            {
                Console.WriteLine("her ikisinin uzunluğu beraberdir");
            }
            else if (count1 > count2)
            {
                Console.WriteLine("birinci parametr daha uzundur");
            }
            else
            {
                Console.WriteLine("ikinci parametr daha uzundur");
            }
        }
    }
}