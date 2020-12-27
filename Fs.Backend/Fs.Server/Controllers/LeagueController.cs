namespace Fs.Server.Controllers
{
    using Fs.Server.Data;
    using Fs.Server.Data.Models;
    using Fs.Server.Models.League;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class LeagueController : ApiController
    {
        private readonly FsDbContext context;

        public LeagueController(FsDbContext context)
        {
            this.context = context;
        }

        [Authorize]
        [Route(nameof(CreateLeague))]
        public async Task<ActionResult<int>> CreateLeague(CreateLeagueRequestModel model)
        {
            var league = new League
            {
                Name = model.Name
            };

            await this.context
                .Leagues
                .AddAsync(league);

            return await this.context.SaveChangesAsync();
        }

        [Authorize]
        [Route(nameof(Test))]
        public ActionResult Test()
        {
            return this.Ok("Testa bachka");
        }
    }
}
