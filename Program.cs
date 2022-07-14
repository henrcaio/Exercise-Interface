using System;
using System.Collections.Generic;
using Exercise_Interface.Entities;
using Exercise_Interface.Services;

namespace Exercise_Interface {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);
            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(myContract, months);
            
            Console.Clear();
            Console.WriteLine("Installments: ");
            foreach (var installment in myContract.Installments) {
                Console.WriteLine(installment);
            }


        }
    }
}
