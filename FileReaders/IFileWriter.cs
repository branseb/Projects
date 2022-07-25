using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaders
{
    public interface IFileWriter
    {
        void  WriteFile (string file,List<string> rows);
    }
}
