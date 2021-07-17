using System;

namespace Class_Scheduler.Models
{
    public class Timeslot {
        public int startTime { get; set; }
        
        public int endTime { get; set; }

        public String unitCode { get; set; }

        public String day { get; set; }

        public int numTutors { get; set; }

        public Timeslot(int inStartTime, int inEndTime, String inUnitCode, String inDay, int inNumTutors)
        {
            startTime = inStartTime;
            endTime = inEndTime;
            unitCode = inUnitCode;
            day = inDay;
            numTutors = inNumTutors;
        }

        public override string ToString()
        {
            String timeslot = "";

            timeslot += "\n\nUnit: " + unitCode;
            timeslot += "\nNumber of Tutors Required: " + numTutors;
            timeslot += "\nDay: " + day;
            timeslot += "\n\tClass Time: " + startTime.ToString() + " - " + endTime.ToString();

            return timeslot;            
        }
    }
}
