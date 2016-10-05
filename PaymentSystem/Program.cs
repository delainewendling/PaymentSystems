using System;

namespace PaymentSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var paymentType = args[0];
            if (paymentType == "p")
            {
                var paypal = new PayPalPayment
                {
                    Email = args[1],
                    Password = args[2],
                    Amount = Convert.ToDecimal(args[3])
                };
                Console.WriteLine(paypal.MakePayment());
            }
            if (paymentType == "c")
            {
                var credit = new CreditCardPayment
                {
                    CreditCardNumber = args[1],
                    Amount = Convert.ToDecimal(args[2])
                };
                Console.WriteLine(credit.MakePayment());
            }
            if (paymentType == "cash")
            {
                var cash = new Payment
                {
                    Amount = Convert.ToDecimal(args[1])
                };
                Console.WriteLine(cash.MakePayment());
            }
        }
    }
}
