namespace Fs.Server.Controllers
{
    using Fs.Server.Data;
    using Fs.Server.Data.Models;
    using Fs.Server.Models.Team;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using System.Threading.Tasks;

    public class TeamController : ApiController
    {
        private readonly FsDbContext context;

        public TeamController(FsDbContext context)
        {
            this.context = context;
        }

        [Authorize]
        [Route(nameof(CreateTeam))]
        public async Task<ActionResult<int>> CreateTeam(CreateTeamRequestModel model)
        {
            var leagueFromDb = this.context
                .Leagues
                .Where(l => l.Name == model.LeagueName)
                .FirstOrDefault();

            var teamFromDb = this.context
                .Teams
                .Where(t => t.Name == model.TeamName)
                .FirstOrDefault();

            if (leagueFromDb == null)
            {
                return NotFound("The league does not exist");
            }

            if (teamFromDb != null)
            {
                return Conflict("The team already exist");
            }

            var team = new Team
            {
                LeagueId = leagueFromDb.Id,
                Name = model.TeamName
            };

            await this.context.AddAsync(team);

            return await this.context.SaveChangesAsync();
        }
    }
}
