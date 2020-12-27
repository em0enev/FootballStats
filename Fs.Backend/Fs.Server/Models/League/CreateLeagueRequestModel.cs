namespace Fs.Server.Models.League
{
    using System.ComponentModel.DataAnnotations;

    public class CreateLeagueRequestModel
    {
        [Required]
        public string Name { get; set; }
    }
}
