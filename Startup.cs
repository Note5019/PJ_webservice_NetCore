using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using PJ_webservice_CRUD.Models;

namespace PJ_webservice_CRUD
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => {
                    var resolver = options.SerializerSettings.ContractResolver;
                    if (resolver != null) (resolver as DefaultContractResolver).NamingStrategy = null;
                    });
            services.AddDbContext<ProductContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddDbContext<CategoryContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddDbContext<SO_HeaderContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddDbContext<SO_DetailContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddDbContext<PO_HeaderContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddDbContext<PO_DetailContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options => 
                options.WithOrigins("")
                .AllowAnyHeader()
                .AllowAnyMethod());
            app.UseMvc();
        }
    }
}
