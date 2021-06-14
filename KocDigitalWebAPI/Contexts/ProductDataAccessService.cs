using KocDigitalWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KocDigitalWebAPI.Contexts
{
    public class ProductDataAccessService : IProductDataAccessService
    {
        public IEnumerable<Product> GetAllProduct()
        {
            using (var context = new ProductDbContext())
            {
                return context.ProductData.ToList();
            }
           
        }

        public void saveProduct(Product product)
        {
            using (var context = new ProductDbContext())
            {
                context.Add<Product>(product);
                context.SaveChanges();
            }

           // throw new NotImplementedException();
        }
    }
}
