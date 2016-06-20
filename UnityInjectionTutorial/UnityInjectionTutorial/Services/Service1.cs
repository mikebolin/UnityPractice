using System;
using UnityInjectionTutorial.Contracts;

namespace UnityInjectionTutorial.Services
{
    class Service1 : IService
    {
        private DTOClient _service1ClientData;

        public void Serve()
        {
            Console.WriteLine("Service 1 Called");
            //Do Something
        }
        public void callDatabase(IDatabaseAccess Connection)
        {
            Console.WriteLine("Start DB Engine with  " + Connection.connection + Environment.NewLine);
            //Do Something
        }

        public void printDTO(DTOClient client)
        {
            //Save DTO, both service and client share this information
            _service1ClientData = client;
            Console.WriteLine("Printing DTO, name, address, phone : " + client.Name + " " + client.Address + " " + client.Phone, Environment.NewLine);
        }
    }
}
