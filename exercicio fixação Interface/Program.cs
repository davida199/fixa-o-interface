using System;
using exercicio_fixação_Interface.Services;
using exercicio_fixação_Interface.Entities;
using System.Globalization;
namespace exercicio_fixação_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract c1 = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PicPayServicePayment());
            contractService.processContract(c1, installments);

            Console.WriteLine("Installments");
            foreach (Installment installment in c1.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
