using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_
{
    internal class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _duration;

        //We use private to the set property for us to initialize the StartTime only once and to avoid
        //accidentaly re-initializing the StartTime again

        public DateTime StartTime { get; private set; }

        public DateTime Start()
        {
            StartTime =  DateTime.Now;
            _startTime = StartTime;
            return _startTime;
        }

        public TimeSpan Stop()
        {
            _endTime = DateTime.Now;
            _duration = _endTime - _startTime; 
            return _duration;
        }
    }
}
