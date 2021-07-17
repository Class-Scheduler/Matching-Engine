using System;
using System.Collections.Generic;

namespace Class_Scheduler.Models
{
    public class Staff 
    {
        public String name { get; set; }

        public String id { get; set; }

        //Each day (Mon, Tues, etc maps to a DailyAvailability object which 
        //contains all start and finish times for the staff on that day.)
        public Dictionary<String, List<int[]>> availability { get; set; }

        public List<String> preferences { get; set; }

        public Staff(String inName, String inID, Dictionary<String, List<int[]>> inAvailability, List<String> inPreferences)
        {
            name = inName;
            id = inID;
            availability = inAvailability;
            preferences = inPreferences;
        }

        public override string ToString()
        {
            String staff = "";

            staff += "Staff Name: " + name;
            staff += "\nStaff ID: " + id;

            staff += "\nStaff Availability:";

            //Add availability to the output string.
            foreach (KeyValuePair<String, List<int[]>> entry in availability)
            {
                //Fetch the Key.
                String dayName = entry.Key;

                //Add the Day Name to the output string.
                staff += "\n\tDay: " + dayName;

                staff += "\n\tTimes:";

                //Fetch the Value.
                List<int[]> dayTimes = entry.Value;

                //Iterate over dayTimes.
                foreach (int[] time in dayTimes)
                {
                    //Extract the start and end time.
                    int startTime = time[0];
                    int endTime = time[1];

                    staff += "\n\t\t" + startTime.ToString() + " - " + endTime.ToString();
                }

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
