using System;

namespace PaymentSystem
{
  public class CreditCardPayment:Payment
  {
    public string CreditCardNumber{get; set;}
    public override string MakePayment()
    {
      if (this.Amount>0 && this.CreditCardNumber!=null)
      {
        return $"You paid ${this.Amount} with a Credit Card";
      } else {
        return "There was an error, your payment was not processed";
      }
    }
  }
}