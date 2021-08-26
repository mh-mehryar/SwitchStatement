using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber;
            string name;

            Console.Write("Enter a number as your Birht Month  :");     
            myNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your First Name : ");
            name = Console.ReadLine();

            switch (myNumber)
            {
                case 1:
                    Console.WriteLine("{0} Your Birth Month is : Farvardin",(name));
                    break;
                case 2:
                    Console.WriteLine("{0} Your Birth Month is : Ordibehesht", (name));
                    break;
                case 3:
                    Console.WriteLine("{0} Your Birth Month is : Khordad", (name));
                    break;
                case 4:
                    Console.WriteLine("{0} Your Birth Month is : Tir", (name));
                    break;
                case 5:
                    Console.WriteLine("{0} Your Birth Month is : Mordad", (name));
                    break;
                case 6:
                    Console.WriteLine("{0} Your Birth Month is : Shahrivar", (name));
                    break;
                case 7:
                    Console.WriteLine("{0} Your Birth Month is : Mehr", (name));
                    break;
                case 8:
                    Console.WriteLine("{0} Your Birth Month is : Aban", (name));
                    break;
                case 9:
                    Console.WriteLine("{0} Your Birth Month is : Azar", (name));
                    break;
                case 10:
                    Console.WriteLine("{0} Your Birth Month is : Day", (name));
                    break;
                case 11:
                    Console.WriteLine("{0} Your Birth Month is : Bahman", (name));
                    break;
                case 12:
                    Console.WriteLine("{0} Your Birth Month is : Esfand", (name));
                    break;
                    
                default:
                    Console.WriteLine("Not In Range");
                    break;
            }
        }
    }
}
