using Dapper;
using DapperDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace DapperDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IConfiguration _config;

        public ProductController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet]
        public ActionResult<List<Product>> GetAllProduct()
        {
            var connectionstring = _config.GetConnectionString("DefaultConnectionString");
            using var connection = new SqlConnection(connectionstring);
            var products = connection.Query<Product>("Select * from dbo.products");
            return Ok(products);

        }
        
        [HttpPost]
        public ActionResult<Product> AddProduct(Product sampleproduct)
        {
            var connectionstring = _config.GetConnectionString("DefaultConnectionString");
            using var connection = new SqlConnection(connectionstring);
            connection.Execute("insert into dbo.products (productname) values (@productname)",sampleproduct);
            return Ok(sampleproduct);
        }

        [HttpDelete]

        public ActionResult<Product> RemoveProduct(Product sample)
        {
            var connectionstring = _config.GetConnectionString("DefaultConnectionString");
            using var connection = new SqlConnection(connectionstring);
            connection.Execute("delete from dbo.products where productid= @productid", sample);
            return Ok("Product deleted");

        }
    }
}
