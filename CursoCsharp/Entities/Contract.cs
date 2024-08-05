using System;
using System.Collections.Generic;

namespace CursoCsharp.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        List<Installment> installments = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public override string ToString()
        {
            foreach (var item in installments) {
                return "Installments: "
                    + item.DueDate 
                    + " - "
                    + item.Amount;
            }
            return "";
        }
    }
}
