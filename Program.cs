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

            foreach (var c in clients)
            {
                bank.AddClient(c);
            }

            Client client = Client.Login(clients);
            if (client == null)
            {
                Console.WriteLine("Não foi possível realizar o login.");
                return;
            }

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nSelecione uma opção:");
                Console.WriteLine("1 - Realizar Transação");
                Console.WriteLine("2 - Ver Histórico de Transações");
                Console.WriteLine("3 - Sair");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        ExecuteTransaction(client);
                        break;
                    case 2:
                        client.ShowTransactionHistory();
                        break;
                    case 3:
                        exit = true;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        public static void ExecuteTransaction(Client client)
        {
            Console.WriteLine("Selecione o tipo de transação:");
            Console.WriteLine("1 - Débito");
            Console.WriteLine("2 - Crédito");
            int transactionType = int.Parse(Console.ReadLine());

            Console.Write("Informe a descrição da transação: ");
            string description = Console.ReadLine();

            Console.Write("Informe o valor da transação: ");
            float value = float.Parse(Console.ReadLine());

            var transaction = new Transactions(client.TransactionHistory.Count + 1, client)
            {
                TransactionType = (TransactionType)transactionType,
                Description = description,
                Value = value
            };

            client.AddTransaction(transaction);

            if (transaction.TransactionType == TransactionType.Crédito)
            {
                client.BankAccount.Balance += value;
            }
            else if (transaction.TransactionType == TransactionType.Débito)
            {
                client.BankAccount.Balance -= value;
            }

            Console.WriteLine("Transação realizada com sucesso!");
        }
    }
}