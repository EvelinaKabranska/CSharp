using System;
using System.IO;
using System.Text;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using var fileReader = new FileStream("../../../copyMe.png", FileMode.Open);

            byte[] buffer = new byte[4096];

            using var fileWriter = new FileStream(@"../../../new.png", FileMode.Create);

            while (fileReader.CanRead)
            {
                int bytesReader = fileReader.Read(buffer, 0, buffer.Length);
                if (bytesReader == 0)
                {
                    break;
                }
              fileWriter.Write(buffer, 0, bytesReader);

            }
        }
    }
}
