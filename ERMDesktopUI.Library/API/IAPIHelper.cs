using ERMDesktopUI.Library.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace ERMDesktopUI.Library.API
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string userName, string password);
        Task GetLoggedInUserByInfo(string token);
    }
}