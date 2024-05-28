using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class Service1 : IService1
    {
        private readonly ISharedService _sharedService;

        public Service1(ISharedService sharedService)
        {
            _sharedService = sharedService;
        }

        public void IncOnce()
        {
            _sharedService.Increase();
            Console.WriteLine(_sharedService.Count);
        }
    }
}
