using GenericBankExercise.Entity;

namespace GenericBank
{
    public static class Program
    {
        public static void Main()
        {
            var client1 = new Client(1)
            {
                FirstName = "João",
                LastName = "Silva",
                BirthDate = new DateTime(1999, 3, 5),
                Address = "Rua Ciclana, 19",
                City = "São Paulo",
                State = "SP",
                ZipCode = "12345-678",
                Phone = "(11) 00000-4121",
                Email = "joao@gmail.com",
                Password = "123456",
                Balance = 0.0F,
                Salary = 1500.0F
            };

            Console.WriteLine($"Welcome to Generic Bank, {client1.FirstName}!");
            Console.WriteLine($"Your balance is {client1.FormatBalance()}.");
        }
    }
}