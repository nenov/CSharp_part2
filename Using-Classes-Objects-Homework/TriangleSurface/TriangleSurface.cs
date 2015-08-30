using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurface
{
    class TriangleSurface
    {
        static double AreaA(double side, double altitude)
        {
            return (side*altitude)/2;
        }
        static double AreaB(double first, double second, double third)
        {
            double p = (first + second + third) / 2;
            double result = p * (p - first) * (p - second) * (p - third);
            return Math.Sqrt(result);
        }
        static double AreaC(double first, double second, double angle)
        {
            double mid = (first * second) / 2;
            //Multiply by Math.PI/180 to convert degrees to radians.
            angle = angle * (Math.PI / 180);
            return (mid * Math.Sin(angle));
        }
        static void Main(string[] args)
        {
            //Write methods that calculate the surface of a triangle by given:
            // a) Side and an altitude to it;
            Console.WriteLine("You are about the calculate the surface of triangle given a Side and an altitude to it.");
            Console.WriteLine("Please enter the side:");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the altitude:");
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine("The result is: " + AreaA(side,altitude));
            // b) Three sides;
            Console.WriteLine("You are about the calculate the surface of triangle given three sides.");
            Console.WriteLine("Please enter first side:");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second side:");
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third side:");
            double third = double.Parse(Console.ReadLine());
            Console.WriteLine("The result is: " + AreaB(first,second,third));
            // c) Two sides and an angle between them;
            Console.WriteLine("You are about the calculate the surface of triangle given Two sides and an angle between them.");
            Console.WriteLine("Please enter first side:");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second side:");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the angle between them:");
            double angle = double.Parse(Console.ReadLine());
            Console.WriteLine("The result is: " + AreaC(sideA, sideB, angle));
            //Use System.Math.
            
        }
    }
}
