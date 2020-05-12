using System;

namespace CSEFTPCStrategyCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var context = new Context())
                {
                    context.Database.EnsureCreated();

                    BankAccount bankAccount = new BankAccount()
                    {
                        BankName = "MasterCard",
                        Owner = "Zsombor"
                    };
                    CreditCard creditCard = new CreditCard()
                    {
                        CardType = 2
                    };

                    context.BankAccounts.Add(bankAccount);
                    context.CreditCards.Add(creditCard);

                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
