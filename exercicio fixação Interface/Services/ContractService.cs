using System;
using System.Collections.Generic;
using System.Text;
using exercicio_fixação_Interface.Entities;
namespace exercicio_fixação_Interface.Services
{
    class ContractService
    {
        private IServicePayment _servicePayment;

        public ContractService(IServicePayment servicePayment)
        {
            _servicePayment = servicePayment;
        }

        public void processContract(Contract contract,int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _servicePayment.interest(basicQuota, i);
                double fullQuota = updatedQuota + _servicePayment.paymentFee(updatedQuota);
                contract.addInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
