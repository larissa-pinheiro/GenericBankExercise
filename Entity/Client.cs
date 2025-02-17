using System.Globalization;

namespace GenericBankExercise.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Cpf { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float Salary { get; set; }
        public BankAccount BankAccount { get; set; }
        public List<Transactions> TransactionHistory { get; set; }

        public Client(int id)
        {
            Id = id;
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDate = DateTime.MinValue;
            Cpf = string.Empty;
            Address = string.Empty;
            City = string.Empty;
            State = string.Empty;
            ZipCode = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Salary = 0.0F;
            BankAccount = new BankAccount();
            TransactionHistory = new List<Transactions>();
        }

        public void AddTransaction(Transactions transaction)
        {
            TransactionHistory.Add(transaction);
        }

        public void ShowTransactionHistory()
        {
            foreach (var transaction in TransactionHistory)
            {
                Console.WriteLine($"Histórico de transações de {FirstName} {LastName}:");
                Console.WriteLine($"Id: {transaction.Id}");
                Console.WriteLine($"Data: {transaction.FormatTransactionDate()}");
                Console.WriteLine($"Tipo: {transaction.TransactionType}");
                Console.WriteLine($"Descrição: {transaction.Description}");
                Console.WriteLine($"Valor: {transaction.FormatTransactionValue()}");
            }
        }

        public static Client Login(List<Client> clients)
        {
            Console.Write("Informe o CPF no formato XXX.XXX.XXX-XX: ");
            string cpf = Console.ReadLine();
            Console.Write("Informe a senha de 6 dígitos: ");
            string password = Console.ReadLine();

            var client = clients.FirstOrDefault(c => c.Cpf == cpf && c.Password == password);
            if (client != null)
            {
                Console.WriteLine("Login bem-sucedido!");
                return client;
            }
            else
            {
                Console.WriteLine("CPF ou senha inválidos.");
                return null;
            }
        }


        public string FormatBirthDate()
        {
            return BirthDate.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"));
        }

        public string FormatSalary()
        {
            return Salary.ToString("C", new CultureInfo("pt-BR"));
        }
    }
}
