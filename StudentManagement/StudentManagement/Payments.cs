using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Payments
    {
        public DateTime Date { get; set; }
        public long Money { get; set; }
        public Payments(DateTime date, long money)
        {
            this.Date = date;
            this.Money = money;
        }
    }
}
