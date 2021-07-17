using System;
using Class_Scheduler.Models;
using System.Collections.Generic;
using Class_Scheduler.Controllers.FileIOControllers;

namespace class_scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Replace this filename with what file you want to test.
            List<String> fileContents = FileReading.readFile("tests/units.json");

            FileParser fileParser = new FileParser();

            //Checks whether the data is staff or unit.
            String dataType = fileParser.checkDataType(fileContents);

            //Parse the data accordingly, can change to a switch case later for performance.
            if (dataType.Equals("staffData"))
            {
                List<Staff> staffList = fileParser.parseStaffData(fileContents);

                foreach (Staff currentStaff in staffList)
                {
                    Console.WriteLine(currentStaff.ToString() + "\n");
                }
            }
            else if (dataType.Equals("unitData"))
            {
                List<Unit> unitList = fileParser.parseUnitData(fileContents);

                foreach (Unit currentUnit in unitList)
                {
                    Console.WriteLine(currentUnit.ToString() + "\n");
                }
            }
            else
            {
                //Add a custom exception here later.
            }
        }
    }
}
