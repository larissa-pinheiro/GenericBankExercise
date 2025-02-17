using System.Globalization;

namespace GenericBankExercise.Entity
{
    public enum AccountType
    {
        ContaCorrente = 1,
        ContaPoupanca = 2
    }

    public class BankAccount
    {     
        public string AccountNumber { get; set; }
        public string Agency { get; set; }
        public AccountType AccountType { get; set; }
        public float Balance { get; set; }
                
        public BankAccount()
        {
            AccountNumber = string.Empty;
            Agency = string.Empty;
            AccountType = AccountType.ContaCorrente;
            Balance = 0.0F;
        }

        public string FormatBalance()
        {
            return Balance.ToString("C", new CultureInfo("pt-BR"));
        }
    }
}
