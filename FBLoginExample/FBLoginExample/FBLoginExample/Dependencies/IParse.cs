using System;
using System.Threading.Tasks;

namespace FBLoginExample.Dependencies
{
    public interface IParse
    {
        Task<bool> LoginWithFacebook(string userId, string accessToken, DateTime tokenExpiration);
    }
}
