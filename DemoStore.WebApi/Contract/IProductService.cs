using DemoStore.WebApi;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoStore.WebApi
{
    public interface IProductService : IEntityServiceBase<Product, int>
    {
    }
}
