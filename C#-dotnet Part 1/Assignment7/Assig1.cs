using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{

    class Assig7_1
    {
        public static void MainExecution()
        {
            Console.WriteLine("Enter the file system location: ");
            string fileSystemLocation = Console.ReadLine();

            Console.WriteLine("Enter the folder name: ");
            string folderName = Console.ReadLine();

            DirectoryInfo directoryInfo = new DirectoryInfo(fileSystemLocation + "\\" + folderName);

            // List subdirectories using DirectoryInfo
            Console.WriteLine("\nSubdirectories:");
            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                Console.WriteLine(subDirectory.Name);
            }

            // Read text files using FileInfo and display their contents
            Console.WriteLine("\nText Files:");
            FileInfo[] textFiles = directoryInfo.GetFiles("*.txt");
            foreach (FileInfo textFile in textFiles)
            {
                Console.WriteLine("\nContents of file " + textFile.Name + ":");
                string[] fileLines = File.ReadAllLines(textFile.FullName);
                foreach (string fileLine in fileLines)
                {
                    Console.WriteLine(fileLine);
                }
            }
        }
    }
}


