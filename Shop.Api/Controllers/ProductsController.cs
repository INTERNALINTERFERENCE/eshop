using Microsoft.AspNetCore.Mvc;

namespace Shop.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "list of products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return $"{id} product";
        }
    }
}