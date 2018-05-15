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
        public DataTable getProvince()
        {
            DataTable dt = sql.getData("SELECT DISTINCT provinceid, name from Tinhthanh");
            return dt;
        }

        public DataTable getDistrictbyProvinceID(int provinceID)
        {
            DataTable dt = sql.getData("select * from Quanhuyen where provinceid =" + provinceID);
            return dt;
        }

        public DataTable getWardbyDistrictID(int districtID)
        {
            DataTable dt = sql.getData("select * from Phuongxa where districtid =" + districtID);
            return dt;
        }
    }
}