using Microsoft.AspNetCore.Mvc;

namespace Api.GRRInnovations.Hybrid.Cache.Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetProductsAsync([FromQuery] ProductFilter filter)
        {
            var cacheKey = $"products:cat:{filter.Category}:min:{filter.MinPrice}:max:{filter.MaxPrice}";

            var products = await _hybridCacheService.GetOrCreateAsync(
                cacheKey,
                TimeSpan.FromMinutes(10),
                () => _productRepository.GetFilteredAsync(filter)
            );

            return Ok(products);
        }
    }
}
