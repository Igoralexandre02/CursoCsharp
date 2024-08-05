using System;
using System.Collections.Generic;
using System.IO.Pipes;
using CursoCsharp.Entities;

namespace CursoCsharp.Service
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            var baseValue = contract.TotalValue / months;

            DateTime dateInstallment;
            for (int i = 1; i <= months; i++)
            {
               dateInstallment = contract.Date.AddMonths(1);
            }
            
        }
    }
}
