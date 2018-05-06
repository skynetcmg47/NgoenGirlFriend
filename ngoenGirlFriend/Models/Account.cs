using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace ngoenGirlFriend.Models
{
    public class Account
    {
        SqlConnection sql = new SqlConnection();
        
        Bean.User user = new Bean.User();
        public int checkLogin(string username,string password)
        {
            string query = String.Format("SELECT fullname,imageurl,roleId,userid FROM accountUser WHERE username = '{0}' AND password ='{1}'", username, password);
            DataTable dt = sql.getData(query);
            if (dt.Rows.Count > 0)
            {
                user.FullName1 = dt.Rows[0][0].ToString();
                user.ImageUrl = dt.Rows[0][1].ToString();
                user.Userid = dt.Rows[0]["userid"].ToString();
                return int.Parse(dt.Rows[0][2].ToString());
            }
            return -1;            
        }
        public Bean.User getUserSession()
        {
            return user;
        }

        public DataTable getUserById(string id)
        {
            DataTable dt = new DataTable();
            string query = String.Format("SELECT fullname,imageurl,email,phone FROM accountUser  WHERE userid={0}", id);
            dt = sql.getData(query);
            return dt;
        }
    }
}