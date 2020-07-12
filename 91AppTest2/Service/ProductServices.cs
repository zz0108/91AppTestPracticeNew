using _91AppTest2.Repository;
using _91AppTest2.ViewModels.Product;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _91AppTest2.Service
{
    public class ProductServices : IProductRepository<ProductListViewModels>
    {
        private readonly IConfiguration _configuration;
        public ProductServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ProductListViewModels GetProducts(string ProductId)
        {
            var result = new ProductListViewModels();

            using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("91AppTest")))
            {
                string sql = $@"select * from Product_Table p where p.Product_Id = N'{ProductId}'";
                var GetProducts = conn.Query<ProductViewModels>(sql).ToList();
                result.Items = GetProducts;
                return result;
            }
        }
    }
}
