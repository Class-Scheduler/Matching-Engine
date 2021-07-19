using System.Collections.Generic;

namespace Class_Scheduler.Models
{
    public class Connection
    {
        public Class classInfo { get; }

        public List<Staff> staffList { get; set; }

        public Connection(Class classTime)
        {
            this.staffList = new List<Staff>();
            this.classInfo = classTime;
        }
    }
}