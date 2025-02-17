using System.Globalization;

namespace GenericBankExercise.Entity
{
    public enum TransactionType
    {
        Débito = 1,
        Crédito = 2
    }

    public class Transactions
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public DateTime Date { get; set; }
        public TransactionType TransactionType { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }

        public Transactions(int id, Client client)
        {
            Id = id;
            Client = client;
            Date = DateTime.Now;
            TransactionType = TransactionType.Crédito;
            Description = string.Empty;
            Value = 0.0F;
        }

        public string FormatTransactionDate()
        {
            return Date.ToString("g", new CultureInfo("pt-BR"));
        }

        public string FormatTransactionValue()
        {
            return Value.ToString("C", new CultureInfo("pt-BR"));
        }
    }
}
