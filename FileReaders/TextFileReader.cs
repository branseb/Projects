using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaders
{
    public class TextFileReader : IFileReader
    {
        public List<string> ReadFile(string file)
        {
            var lines = File.ReadAllLines(file);
            return lines.ToList();
        }
    }
}
