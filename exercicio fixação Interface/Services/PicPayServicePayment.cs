using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_fixação_Interface.Services
{
    class PicPayServicePayment : IServicePayment
    {
        public double paymentFee(double amount)
        {
            double acum = amount + (amount * (1 / 100));
            return acum +=  (acum * (2 / 100));
        }
        public double interest(double amount, int months)
        {
            return paymentFee(amount) * months;
        }
    }
}
