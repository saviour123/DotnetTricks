using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Mappers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TeamXidentity
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            string connStr = "User ID=sav;Password=sav;Host=localhost;Port=5432;Database=teamxidentity;Timeout=15;Pooling=True;MinPoolSize=1;MaxPoolSize=100;CommandTimeout=20;";
            var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;


            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                // .AddInMemoryApiResources(Config.GetApiResources())
                // .AddInMemoryClients(Config.GetClients());
                .AddTestUsers(Config.GetUsers())
                .AddConfigurationStore(options => 
                {
                    options.ConfigureDbContext = builder =>
                        builder.UseNpgsql(connStr, 
                        sql => sql.MigrationsAssembly(migrationsAssembly));
                })
                //  this adds the operational data from DB (codes, tokens, consents)
                .AddOperationalStore(options => {
                    options.ConfigureDbContext = builder => 
                        builder.UseNpgsql(connStr, 
                            sql  => sql.MigrationsAssembly(migrationsAssembly));

                        options.EnableTokenCleanup = true;
                        options.TokenCleanupInterval = 30;
                });
                
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            InitializeDatabase(app);
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseIdentityServer();
        }

        private void InitializeDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                serviceScope.ServiceProvider.GetRequiredService<PersistedGrantDbContext>().Database.Migrate();

                var context = serviceScope.ServiceProvider.GetRequiredService<ConfigurationDbContext>();

                context.Database.Migrate();
                if (!context.Clients.Any())
                {
                    foreach (var client in Config.GetClients())
                    {
                        context.Clients.Add(client.ToEntity());
                    }
                    context.SaveChanges();
                }

                if (!context.IdentityResources.Any())
                {
                    foreach (var resource in Config.GetIdentityResources())
                    {
                        context.IdentityResources.Add(resource.ToEntity());
                    }
                    context.SaveChanges();
                }

                if (!context.ApiResources.Any())
                {
                    foreach (var resource in Config.GetApiResources())
                    {
                        context.ApiResources.Add(resource.ToEntity());
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
