namespace Fs.Server.Controllers
{
    using Fs.Server.Data;
    using Fs.Server.Data.Models;
    using Fs.Server.Models.League;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
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
            var leagueFromDb = context
                .Leagues
                .Where(x => x.Name == model.Name)
                .FirstOrDefault();

            if (leagueFromDb != null)
            {
                return Conflict("The league already exist !");
            }

            var league = new League
            {
                Name = model.Name
            };

            await this.context
                .Leagues
                .AddAsync(league);

            return await this.context.SaveChangesAsync();
        }
    }
}
