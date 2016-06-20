using System;
using UnityInjectionTutorial.Contracts;

namespace UnityInjectionTutorial.Consumers
{
    public class Client
    {
        
        private IService _service;
        private readonly IDatabaseAccess _database;
        private DTOClient _dtoClient;

        //IService & IDatabaseAccess constructor injection
        public Client(IService service, IDatabaseAccess dataAccess)
        {
            _service = service;
            _database = dataAccess;
            dataAccess.connection = "setConnectionString.ConstructorInjection";
        }

        public Client() { }

        public void Start(DTOClient infoClient)
        {
            Console.WriteLine("Client Service Started for Constructor Injection ");
            _dtoClient = infoClient;
            _service.Serve();
            _service.printDTO(infoClient);
            _service.callDatabase(_database);

        }
        //Method injection
        public void StartMethodInjection(DTOClient infoClient, IService service, IDatabaseAccess dataAccess)
        {
            Console.WriteLine("Client Service Started for Method Injection ");
            dataAccess.connection = "setConnectionString.MethodInjection";
            _dtoClient = infoClient;
            _service = service;
            _service.Serve();
            _service.printDTO(infoClient);
            _service.callDatabase(dataAccess);
        }

    }
}
