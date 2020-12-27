namespace Fs.Server.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Player
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
