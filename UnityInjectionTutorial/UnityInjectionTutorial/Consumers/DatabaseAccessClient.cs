using UnityInjectionTutorial.Contracts;

namespace UnityInjectionTutorial.Consumers
{
    public class DatabaseAccessClient : IDatabaseAccess
    {
        public string _connection;
        public string connection
        {
            get
            {
                return _connection;
            }
            set
            {
                _connection = value;
            }
        }

    }

}
