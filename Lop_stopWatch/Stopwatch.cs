using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lop_stopWatch
{
    internal class Stopwatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartTime { get => startTime;  }
        public DateTime EndTime { get => endTime;  }
       public Stopwatch()
        {
            startTime = DateTime.Now;
        }
        public void Start()
        {
            startTime = DateTime.Now;
        }
        public void Stop()
        {
            endTime = DateTime.Now;
        }
        public double GetElapsedTime()
        {
        return (endTime - startTime).TotalMilliseconds;
        }
        public DateTime GetStartTime()
        {
            return startTime;
        }
        public DateTime GetEndTime()
        {
            return endTime;
           
        }

                   
    }
}
