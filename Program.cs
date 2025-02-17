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
                    Salary = 1500.0F,
                    BankAccount = new BankAccount
                    {
                        AccountNumber = "12345-6",
                        Agency = "1234",
                        AccountType = AccountType.ContaCorrente,
                        Balance = 0.0F
                    }
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
                    Salary = 2000.0F,
                    BankAccount = new BankAccount
                    {
                        AccountNumber = "54321-0",
                        Agency = "4321",
                        AccountType = AccountType.ContaPoupanca,
                        Balance = 0.0F
                    }
                }

            };

            foreach (var client in clients)
            {
                bank.AddClient(client);
            }


            Console.WriteLine($"Banco: {bank.BankName} ({bank.BankCode})");
            Console.WriteLine($"Total de clientes: {bank.Clients.Count}");

            foreach (var client in bank.Clients)
            {
                Console.WriteLine($"\n--- Informações do Cliente {client.FirstName} ---");
                Console.WriteLine($"Nome: {client.FirstName} {client.LastName}");
                Console.WriteLine($"CPF: {client.Cpf}");
                Console.WriteLine($"Data de Nascimento: {client.FormatBirthDate()}");
                Console.WriteLine($"Endereço: {client.Address}, {client.City} - {client.State}, {client.ZipCode}");
                Console.WriteLine($"Telefone: {client.Phone}");
                Console.WriteLine($"Email: {client.Email}");
                Console.WriteLine($"Salário: {client.FormatSalary()}");
                Console.WriteLine($"Tipo de Conta: {client.BankAccount.AccountType}");
                Console.WriteLine($"Número da Conta: {client.BankAccount.AccountNumber}");
                Console.WriteLine($"Agência: {client.BankAccount.Agency}");
                Console.WriteLine($"Saldo da Conta: {client.BankAccount.FormatBalance()}");

            }
        }
    }
}