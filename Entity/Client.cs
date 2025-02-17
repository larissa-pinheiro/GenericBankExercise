using System.Globalization;

namespace GenericBankExercise.Entity
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float Balance { get; set; }
        public float Salary { get; set; }

        public Client(int Id)
        {
            this.Id = Id;
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDate = DateTime.MinValue;
            Address = string.Empty;
            City = string.Empty;
            State = string.Empty;
            ZipCode = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Balance = 0.0F;
            Salary = 0.0F;
        }

        public string FormatBirthDate()
        {
            return BirthDate.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"));
        }

        public string FormatBalance()
        {
            return Balance.ToString("C", new CultureInfo("pt-BR"));
        }

        public string FormatSalary()
        {
            return Salary.ToString("C", new CultureInfo("pt-BR"));
        }
    }
}
