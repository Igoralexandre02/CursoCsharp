using System;
using System.Collections.Generic;


namespace CursoCsharp.Service
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
            return amount * months * (1 / 100);
        }

        public double PaymentFee(double amount)
        {
            return amount * (2 / 100);
        }
    }
}
