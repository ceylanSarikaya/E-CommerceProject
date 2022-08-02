using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ProductCategoryManyRelationships
    {
        public int ProductCategoryId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product product { get; set; }
        public Category category { get; set; }
    }
}
