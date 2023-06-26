using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Balance_item
    {
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string? Title { get; set; }

        public Balance_item() { }   
        public Balance_item(DateTime date, int amount, string? title)
        {
            Date = date;
            Amount = amount;
            Title = title;
        }
    }
}
