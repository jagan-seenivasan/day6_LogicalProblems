using System;

namespace day_6_LogicalProblems
{
     class StopWatch
    {
        public static void CountTminer()
        {
            SWatch sw = new SWatch();
            sw.Start();
            for(int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1000);
            }
            sw.Stop();
            Console.WriteLine("Time" + sw.Elapsed);
        }
    }
}