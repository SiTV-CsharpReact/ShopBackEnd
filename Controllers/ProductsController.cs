using Microsoft.AspNetCore.Mvc;
using ShopBackEnd.Data;
using ShopBackEnd.Entities;

namespace ShopBackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext context;

        public ProductsController(StoreContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            var products = context.Products.ToList();
            return Ok(products);
        }
        [HttpGet("{id}")] // api product id
        public ActionResult<Product> GetProduct(int id)
        {
            return context.Products.Find(id);

        }
    }
}
