using System;
using System.Diagnostics;
using Class_Scheduler.Models;
using System.Collections.Generic;
using Class_Scheduler.Controllers.FileIOControllers;

public class BasicAllocator
{
    public BasicAllocator()
    {
    }

    public List<Unit> Allocate(List<Unit> units, List<Staff> staff)
    {
        List<Connection> connections = getClassConnections(units, staff);

        while (true)
        {

            connections.Sort((a, b) =>
            {
                return a.staffList.Count - b.staffList.Count;
            });

            // Remove connections with no staff.
            Console.WriteLine("Removed:");
            bool complete = true;

            foreach (Connection currentConnection in connections)
            {
                if (currentConnection.staffList.Count == 0)
                {
                    Console.WriteLine(String.Format("Allocation Complete:\n {0}", currentConnection.classInfo.ToString()));
                    continue;
                }

                complete = false;
                Class currentClass = currentConnection.classInfo;
                Staff staffMember = currentConnection.staffList[0];

                // allocate this staff member to the class
                if (currentClass.needsStaff())
                {
                    currentClass.allocatedTutors.Add(staffMember);
                    currentConnection.staffList.Remove(staffMember);
                }

            }

            if (complete) break;
        }
        return units;
    }

    public List<Connection> getClassConnections(List<Unit> units, List<Staff> staffList)
    {
        List<Connection> connections = new List<Connection>();
        List<Class> classes = new List<Class>();

        foreach (Unit currentUnit in units)
        {
            foreach (Class currentClass in currentUnit.classList)
            {
                connections.Add(new Connection(currentClass));
            }
        }

        foreach (Connection currentConnection in connections)
        {
            TimePeriod classTime = currentConnection.classInfo.datetime;
            foreach (Staff staffMember in staffList)
            {
                // check if they can teach and if they can add them to the connections list
                if (staffMember.canTeach(classTime))
                {
                    Console.WriteLine("{0}", currentConnection.ToString());
                    currentConnection.staffList.Add(staffMember);
                }
            }
        }

        return connections;
    }
}