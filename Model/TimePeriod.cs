using System;

namespace Class_Scheduler.Models
{
    public class TimePeriod
    {
        public int startTime { get; }
        public int endTime { get; }
        public string day { get; }
        public TimePeriod ( int startTime, int endTime, string day)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.day = day;
        }

        public bool contains(TimePeriod t) {
            return t.startTime >= this.startTime && t.endTime <= this.endTime;
        }

        public override string ToString()
        {
            String s = "Start: ";
            s += startTime;
            s += "\nEnd: ";
            s += endTime;
            s += "\nDay: ";
            s += day;
            return s;
        }
    }
}