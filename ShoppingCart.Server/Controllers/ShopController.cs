using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ShoppingCart.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ShopController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        [Route("ProductList")]
        public string GetAllProducts()
        {
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("").ToString());
        }
    }
}
