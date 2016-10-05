using System;

namespace PaymentSystem
{
    public class Payment
    {
      public decimal Amount{get; set;}

      //When you're setting this up you write virtual because you know it will be overwritten by someone like Paypal or Visa. You can use override and overload with virtual
      public virtual string MakePayment()
      {
        //TODO hit the payment processing API
        return $"You paid ${this.Amount} in Cash";
      } 

      public string sendConfirmation(string email)
      {
        return "You purchased several nice items";
      }

      public string sendConfirmation(string email, bool digitalDownload)
      {
        return "You purchased several nice items";
      }
    }
}