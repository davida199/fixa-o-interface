using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_fixação_Interface.Services
{
    class PicPayServicePayment : IServicePayment
    {
        private double taxJuroSimples = 0.01;
        private double taxPagamento = 0.02;
        public double paymentFee(double amount)
        {
            return amount * taxPagamento;
        }
        public double interest(double amount, int months)
        {
            return amount * taxJuroSimples * months;
        }
    }
}
