using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KocDigitalWebAPI.Contexts;
using KocDigitalWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KocDigitalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductDataAccessService _productDataAccess;

        public ProductController(IProductDataAccessService productDataAccess)
        {
            _productDataAccess = productDataAccess;
        }


        [HttpPost]
        [Route("createproduct")]
        public async Task<IActionResult> CreateProduct([FromBody]Product productModel)
        {
            try
            {
                _productDataAccess.saveProduct(productModel);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        [HttpGet]
        [Route("getallproduct")]
        public async Task<IActionResult> GetAllProduct()
        {
            try
            {
                return Ok(_productDataAccess.GetAllProduct());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
