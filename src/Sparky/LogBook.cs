using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sparky
{
    public interface ILogBook 
    {
        void Log(string message);
    }
    public class LogBook
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}