using System;
using System.IO;

namespace WindowsFileApplication
{

    class Program
    {

        static void Main(string[] args)
        {
            //creating a DirectoryInfo object
            DirectoryInfo mydir = new DirectoryInfo(@"c:\Windows");

            // getting the files in the directory, their names and size
            FileInfo[] f = mydir.GetFiles();
            DirectoryInfo[] d = mydir.GetDirectories();
            foreach (DirectoryInfo dir in d)
            {
                Console.WriteLine("Dir Name: {0} ", dir.Name);
            }
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0} Size: {1}", file.Name, file.Length);
            }

            Console.ReadKey();
        }
    }
}