using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaders
{
    public class TextFileWriter : IFileWriter
    {
        public void WriteFile(string file, List<string> rows)
        {
            File.WriteAllLines(file, rows);
        }
    }




}

