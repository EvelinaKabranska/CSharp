using System;
using System.Linq;
using System.IO;

namespace FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("../../../TestFolder");
            long sum = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            var sumInMB = (sum / 1024.0) / 1024.0;

            File.WriteAllText("../../../result.txt", sumInMB.ToString());
        }
    }
}
