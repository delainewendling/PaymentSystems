using System;

namespace PaymentSystem
{
  //In order to derive from the base class of Payment we need to write :Payment after this class. Here we're hooking up that connection.
  public class PayPalPayment:Payment
  {
    public string Email{get; set;}
    public string Password{get; set;}
    //This is the function that's going to override the MakePayment method in the Payment class when PayPal is the payment provider

    //When you are overriding a method, the signature has to be the same, meaning the number and type of arguments has to be the same
    public override string MakePayment()
    {
      string message = String.Empty;
      if (this.Amount > 0 && this.Password != null)
      {
        return $"Your payment of ${this.Amount} has been processed by PayPal";
      } else {
        return "There has been an error and your payment was not processed";
      }
    }
  }
}