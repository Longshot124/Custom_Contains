using System;

namespace Contains_method_by_me
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Bu bir custom contains methodudur";
            //Console.WriteLine(str.CustomContains("cuso"));

            Console.WriteLine("Enter sentence or word");
            string str = Console.ReadLine();
            
             Console.WriteLine("Enter looking part");
            string part = Console.ReadLine();

            
            
            Console.WriteLine(str.CustomContains(part));


           
        }

        
    }
}
