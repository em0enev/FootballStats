namespace Fs.Server.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Player
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public Guid TeamId { get; set; }
        public Team Team { get; set; }
    }
}
