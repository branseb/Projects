using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaders
{
    public class FileReaderAdapter
    {
        private readonly Dictionary<string, IFileReader> readers;
        private readonly Dictionary<string, IFileWriter> writers;

        public FileReaderAdapter()
        {
            readers = new Dictionary<string, IFileReader>();
            writers = new Dictionary<string, IFileWriter>();
        }

        public void RegisterReader(string ext, IFileReader reader)
        {
            readers.Add(ext, reader);
        }

        public void RegisterWriter(string ext, IFileWriter writer)
        {
            writers.Add(ext, writer);
        }

        public void WriteFile(string file, List<string> rows)
        {
            var ext = Path.GetExtension(file);
            var writer = writers[ext]; 
            writer.WriteFile(file, rows);
            
        }
        public List<string> ReaderFile(string file)
        {
            var ext = Path.GetExtension(file);
            var reader = readers[ext];
            var list = reader.ReadFile(file);
            return list;
        }


    }
}
