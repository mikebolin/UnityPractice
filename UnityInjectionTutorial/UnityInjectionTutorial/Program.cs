using System;
using Microsoft.Practices.Unity;
using UnityInjectionTutorial.Consumers;
using UnityInjectionTutorial.Contracts;
using UnityInjectionTutorial.Services;

namespace UnityInjectionTutorial
{
    class Program
    {
        static void Main()
        {
            //Create a DTO
            DTOClient dto = new DTOClient("John Smith", "1895 Ocean Drive", "123-455-4321");
            //Create a unity container 
            var clientContainer = new UnityContainer();
            //Map an interfaces to concrete class
            clientContainer.RegisterType<IService, Service1>();
            clientContainer.RegisterType<IDatabaseAccess, DatabaseAccessClient>();

            // ----------------------------------------------------------- Method Injection ------------------------------------------------------------
            Console.WriteLine(Environment.NewLine, "Starting Method Injection example" + Environment.NewLine);
            //IService method injection see client
            Client clientMethodInjection = new Client();
            //Inject IService and IDatabaseAccess dependencies into method
            clientMethodInjection.StartMethodInjection(dto, clientContainer.Resolve<IService>(), clientContainer.Resolve<IDatabaseAccess>());
            
            // ----------------------------------------------------------- Constructor Injection ------------------------------------------------------------
            Console.WriteLine(Environment.NewLine, "Starting Constructor Injection example" + Environment.NewLine);

            //Inject IService and IDatabaseAccess dependencies into Constructor
            Client clientConstructorInjection = new Client(clientContainer.Resolve<IService>(), clientContainer.Resolve<IDatabaseAccess>());
            clientConstructorInjection.Start(dto);

            Console.ReadKey();
        }
    }
}
