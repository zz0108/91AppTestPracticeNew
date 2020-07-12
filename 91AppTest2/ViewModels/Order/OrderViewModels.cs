using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _91AppTest2.ViewModels.Order
{
    public class OrderViewModels
    {
        public string Order_Id { get; set; }
        public string Order_Item { get; set; }
        public decimal Price { get; set; }
        public int Cost { get; set; }
        public string Status { get; set; }
        public string Product_Id { get; set; }
    }
}
