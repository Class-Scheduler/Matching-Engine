using System;

namespace Class_Scheduler.Models
{
    public class TimePeriod
    {
        public int startTime { get; }

        public int endTime { get; }

        public String day { get; }

        public TimePeriod (int inStartTime, int inEndTime, String inDay)
        {
            startTime = inStartTime;
            endTime = inEndTime;
            day = inDay;
        }

        public bool contains(TimePeriod timePeriodToCheck) {
            return timePeriodToCheck.startTime >= startTime && timePeriodToCheck.endTime <= endTime;
        }

        public override String ToString()
        {
            String timePeriod = "Start: ";
            timePeriod += startTime;
            timePeriod += "\nEnd: ";
            timePeriod += endTime;
            timePeriod += "\nDay: ";
            timePeriod += day;

            return timePeriod;
        }
    }
}