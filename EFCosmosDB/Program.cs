using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;

namespace EFCosmosDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //SETUP
            var options = GetCosmosDbOptions<TenantDbContext>();

            using var context = new TenantDbContext(options);


            //context.Database.EnsureDeletedAsync().ConfigureAwait(false);
            context.Database.EnsureCreated();

            context.Tenants.Add(new Entities.Tenant() { Id = Guid.NewGuid(), Name = "Rafael" });
            context.SaveChanges();

            //System.ArgumentException: 

            //    'Cannot specify ApplicationRegion and enable LimitToEndpoint. Only one can be set.'
        }

        public static DbContextOptions<TContext> GetCosmosDbOptions<TContext>()
            where TContext : DbContext
        {
            var builder = new DbContextOptionsBuilder<TContext>();

            builder
                .UseCosmos<TContext>(
                    "https://tenant.documents.azure.com:443/",
                    "eZq80pPFSqaVsQDqugWkk9SFYvQrD4nCYtKXSKS75QttHojXsb7NwsKM2dWdsCt7CC8ioaJa9xMs6T5F5xGRYA==",
                    databaseName: "Clients",

                    options =>
                    {
                        options.ConnectionMode(ConnectionMode.Direct);
                        //options.WebProxy(new WebProxy());
                        //options.LimitToEndpoint();
                        options.Region(Regions.AustraliaSoutheast);
                        options.GatewayModeMaxConnectionLimit(32);
                        options.MaxRequestsPerTcpConnection(8);
                        options.MaxTcpConnectionsPerEndpoint(16);
                        //options.IdleTcpConnectionTimeout(TimeSpan.FromMinutes(1));
                        options.OpenTcpConnectionTimeout(TimeSpan.FromMinutes(1));
                        options.RequestTimeout(TimeSpan.FromMinutes(1));
                    });

            //return (TContext)Activator.CreateInstance(typeof(TContext), builder.Options);
            return builder.Options;
        }
    }
}
