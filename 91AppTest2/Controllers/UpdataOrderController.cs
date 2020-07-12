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
    public class UpdataOrderController : ControllerBase
    {
        private readonly IUpdataOrderRepository<OrderListViewModels> _updata;
        public UpdataOrderController(IUpdataOrderRepository<OrderListViewModels> updata)
        {
            _updata = updata;
        }
        [HttpPost("api/OrderPost")]
        public void OrderGet(string[] objjson)
        {
            _updata.UpdataOrder(objjson);
            _updata.SaveShipping(objjson);
        }
    }
}
