using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class FileLogger : ILogger
    {
        private readonly string file;

        public FileLogger (string file)
        {
            this.file = file;
        }
        public void Log(Exception exception)
        {
            File.AppendAllText(file,DateTime.Now + " - " + exception.ToString() + Environment.NewLine);
        }
    }
}
