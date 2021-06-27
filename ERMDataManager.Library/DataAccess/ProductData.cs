using ERMDataManager.Library.Internal.DataAccess;
using ERMDataManager.Library.Models;
using System.Collections.Generic;

namespace ERMDataManager.Library.DataAccess
{
    public class ProductData
    {
        public List<Product> GetProducts()
        {
            SqlDataAccess sql = new SqlDataAccess();

            var results = sql.LoadData<Product, dynamic>("dbo.Product_GetAll", new { }, "ERMDatabase");

            return results;
        }
    }
}
