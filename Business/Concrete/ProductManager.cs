using Business.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductService _productService;

        public ProductManager(IProductService productService)
        {
            _productService = productService;
        }

        public void AddProduct(Product product)
        {
            _productService.AddProduct(product);
        }

        public void DeleteProduct(Product product)
        {
            _productService.DeleteProduct(product); 
        }

        public Product GetProduct(int id)
        {
       return   _productService.GetProduct(id);
        }

        public List<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        public void UpdateProduct(Product product)
        {
            _productService.UpdateProduct(product); 
        }
    }
}
