using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_fixação_Interface.Services
{
    class PicPayServicePayment : IServicePayment
    {
        public double tax(int amount)
        {
            double acum = (amount * (1 / 100)) + (amount * (2 / 100));
            return acum;
        }
    }
}
