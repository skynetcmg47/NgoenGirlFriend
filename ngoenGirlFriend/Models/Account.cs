using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Data;
using ngoenGirlFriend.Bean;

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
            string query = String.Format("SELECT * FROM accountUser  WHERE userid={0}", id);
            dt = sql.getData(query);
            return dt;
        }

        //***********************************************//
        public void deleteUser(int id)
        {
            string query = String.Format("DELETE accountUser where userid = '{0}'", id);
            sql.excuteNonQuery(query);
        }

        public void deleteCommentByUser(int id)
        {
            string query = String.Format("DELETE comment where userId = '{0}'", id);
            sql.excuteNonQuery(query);
        }

        public bool checkCommentByUser(int id)
        {
            DataTable dt = new DataTable();
            string query = String.Format("SELECT * FROM comment WHERE userId = '{0}'", id);
            dt = sql.getData(query);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public int insertUser(string username, string password, string fullname, string phone, string imageurl, string email, int roleId, int uWardid, int uDistrictid, int uProvinceid, string birthdate)
        {
            int result = -1;
            string query = String.Format("insert into accountUser(username, password, fullname, phone, imageurl, email, roleId, uWardid, uDistrictid, uProvinceid, birthdate)"
               + "values ('" + username + "', '" + password + "', '" + fullname + "', '" + phone + "', '" + imageurl + "', '" + email + "', '" + roleId + "', '" + uWardid + "', '" + uDistrictid + "', '" + uProvinceid + "', '" + birthdate + "') ");

            result = sql.excuteNonQuery(query);
            return result;
        }

        public int updateUser(int id, string password, string fullname, string phone, string imageurl, string email, int roleId, int uWardid, int uDistrictid, int uProvinceid, string birthdate)
        {
            int result = -1;
            string query = String.Format("UPDATE accountUser set password = '" + password + "', fullname = '" + fullname + "', phone = '" + phone + "',"
                + "imageurl = '" + imageurl + "', email = '" + email + "', roleId = '" + roleId + "', uWardid= '" + uWardid + "', uDistrictid= '" + uDistrictid + "', uProvinceid= '" + uProvinceid + "', birthdate= '" + birthdate + "' where userid = '{0}'", id);
            
            result = sql.excuteNonQuery(query);
            return result;
        }

        public int getUserID(string username, string fullname, string email)
        {
            string query = "select * from accountUser where username='" + username+"'";
            DataTable user = sql.getData(query);
            int userid = int.Parse(user.Rows[0]["userid"].ToString());
            return userid;
        }

        public DataTable searchUsers(string sText)
        {
            DataTable dt = new DataTable();
            string query = String.Format("SELECT * from accountUser where  username LIKE N'%{0}%'", sText);
            dt = sql.getData(query);
            return dt;
        }

        public DataTable getUsers()
        {
            DataTable dt = new DataTable();
            dt = sql.getData("SELECT * FROM accountUser");            
            return dt;
        }

        public DataTable getRole()
        {
            DataTable dt = new DataTable();
            dt = sql.getData("SELECT * from accountRole");
            return dt;
        }
        public bool checkUserName(string name)
        {
            DataTable dt = new DataTable();
            
                string query = String.Format("SELECT * FROM accountUser WHERE username = '{0}'", name);
                dt = sql.getData(query);
                if (dt.Rows.Count > 0)
                    return true;             
           
            return false;
        }


    }
}