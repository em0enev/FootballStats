namespace Fs.Server.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Team 
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Guid LeagueId { get; set; }
        public League League { get; set; }

        public IEnumerable<Player> Players { get; } = new HashSet<Player>();
    }
}
