using System;
using System.Collections.Generic;
using System.Text;

namespace NotGrubHub.Models
{
    public class Logger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine($"[LOGGER] {DateTime.Now} - {msg}");
        }
    }
}
