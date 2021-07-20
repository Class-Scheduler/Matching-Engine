using System.Collections.Generic;
namespace Class_Scheduler.Models
{
    public class Connection
    {
        public Class classInfo { get; }

        public List<Staff> staffList { get; set; }

        public Connection(Class inClassTime)
        {
            staffList = new List<Staff>();
            classInfo = inClassTime;
        }
    }
}