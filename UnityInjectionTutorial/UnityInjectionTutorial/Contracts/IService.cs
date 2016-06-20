namespace UnityInjectionTutorial.Contracts
{
    public interface IService
    {
        void Serve();
        void callDatabase(IDatabaseAccess ConnectionInformation);
        void printDTO(DTOClient client);

        //Do more service stuff

    }
}
