using Autofac;
using IoCConfiguration;

namespace OhceConsole
{
    public class AutoFacConfigure : IConfigIoC
    {
        private readonly ContainerBuilder container;

        public AutoFacConfigure(ContainerBuilder containerBuilder)
        {
            this.container = containerBuilder;
        }

        public void Configure()
        {
            this.container.RegisterType<Inverter>().As<IInverter>();
            this.container.RegisterType<StandarStrategy>().As<IInverterStrategy>();
            this.container.RegisterType<PalindromeStrategy>().As<IInverterStrategy>();
            this.container.RegisterType<EvenStrategy>().As<IInverterStrategy>();
            this.container.RegisterType<NotEvenStrategy>().As<IInverterStrategy>();
            this.container.RegisterType<MinStrategy>().As<IInverterStrategy>();
        }
    }
}
