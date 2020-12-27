namespace Fs.Server.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Team 
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int LeagueId { get; set; }
        public League League { get; set; }

        public IEnumerable<Player> Players { get; } = new HashSet<Player>();
    }
}
