using System;
using Autofac;

namespace OhceConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ContainerBuilder container = new ContainerBuilder();
            AutoFacConfigure autofacConfiguration = new AutoFacConfigure(container);
            autofacConfiguration.Configure();
            IContainer builder = container.Build();

            using (ILifetimeScope lifescope = builder.BeginLifetimeScope())
            {
                Process(lifescope);
            }
        }

        private static void Process(ILifetimeScope lifescope)
        {
            //Example
            //var instance lifescope.Resolve<IInterface>();

            Console.WriteLine("Welcome to Ohce Kata");
            Console.WriteLine("Write a word or q to quit");

            string input = Console.ReadLine();

            while (input != "q")
            {
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
