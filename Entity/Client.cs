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
