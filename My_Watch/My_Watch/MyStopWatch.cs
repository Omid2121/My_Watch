using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Watch
{
    public class MyStopWatch
    {
        public Stopwatch stopwatch = new Stopwatch();

        private TimeSpan lastLap;

        private TimeSpan currentLap;

        public string CreateLap()
        {
            currentLap = stopwatch.Elapsed - lastLap;

            lastLap = stopwatch.Elapsed;

            return string.Format("{0:00} : {1:00} : {2:00} . {3:00}", currentLap.Hours, currentLap.Minutes, currentLap.Seconds, currentLap.Milliseconds);
        }
    }
}
