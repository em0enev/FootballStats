namespace Fs.Server.Data
{
    using Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class FsDbContext : IdentityDbContext<User>
    {
        public FsDbContext(DbContextOptions<FsDbContext> options)
            : base(options)
        {
        }
    }
}
