using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_fixação_Interface.Services
{
    interface IServicePayment
    {
        public double paymentFee(double amount);
        public double interest(double amount, int months);
    }
}
