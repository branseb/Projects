using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace FileReaders
{
    public class JsonFileReader : IFileReader
    {
        public List<string> ReadFile(string file)
        {
            if (File.Exists(file)) {
                var text = File.ReadAllText(file);
                var list = JsonSerializer.Deserialize<List<string>>(text);
                return list;
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
