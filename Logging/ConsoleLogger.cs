﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(Exception exception)
        {
            Console.WriteLine(DateTime.Now + " - " + exception) ;     
        }
    }
}
