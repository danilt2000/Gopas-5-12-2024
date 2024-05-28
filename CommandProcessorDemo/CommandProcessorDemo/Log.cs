using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandProcessorDemo
{
    public class Log : ILog
    {
        private List<string> items = new();

        public IEnumerable<string> Items => items;

        public void Write(string message)
        {
            items.Add(message);
        }

        public void RemoveLastMessage()
        {
            items.RemoveAt(items.Count - 1);
        }
    }
}
