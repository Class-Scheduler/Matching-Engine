using System;
using System.IO;
using System.Collections.Generic;

namespace Class_Scheduler.Controllers.FileIOControllers
{
    public class FileReading {
        public static List<String> readFile(String fileName)
        {
            List<String> fileContents = null;
            
            try 
            {
                fileContents = new List<String>(File.ReadAllLines(fileName));
            }
            catch (ArgumentException argumentException)
            {
                //Will add custom exceptions here later.
            }
            catch (PathTooLongException invalidPathException)
            {
                //Will add custom exceptions here later.
            }

            return fileContents;
        }
    }
}
