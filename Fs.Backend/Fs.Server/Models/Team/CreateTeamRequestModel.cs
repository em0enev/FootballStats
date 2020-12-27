namespace Fs.Server.Models.Team
{
    using System.ComponentModel.DataAnnotations;

    public class CreateTeamRequestModel
    {
        [Required]
        public string TeamName { get; set; }

        [Required]
        public string LeagueName { get; set; }
    }
}
