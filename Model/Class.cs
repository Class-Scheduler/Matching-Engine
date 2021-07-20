using System;
using System.Collections.Generic;

namespace Class_Scheduler.Models
{
    public class Class {

        public String unitCode { get; }

        public TimePeriod datetime { get; }

        public int numTutors { get; }

        public List<Staff> allocatedTutors {get; set;}

        public Class(TimePeriod inDatetime, String inUnitCode, int inNumTutors)
        {
            datetime = inDatetime;
            unitCode = inUnitCode;
            numTutors = inNumTutors;
            allocatedTutors = new List<Staff>();
        }

        public bool needsStaff() {
            return allocatedTutors.Count < numTutors;
        }

        public override String ToString()
        {
            String timeslot = "";

            timeslot += "\n\nUnit: " + unitCode;
            timeslot += "\nNumber of Tutors Required: " + numTutors;
            timeslot += "\n" + datetime.ToString();

            return timeslot;
        }
    }
}
