﻿namespace Fs.Server.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class League
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IEnumerable<Team> Teams { get; } = new HashSet<Team>();

        public int NumberOfTeams { get => this.Teams.Count(); }
    }
}