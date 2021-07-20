using System;
using System.Collections.Generic;
using Class_Scheduler.Controllers.FileIOControllers;
using Class_Scheduler.Models;

namespace class_scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> staffFile = FileReading.readFile("tests/staff.json");
            List<String> unitsFile = FileReading.readFile("tests/units.json");

            FileParser fileParser = new FileParser();

            List<Unit> units = fileParser.parseUnitData(unitsFile);
            List<Staff> staff = fileParser.parseStaffData(staffFile);

            BasicAllocator basicAllocator = new BasicAllocator();


            basicAllocator.Allocate(units,staff);
        }
    }
}
