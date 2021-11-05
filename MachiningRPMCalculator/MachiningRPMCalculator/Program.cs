using System;


namespace SpeedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RPM Calculator 2022");
            while (true)
            {
                string steel = "2";
                string aluminum = "1";
                Console.WriteLine();
                Console.WriteLine("Enter material to cut. (aluminum = 1, steel = 2)");
                string material = Console.ReadLine();

                if (material == steel)
                {
                    Console.WriteLine("Enter tool diameter. (in)");
                    string dia = Console.ReadLine();
                    Console.WriteLine();
                    double diameter = Convert.ToDouble(dia);
                    double steelcspeed = 800;
                    double steelsspeed = 400;
                    string carbide = "yes";
                    Console.WriteLine("Is the tool carbide?");
                    string iscarbide = Console.ReadLine();
                    if (iscarbide == carbide)
                    {
                        Console.WriteLine("Your speed is " + steelcspeed / diameter);
                    }
                    else
                    {
                        Console.WriteLine("Your speed is " + steelsspeed / diameter);
                    }
                }

                else if (material == aluminum)
                {
                    Console.WriteLine("Enter tool diameter. (in)");
                    string dia = Console.ReadLine();
                    Console.WriteLine();
                    double diameter = Convert.ToDouble(dia);
                    double alcspeed = 3200;
                    double alsspeed = 1600;
                    string carbide = "yes";
                    Console.WriteLine("Is the tool carbide?");
                    string iscarbide = Console.ReadLine();
                    if (iscarbide == carbide)
                    {
                        Console.WriteLine("Your speed is " + alcspeed / diameter);
                    }
                    else
                    {
                        Console.WriteLine("Your speed is " + alsspeed / diameter);
                    }
                }
                else
                {
                    Console.WriteLine("Metal Spelled Wrong? Please try again.");
                }
            }
        }
    }
}
