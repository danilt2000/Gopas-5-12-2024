using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class Service2 : IService2
    {
        private readonly ISharedService _sharedService;

        public Service2(ISharedService sharedService)
        {
            _sharedService = sharedService;
        }

        public void IncTwice()
        {
            _sharedService.Increase();
            _sharedService.Increase();
            Console.WriteLine(_sharedService.Count);
        }
    }
}
