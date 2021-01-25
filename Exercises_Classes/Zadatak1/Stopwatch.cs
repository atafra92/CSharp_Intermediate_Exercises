using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak1
{
    public class Stopwatch
    {
        public DateTime StopwatchStart { get; private set; }
        public DateTime StopwatchStop { get; private set; }

        public TimeSpan Duration 
        {
            get
            {
                return StopwatchStop.Subtract(StopwatchStart);
            }      
        }

        public void Start()
        {
            StopwatchStart = DateTime.Now;
            Console.WriteLine($"Stopwatch has started at {StopwatchStart.ToLongTimeString()}");
        }

        public void Stop()
        {
            StopwatchStop = DateTime.Now;
            Console.WriteLine($"Stopwatch has stoped at {StopwatchStop.ToLongTimeString()}");
        }
    }
}
