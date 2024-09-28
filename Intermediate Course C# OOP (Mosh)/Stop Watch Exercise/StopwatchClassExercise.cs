using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Course_C__OOP__Mosh_.Stop_Watch_Exercise
{
    public class StopwatchClassExercise
    {
        private DateTime _startTime;
        private TimeSpan _duration;
        private bool _isRunning;
        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("The stopwatch is already running");
            
            _startTime = DateTime.Now;
            Console.WriteLine("The Stopwatch starts at {0}", _startTime);
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("The stopwatch is not running");

            _duration = DateTime.Now - _startTime;
            int durationTime = _duration.Seconds;
            Console.WriteLine("Time stoped: {0}", _duration);
            _isRunning = false;        
        }
    }
}
