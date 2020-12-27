namespace Fs.Server.Models.Identity
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterUserRequesModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
