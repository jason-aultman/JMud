using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace JMud
{
    public static class FileHandler
    {
        public static string CurrentDirectory = Directory.GetCurrentDirectory();
        public static IEnumerable<string> enumerableFiles = Directory.EnumerateFiles(CurrentDirectory);

        public static IEnumerable<string> EnumerableFiles
        {
            get => enumerableFiles;
            set => enumerableFiles = value;
        }

        public static void DoNothing()
        {
            foreach (var enumerableFile in EnumerableFiles)
            {
                Console.WriteLine(enumerableFile);
            }
            
        }
        
        public static string GetRoomDataFromFile(string filePath)
        {
            string data;
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                data = streamReader.ReadToEnd();
            }

            return data;
        }
    }
}