using System;

namespace paint_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            // How much paint needed?
            // Paint capacity 100 ft²/gallon
            //Room is 12ft lenght, 10 ft width, 8ft tall
            //Exclude windows: 5 ft by 3 ft, 6 ft by 2 ft

            double paintPerGallon = 100;
            double window1 = 5 * 3;   //15
            double window2 = 6 * 2;   //12
            double ceiling = 12 * 10;  //120
            double wall1 = (12 * 8) * 2;  //192
            double wall2 = (10 * 8) * 2;   //160
            double finalPaint;
            finalPaint = (ceiling + wall1 + wall2 - (window1 + window2)) / paintPerGallon;
            Console.WriteLine(finalPaint);
            Console.ReadLine();
        }
    }
}
