using System;
using System.IO;
using System.Text;

namespace Streams_FilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("input.txt")) 

            {
                int counter = 0;
                string line = string.Empty; 

                using (var writer = new StreamWriter("Output.txt"))
                {
                    while((line=reader.ReadLine())!=null)
                    {
                        if(counter%2==1)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                    }
                }
            }
        }
    }
}
