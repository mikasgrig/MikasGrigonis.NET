using System;

namespace MikasGrigonis.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write destination to Km");
            var destinationKm = Convert.ToInt32(Console.ReadLine());
            var person = 3;
            Console.WriteLine("Write friends walking speed Km/H");
            var walkingSpeedKmH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write bike speed Km/H");
            var bikeSpeedKmH = Convert.ToInt32(Console.ReadLine());
            // bike can take 2 person
            var bike = 1;
            var personToDestination = 0;
            double fastTime = 0;
            
            
            do
            {
                if (person >= 3)
                {
                    for (personToDestination = 0; personToDestination < person; personToDestination++)
                    {
                        var bikeDestinationH = destinationKm / bikeSpeedKmH;
                        personToDestination++;
                        var walkingKm = walkingSpeedKmH * bikeDestinationH;
                        var bikeBackH = Distance((destinationKm-walkingKm), bikeSpeedKmH);
                        var bikeBackDesestinationH = Distance((destinationKm-walkingKm), bikeSpeedKmH);
                        personToDestination++;
                        fastTime += bikeDestinationH + bikeBackH + bikeBackDesestinationH;
                    }
                }
                else
                {
                    double bikeDestinationH = Distance(destinationKm, bikeSpeedKmH);
                    personToDestination++;
                    personToDestination++;
                    fastTime += bikeDestinationH;
                }
              
                
            } while (!(personToDestination >= person));

            
            Console.WriteLine($"Best time all friends go to destination is : {fastTime} Hours");

        }
        private static double Distance(int a, int b)
        {
            var adouble = Convert.ToDouble(a);
            var bdouble = Convert.ToDouble(b);
            var result = adouble / bdouble;

            return result;
        }
    }
}