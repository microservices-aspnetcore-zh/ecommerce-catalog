using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Steeltoe.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Linq;
using StatlerWaldorfCorp.EcommerceCatalog.Persistence;

namespace StatlerWaldorfCorp.EcommerceCatalog
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }
        
        public Startup(IHostingEnvironment env)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductRepository, MemoryProductRepository>();            
        }

        public void Configure(IApplicationBuilder app)
        {
        }                       
    }
}