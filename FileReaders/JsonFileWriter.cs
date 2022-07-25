using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace FileReaders
{
    public class JsonFileWriter : IFileWriter
    {
        public void WriteFile(string file, List<string> rows)
        {
           var text = JsonSerializer.Serialize(rows);
           File.WriteAllText(file, text);
        }
    }
}
