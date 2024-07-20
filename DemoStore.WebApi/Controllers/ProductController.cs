using DemoStore.WebApi;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoStore.WebApi
{
    [ApiController]
    [EntityValidation]
    [Route("api/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<Product?> GetAsync([FromQuery] int productId)
        {
            return _service.GetAsync(productId, HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<IEnumerable<Product>> GetListAsync()
        {
            return _service.GetListAsync(HttpContext.RequestAborted);
        }

        [HttpGet]
        public Task<PagedResult<Product>> GetPageAsync([FromQuery] PageParameter page)
        {
            return _service.GetPageAsync(page, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddAsync([FromBody] Product product)
        {
            return _service.AddAsync(product, HttpContext.RequestAborted);
        }

        [HttpPost]
        public Task<bool> AddRangeAsync([FromBody] IEnumerable<Product> products)
        {
            return _service.AddRangeAsync(products, HttpContext.RequestAborted);
        }

        [HttpPut]
        public Task<bool> UpdateAsync([FromBody] Product product)
        {
            return _service.UpdateAsync(product, HttpContext.RequestAborted);
        }

        [HttpDelete]
        public Task<bool> DeleteAsync([FromQuery] int productId)
        {
            return _service.DeleteAsync(productId, HttpContext.RequestAborted);
        }
    }
}
