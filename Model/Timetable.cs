using System.Collections.Generic;

namespace Class_Scheduler.Models
{
    public class Timetable {
        public List<Staff> staffList { get; set; }

        public List<Unit> unitList { get; set; }

        public Timetable(List<Staff> inStaffList, List<Unit> inUnitList)
        {
            staffList = inStaffList;
            unitList = inUnitList;
        }
    }
}
