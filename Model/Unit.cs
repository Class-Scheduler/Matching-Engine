using System;
using System.Collections.Generic;

namespace Class_Scheduler.Models
{
    public class Unit {
        public String code { get; set; }

        public int numTutors { get; set; }

        public Dictionary<String, List<int[]>> schedule;

        public Unit(String inCode, int inNumTutors, Dictionary<String, List<int[]>> inSchedule)
        {
            code = inCode;
            numTutors = inNumTutors;
            schedule = inSchedule;
        }

        public override string ToString()
        {
            String unit = "";

            unit += "Unit Code: " + code;
            unit += "\nNumber of Tutors: " + numTutors.ToString();
            unit += "\nUnit Schedule:";

            foreach (KeyValuePair<String, List<int[]>> entry in schedule)
            {
                //Fetch the Key.
                String dayName = entry.Key;

                //Add the Day Name to the output string.
                unit += "\n\tDay: " + dayName;

                unit += "\n\tTimes:";

                //Fetch the Value.
                List<int[]> dayTimes = entry.Value;

                //Iterate over dayTimes.
                foreach (int[] time in dayTimes)
                {
                    //Extract the start and end time.
                    int startTime = time[0];
                    int endTime = time[1];

                    unit += "\n\t\t" + startTime.ToString() + " - " + endTime.ToString();
                }

                unit += "\n";
            }

            return unit;
        }
    }
}
