using Data.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
    public class EfCoreProductRepository:EfCoreGenericRepository<Product, ECommerceDbContext>,IProductRepository
    {
    }
}
