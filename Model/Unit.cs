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

        //Constructor is used for staff to represent what classes they want.
        public Unit(String inCode)
        {
            code = inCode;
        }
    }
}
