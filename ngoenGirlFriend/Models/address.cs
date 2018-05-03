using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ngoenGirlFriend.Models
{
    public class address
    {
        SqlConnection sql = new SqlConnection();
        public DataTable getProvinces()
        {
            DataTable dt = sql.getData("SELECT DISTINCT Tinhthanh.provinceid,name FROM Tinhthanh INNER JOIN girlFriend ON Tinhthanh.provinceid = girlFriend.gProvince");
            return dt;
        }
    }
}