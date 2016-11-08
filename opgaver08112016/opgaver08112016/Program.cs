using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgaver08112016
{
    class Program
    {
        static void Main(string[] args)
        {

            //opgave11();
            //opgave12();
            //opgave13();
            //opgave14();
            //opgave15();
            opgave16();
        }

        public static void opgave11()
        {
            Console.WriteLine("Hello\nAllan");
        }

        public static void opgave12()
        {
            int x = 12, y = 13;
            int sum = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, sum);
        }

        public static void opgave13()
        {
            float x = 24, y = 5, result = x / y;
            Console.WriteLine("{0}/{1} = {2}", x, y, result);
        }
        
        public static void opgave14()
        {
            Console.WriteLine("Result: {0}", -1+3*5f);
            Console.WriteLine("Result: {0}", (24+5)%7f);
            Console.WriteLine("Result: {0}", 15f+((-4f*6f)/11f));
            Console.WriteLine("Result: {0}", 2+10/6*1-7%2f);
        }

        public static void opgave15()
        {
            Console.WriteLine("Indtast første heltal");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet heltal");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Summen er: {0}", x+y);
        }

        public static void opgave16()
        {
            Console.WriteLine("***Allan Storgaard***");
            Console.WriteLine("Indtast første heltal");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet heltal");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast tredie heltal");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Summen er: {0}", x * y * z);
        }

        public static void opgave17()
        {

        }




    }
}
