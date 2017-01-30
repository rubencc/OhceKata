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
            //Configure IoC
        }
    }
}
