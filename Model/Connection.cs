using System;

namespace Class_Scheduler.Models 
{
    public class Connection 
    {
        public Timeslot timeslot { get; set; }

        public List<Staff> staffList { get; set; }
    }
}