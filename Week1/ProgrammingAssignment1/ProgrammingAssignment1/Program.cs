using System;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// Application to Calculate the Distance and Angle between the points provided by the User
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Guest!");
            Console.Write("The application will calculate the distance and angle between the two points.");
            Console.WriteLine();
            Console.WriteLine("Please enter first x value");
            float point1X = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter first y value");
            float point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second x value");
            float point2X = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second y value");
            float point2Y = float.Parse(Console.ReadLine());
            float deltaX = CalculateDifferenceBetweenPoints(point2X, point1X);
            float deltaY = CalculateDifferenceBetweenPoints(point2Y, point1Y);
            CalculateDistanceBetweenPoints(deltaX, deltaY);
            CalculateAngleBetweenPoints(deltaY, deltaX);
            //Console.ReadLine();
        }
        /// <summary>
        /// Calculates The Difference between two given point coordinates
        /// </summary>
        /// <param name="point2"></param>
        /// <param name="point1"></param>
        /// <returns></returns>
        private static float CalculateDifferenceBetweenPoints(float point2, float point1 )
        {
            float deltaPoint = point2 - point1;
            return deltaPoint;
        }
        /// <summary>
        /// Calculates the Angle Between the two given points
        /// </summary>
        /// <param name="deltaY"></param>
        /// <param name="deltaX"></param>
        private static void CalculateAngleBetweenPoints(float deltaY, float deltaX)
        {
            float angle = (float)(Math.Round((float)(Math.Atan2(deltaY, deltaX) * 180.0 / Math.PI),3));
            Console.WriteLine($"The angle between the two points is {angle:0.000} degrees");
        }
        /// <summary>
        /// Calculates the Distance between the two points
        /// </summary>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        private static void CalculateDistanceBetweenPoints(float deltaX, float deltaY)
        {
            float distance = (float) (Math.Round(Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2)), 3));
            Console.WriteLine($"The distance between the two points is {distance}");
        }
    }
}
