using ERMDataManager.Library.Internal.DataAccess;
using ERMDataManager.Library.Models;
using System.Collections.Generic;

namespace ERMDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<User> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = Id };

            List<User> user = sql.LoadData<User, dynamic>("dbo.User_GetById", p, "ERMDatabase");

            return user;
        }
    }
}
