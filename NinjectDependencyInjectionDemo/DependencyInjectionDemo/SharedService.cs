using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class SharedService : ISharedService
    {
        public int Count { get; private set; }
        public void Increase() { Count++; }
    }
}
