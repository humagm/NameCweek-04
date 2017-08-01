using System;

namespace C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter firstname");
            var Fname = Console.ReadLine();
            Console.WriteLine(Fname);
            Console.WriteLine("Enter lastname");
            var Lname = Console.ReadLine();
            Console.WriteLine(Lname);

            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        
        }
    }
}
