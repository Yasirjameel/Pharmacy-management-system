using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Yasir
{
   public class Class
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }
        public int ProductQty { get; set; }
        public decimal ProductPrice { get; set; }
        public int DiscountPercent { get; set; }

        public string Total { get { return string.Format("{0}", (ProductPrice * ProductQty)); } }

        public decimal DiscountAmount { get { return (DiscountPercent * Convert.ToDecimal(Total)) / 100; } }
        public decimal DiscountTotal { get { return Convert.ToDecimal(Total) - DiscountAmount; } }

        public decimal RecieptTotal { get { return ProductQty * ProductPrice; } }

    }
}
