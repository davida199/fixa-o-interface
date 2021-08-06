using System;
using System.Collections.Generic;
using System.Text;
using exercicio_fixação_Interface.Services;

namespace exercicio_fixação_Interface.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double amount { get; set; }
    }
}
