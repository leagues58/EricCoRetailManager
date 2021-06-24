using ERMDataManager.Library.DataAccess;
using ERMDataManager.Library.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Web.Http;

namespace ERMDataManager.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        public List<User> GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();

            return data.GetUserById(userId);
        }
    }
}
