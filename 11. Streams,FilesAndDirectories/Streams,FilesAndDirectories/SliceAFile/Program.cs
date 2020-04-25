using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using var stream = new FileStream("sliceMe.txt", FileMode.OpenOrCreate);

            int parts = 4;

            var lenght = (int)Math.Ceiling(stream.Length / (double)parts);

            var buffer = new byte[lenght];

            for (int i = 0; i < parts; i++)
            {
                var byteread = stream.Read(buffer, 0, buffer.Length);
                
                if(byteread<buffer.Length)
                {
                    buffer = buffer.Take(byteread).ToArray();
                }
                using var curPart = new FileStream($"Part{i + 1}.txt", FileMode.Create);
                curPart.Write(buffer, 0, buffer.Length);

            }
            
            
        }
    }
}
