using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _91AppTest2.Repository
{
    public interface IUpdataOrderRepository<T> where T : class
    {
        void UpdataOrder(string[] objjson);
        void SaveShipping(string[] objjson);
    }
}
