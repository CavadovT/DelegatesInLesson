using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesInLesson
{
    internal class Program
    {
        //delegate bool Check(int num);
        //delegate void Write(string str1);
        //delegate int Result(int num1, int num2);
        //delegate void Read(bool b1);
        //delegate P Read1< in T,in U, out P>(T r1,U r2);// generic yazi
        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(new int[] { 2,5,6,8,9},CheckIsOdd));
            //Console.WriteLine(Sum(new int[] { 2, 5, 6, 8, 9 },CheckIsEven));
            //Console.WriteLine(Sum(new int[] { 2, 5, 6, 8, 9 },CheckIsBigTwo));
            ////StringBuilder stringBuilder= new StringBuilder();
            ////StringBuilder stringBuilder1 = stringBuilder;
            //Write write = Test;
            //write += TestLength;
            //write += TestUpper;

            //write += delegate (string m)            //Anonim methods
            //  {
            //      Console.WriteLine(m.ToLower());
            //  };
            //write -= delegate (string m)    // tekce bu yazilsa hec bir deyisiklik olmur 
            //                                  // cunki cixmaga birsey tapmir
            //{
            //    Console.WriteLine(m.ToLower());
            //};
            //write.Invoke("LOrem");
            //write("LOrem");
            //write += (string n) =>              // bir setir yazsaq skobkalara ehtiyac yoxdu
            // {
            //     Console.WriteLine(n[0]);           //() bos buraxsaq yaza bilerik

            // };

            //Result result = delegate (int n, int m) // bu obyektden konkret method yaridib deye bir netice verir
            //  {
            //      return n + m;

            //  };
            //result = delegate (int p, int k)
            //  {
            //      return p + k;
            //  };
            //result += (n, m) =>
            //  {
            //      Console.WriteLine("result");
            //      return n - m;

            //  };
            //Console.WriteLine(result(10,9));


            Action<string> action = (n) => { Console.WriteLine("reulst"); };//16 type qebul edib geriye void qaytarir
            Predicate<string> predicate = (n) => { Console.WriteLine(n); return true; }; //bir type qebul edir geriye bool qaytaran type
            Func<string, int> func = (n) => { return n.Length; };//17 type qebul edir sonuncusu return typesi olur
            
            
            List<int>list1=new List<int>();  
            list1.Add(1);
            list1.Add(5);
            list1.Add(6);
            list1.Add(15);

            Console.WriteLine(list1.Find(n => n > 2));

           List<int>list2= list1.FindAll(n=>n > 2);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

        }
        
        //static void Test(string word1)
        //{

        //    Console.WriteLine(word1);
        //}

        //static void TestUpper(string word1)
        //{

        //    Console.WriteLine(word1.ToUpper());
        //}
        //static void TestLength(string word1)
        //{

        //    Console.WriteLine(word1.Length);
        //}

       
        //static bool CheckIsOdd(int num)
        //{
        //return (num % 2 == 1);
        //}
        //static bool CheckIsEven(int num) 
        //{
        //return (num % 2 == 0);
        //}
        //static bool CheckIsBigTwo(int num) 
        //{
        //return num>2;
        //}
        //static int Sum(int[] arr,Check func) 
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (func(item)) 
        //        {
        //            result = result + item;

        //        }

        //    }
        //    return result;
        //}

        //static int IsEven(int[] arr)
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (CheckIsEven(item))
        //        {
        //            result = result + item;

        //        }

        //    }
        //    return result;
        //}

        //static int ISbigTwo(int[] arr)
        //{
        //    int result = 0;
        //    foreach (var item in arr)
        //    {
        //        if (CheckIsBigTwo(item))
        //        {
        //            result = result + item;

        //        }

        //    }
        //    return result;
        //}
    }

}
