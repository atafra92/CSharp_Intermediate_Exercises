using System;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            int index = 0;
            bool isRunning = false;

            do
            {
                Console.WriteLine("Press enter to start a stopwatch");
                string start = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(start) && isRunning == false)
                {
                    stopwatch.Start();
                    isRunning = true;
                }
                else
                {
                    throw new InvalidOperationException("Stopwatch is already running!");
                }

                string stop = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(stop))
                {
                    stopwatch.Stop();
                    isRunning = false;
                    index++;
                }

                Console.WriteLine($"Duration time: {stopwatch.Duration.Hours:D2}:{stopwatch.Duration.Minutes:D2}:{stopwatch.Duration.Seconds:D2} seconds");

                Console.ReadLine(); 
            } while (index < 2);
        }
    }
}
