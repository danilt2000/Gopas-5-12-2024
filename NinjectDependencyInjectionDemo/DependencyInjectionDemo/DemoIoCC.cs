using Ninject;

namespace DependencyInjectionDemo
{
    internal class DemoIoCC : StandardKernel
    {
        public DemoIoCC()
        {
            Bind<IGreeter>().To<Greeter>();

            Bind<ISharedService>().To<SharedService>().InSingletonScope();
            Bind<IService1>().To<Service1>();
            Bind<IService2>().To<Service2>();

            //Bind<IKernel>().ToConstant(this);
        }
    }
}
