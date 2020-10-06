using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteAllText
            var WriteText = "today class went awesome and concepts were clear";
            File.WriteAllText("Sample.txt",WriteText);

            //AppendAllLines
            var dummyLines = "This is first line" + Environment.NewLine +
                            "This is second line" + Environment.NewLine +
                            "This is third line.";
            Console.WriteLine(dummyLines);
            //Opens DummyFile.txt and append lines.If files not exists then create and open
            File.AppendAllLines(@"C:\\Users\asingh821\\Desktop\\DummyFile.txt", dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());
            Console.ReadKey();

            //AppendAllText
            File.AppendAllText(@"C:\\Users\asingh821\\Desktop\\DummyFile.txt", "This is Dummy file testing");
             Console.ReadKey();

            //Check wether file exists or not at particular location
             bool isFileExists = File.Exists(@"C:\\Users\\asingh821\\Desktop\\Dummy111File.txt");


            //Copy DummyFile.txt as new file DummyFileNew.txt
            File.Copy(@"C:\\Users\\asingh821\\Desktop\\DummyFile.txt", @"C:\\Users\\asingh821\\Desktop\\NewDummyFile.txt");
            Console.ReadKey();

            //get when the file was written last time
            DateTime lastWriteTime = File.GetLastWriteTime(@"C:\\Users\\asingh821\\Desktop\\DummyFile.txt");
            Console.ReadKey();

            // Move file to new location
            File.Move(@"C:\DummyFile.txt", @"D:\DummyFile.txt");

            //Open file and returns FileStream for reading bytes from the file
           FileStream fs = File.Open(@"C:\DummyFile.txt", FileMode.OpenOrCreate);

            //Open file and return StreamReader for reading string from the file
            StreamReader sr = File.OpenText(@"C:\DummyFile.txt");

            //Delete file
           File.Delete(@"C:\DummyFile.txt");
            Console.ReadKey();
        }
    }
}
