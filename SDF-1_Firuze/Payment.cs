using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDF_1_Firuze
{
    public class Payment
    {
        public string Title { get; set; }
        public double Amount { get; set; }

        public Payment(string title, double amount)
        {
            Title = title;
            Amount = amount;
        }
    }
}