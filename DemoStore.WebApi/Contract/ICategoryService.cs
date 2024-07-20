using DemoStore.WebApi;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoStore.WebApi
{
    public interface ICategoryService : IEntityServiceBase<Category, int>
    {
    }
}
