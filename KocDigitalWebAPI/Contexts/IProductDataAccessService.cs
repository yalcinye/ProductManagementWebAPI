using KocDigitalWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KocDigitalWebAPI.Contexts
{
    public interface IProductDataAccessService
    {
        void saveProduct(Product product);

        IEnumerable<Product> GetAllProduct();
    }
}
