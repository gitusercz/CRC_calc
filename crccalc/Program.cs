

using DamienG.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace crccalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var crc32 = new Crc32();
            var hash = String.Empty;

            using (var fs = File.Open(Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "base.txt"), FileMode.Open))
                foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();

            Console.WriteLine("CRC-32 is {0}", hash);
            Console.ReadKey();
        }
    }
}
