using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
        void AddProduct(Product product);
    }
}
