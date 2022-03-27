using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day27FileOperations
{
    public class FileOperations
    {
        public void FileExits()
        {
            string path = @"D:\.net\Day27FileOperations\Day27FileOperations\FileOperationDemo.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Not Found");
            }
            Console.ReadKey();

        }
        public void ReadAllLine()
        {
            string path = @"D:\.net\Day27FileOperations\Day27FileOperations\FileOperationDemo.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            foreach (var l in lines)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();
        }
        public void ReadAllText()
        {
            string path = @"D:\.net\Day27FileOperations\Day27FileOperations\FileOperationDemo.txt";

            string lines = File.ReadAllText(path);
            Console.WriteLine(lines);

            Console.ReadKey();
        }
        public void FileCopy()
        {
            string path = @"D:\.net\Day27FileOperations\Day27FileOperations\FileOperationDemo.txt";
            string copypath = @"D:\.net\Day27FileOperations\Day27FileOperations\FileCopy.txt";
            File.Copy(path, copypath);
            Console.ReadKey();

        }
        public void FileDelete()
        {
            string path = @"D:\.net\Day27FileOperations\Day27FileOperations\FileCopy.txt";
            File.Delete(path);

            Console.ReadKey();
        }

    }
}
