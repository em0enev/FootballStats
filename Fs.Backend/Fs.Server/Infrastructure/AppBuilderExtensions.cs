namespace Fs.Server.Infrastructure
{
    using Fs.Server.Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;

    public static class AppBuilderExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using (var services = app.ApplicationServices.CreateScope())
            {
                var dbContext = services.ServiceProvider.GetService<FsDbContext>();
               // dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
            }
        }
    }
}
