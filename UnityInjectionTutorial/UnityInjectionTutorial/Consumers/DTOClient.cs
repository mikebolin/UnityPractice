namespace UnityInjectionTutorial
{

    public class DTOClient
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DTOClient(string theName, string theAddress, string thePhone)
        {
            Name = theName;
            Address = theAddress;
            Phone = thePhone;
        }
    }
}
