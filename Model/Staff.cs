using System;
using System.Collections.Generic;

namespace Class_Scheduler.Models
{
    public class Staff
    {
        public String name { get; }

        public String id { get; }

        //Each day (Mon, Tues, etc maps to a DailyAvailability object which
        //contains all start and finish times for the staff on that day.)
        public List<TimePeriod> availability { get; }

        public List<String> preferences { get; }

        public Staff(String inName, String inID, List<TimePeriod> inAvailability, List<String> inPreferences)
        {
            name = inName;
            id = inID;
            availability = inAvailability;
            preferences = inPreferences;
        }

        public bool canTeach(TimePeriod period) {
            foreach (TimePeriod currentTimePeriod in availability)
            {
                if (currentTimePeriod.contains(period))
                {
                    return true;
                }
            }
            
            return false;
        }

        public override String ToString()
        {
            String staff = "";

            staff += "Staff Name: " + name;
            staff += "\nStaff ID: " + id;

            staff += "\nStaff Availability:";

            //Add availability to the output string.
            foreach (TimePeriod entry in availability)
            {
                staff += entry.ToString();
                staff += "\n";
            }

            //Add Preferences to the Output string.
            staff += "\nPreferences: ";

            //Iterate over every preference.
            foreach (String preference in preferences)
            {
                staff += "\n\t" + preference;
            }

            return staff;
        }
    }
}
