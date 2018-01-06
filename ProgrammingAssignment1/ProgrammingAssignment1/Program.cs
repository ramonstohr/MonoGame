using System;

namespace ProgrammingAssignment1
{
    internal class Program
    {
        /// <summary>
        /// Main entry point of program, which calculates distacne & angle for two points
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            //Write out the Welcome Message
            Console.WriteLine("Welcome\nI will calcaulate the distance & angle between two points of your choice!");

            //Get the user inputs for the two points
            Console.WriteLine("Please put in the X value of the first point: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.WriteLine("Please put in the Y value of the first point: ");
            float point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine("Please put in the X value of the second point: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.WriteLine("Please put in the Y value of the second point: ");
            float point2Y = float.Parse(Console.ReadLine());

            //Calculate deltaX /deltaY
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            //Calculate distance between the two points
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            //Calculate the angle, in radians from the deltaX/deltaY values
            double angleInRad = Math.Atan2(deltaY, deltaX);
            //Convert the radian value to degrees
            double angleInDeg = angleInRad * 180 / Math.PI;

            //Print out the calculated values, formatted to three digit decimals
            Console.WriteLine($"The distance between the two points is: {distance.ToString("#.000")}");
            Console.WriteLine($"The angle between the two points is: {angleInDeg.ToString("#.000")} degrees");
        }
    }
}