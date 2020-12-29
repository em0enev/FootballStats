namespace Fs.Server.Services.Identity
{
    public interface IIdentityService
    {
        public string GenererateJwtToken(string secret, string userId);
    }
}
