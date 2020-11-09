using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace OffRoadVietNam.DAL.Implement
{
    public class BaseRepository
    {
        protected IDbConnection connection;
        public BaseRepository()
        {
            connection = new SqlConnection(@"Data Source=hongson\sqlexpress;Initial Catalog=OffRoadVietNamDb;Integrated Security=True");
        }
    }
}
