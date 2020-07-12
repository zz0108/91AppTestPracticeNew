using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _91AppTest2.Repository;
using _91AppTest2.ViewModels.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _91AppTest2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository<OrderListViewModels> _order;

        public OrdersController(IOrderRepository<OrderListViewModels> order)
        {
            _order = order;
        }

        [HttpGet("api/OrderGet")]
        public List<OrderViewModels> OrderGet()
        {
            var obj = _order.GetOrderProducts().Items;
            return obj;
        }
    }
}
