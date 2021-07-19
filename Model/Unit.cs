using System;
using System.Collections.Generic;

namespace Class_Scheduler.Models
{
    public class Unit {
        public String code { get; }

        public int numTutors { get; }

        public List<Class> classList;

        public Unit(String inCode, int inNumTutors, List<Class> classList)
        {
            this.code = code;
            this.numTutors = numTutors;
            this.classList = classList;
        }

        public override string ToString()
        {
            String unit = "";

            unit += "Unit Code: " + code;
            unit += "\nNumber of Tutors: " + numTutors.ToString();
            unit += "\nUnit Classes:";

            foreach (Class entry in classList)
            {
                unit += entry.ToString() + "\n";
            }

            return unit;
        }
    }
}
