using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessing.Product
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllProducts();
    }
}
