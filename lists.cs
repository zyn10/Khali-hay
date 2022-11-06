using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp3
{

    class Program
    {


       static  void Main()
        {


            List<int> numberlist = new List<int>();

            //Console.WriteLine(firstlist.Count);

            numberlist.Add(1);
            numberlist.Add(2);
            numberlist.Add(3);
            numberlist.Add(4);
            numberlist.Add(5);


            //numberlist.Clear();

            Console.WriteLine(numberlist.Count);

            foreach (var number in numberlist)
            {
                Console.WriteLine(number);
            }

            //Console.WriteLine("Hello");



        }


    }



}
