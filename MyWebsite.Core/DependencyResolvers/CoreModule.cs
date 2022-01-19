using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyWebsite.Core.CrossCuttingConcerns.Caching;
using MyWebsite.Core.CrossCuttingConcerns.Caching.Microsoft;
using MyWebsite.Core.Utilities.IoC;

namespace MyWebsite.Core.DependencyResolvers
{
    public class CoreModule :ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}
