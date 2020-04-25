using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var finNum = new List<int>();
            using var read1 = new StreamReader("FileOne.txt");
            var line = string.Empty;
            while ((line = read1.ReadLine()) != null)
            {
                int num = int.Parse(line);
                finNum.Add(num);
            }
            using var read2 = new StreamReader("FileTwo.txt");
            var line2 = string.Empty;
            while ((line2 = read2.ReadLine()) != null)
            {
                int num = int.Parse(line2);
                finNum.Add(num);
            }

            finNum = finNum.OrderBy(x => x).ToList();

            using var writer = new StreamWriter("../../../Output.txt");
            foreach (var item in finNum)
            {
                writer.WriteLine(item);
            }
        }
    }
}
