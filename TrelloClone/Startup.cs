using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TrelloClone.Data;
using TrelloClone.Infrastructure;
using TrelloClone.Services;

namespace TrelloClone
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<BoardService>();
            services.AddScoped<CardService>();

            services.AddIdentity<AppUser, IdentityRole<Guid>>();

            services.AddMvc(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var connection = @"Server=(localdb)\mssqllocaldb;Database=TrelloClone;Trusted_Connection=True;ConnectRetryCount=0";

            services.AddDbContext<TrelloCloneDbContext>(options =>
                options.UseSqlServer(connection));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseHttpsRedirection();
            app.UseMvcWithDefaultRoute();
        }
    }
}
