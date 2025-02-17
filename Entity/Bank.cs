namespace GenericBankExercise.Entity
{
    public class Bank
    {
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public List<Client> Clients { get; set; }

        public Bank() 
        {
            BankName = "Generic Bank";
            BankCode = "937";
            Clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            Clients.Add(client);
        }
    }
}
