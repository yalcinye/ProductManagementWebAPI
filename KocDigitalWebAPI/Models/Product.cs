using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KocDigitalWebAPI.Models
{
    public class Product
    {
        [Key]
        public Guid productID { get; set; }
        /// <summary>
        /// product name
        /// </summary>
        public string productName { get; set; }

        /// <summary>
        /// product description
        /// </summary>
        public string productDescription { get; set; }

        /// <summary>
        /// price
        /// </summary>
        public double productPrice { get; set; }

        /// <summary>
        /// stock
        /// </summary>
        public int productStock { get; set; }
    }
}
