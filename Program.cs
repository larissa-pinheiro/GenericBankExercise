using GenericBankExercise.Entity;

namespace GenericBank
{
    public static class Program
    {
        public static void Main()
        {
            var bank = new Bank();

            var clients = new List<Client>
            {
                new Client(1)
                {
                    FirstName = "João",
                    LastName = "Silva",
                    BirthDate = new DateTime(1999, 3, 5),
                    Cpf = "123.456.789-00",
                    Address = "Rua Ciclana, 19",
                    City = "São Paulo",
                    State = "SP",
                    ZipCode = "12345-678",
                    Phone = "(11) 00000-4121",
                    Email = "joao@gmail.com",
                    Password = "123456",
                    Balance = 0.0F,
                    Salary = 1500.0F
                },
                new Client(2)
                {
                    FirstName = "Maria",
                    LastName = "Santos",
                    BirthDate = new DateTime(1995, 7, 15),
                    Cpf = "987.654.321-00",
                    Address = "Av. Fulano, 123",
                    City = "Rio de Janeiro",
                    State = "RJ",
                    ZipCode = "12345-678",
                    Phone = "(21) 00000-2920",
                    Email = "maria@gmail.com",
                    Password = "789101",
                    Balance = 0.0F,
                    Salary = 2000.0F
                }

            };

            foreach (var client in clients)
            {
                bank.AddClient(client);
            }


            Console.WriteLine($"Banco: {bank.BankName} ({bank.BankCode})");
            Console.WriteLine($"Total de clientes: {bank.Clients.Count}");
        }
    }
}