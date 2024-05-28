using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class Client
    {
        private IService1 _service1;
        private IService2 _service2;
        private readonly IKernel kernel;

        
        public Client(IKernel kernel)
        {
            this.kernel = kernel;
        }

        [Inject]
        public IGreeter Greeter { get; set; }

        public void UseServices()
        {
            Greeter.SayHello();

            if(_service1 == null) _service1 = kernel.Get<IService1>();
            if(_service2 ==null) _service2 = kernel.Get<IService2>();
            _service1.IncOnce();
            _service2.IncTwice();

        }
    }
}
