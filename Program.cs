using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int First_Num = 4;
            double First_Value = 4.0;
            string First_Name = "Poly Ilaro";

            Console.WriteLine("enter your Second NUmber");
            int Second_Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Your Second Double");
            double Second_Value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Comment");
            String Comment = Console.ReadLine();

            Console.WriteLine(First_Num + Second_Num);
            Console.WriteLine(First_Value + Second_Value);
            Console.WriteLine(First_Name + " " + Comment);
            Console.ReadLine();
        }
    }
}
