using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;
using ngoenGirlFriend.Bean;

namespace ngoenGirlFriend.Models
{
    public class GirlFriend
    {
        SqlConnection sql = new SqlConnection();

        ArrayList girls = new ArrayList();

        public DataTable searchGirlFriends(string sText)
        {
            DataTable dt = new DataTable();
            string query = String.Format("SELECT * from girlFriend where  gFullName  LIKE N'%{0}%'", sText);
            dt = sql.getData(query);
            return dt;
        }


        public DataTable getGirlFriends()
        {
            DataTable dt = new DataTable();
            dt = sql.getData("SELECT * from girlFriend");
            
            return dt;
        }

        internal DataTable getGirlImage(string id)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM imageurl WHERE girlFriendId = " + id;
            dt = sql.getData(query);
            return dt;
        }

        public DataTable getGirlFriendsByProvince(string provinceid)
        {
            DataTable dt = new DataTable();
            string query = String.Format("SELECT top(1) girlFriend.girlFriendId,girlFriend.gFullName,imageurl.imageurl,gStatus,rating,gNote, name,gBirthday from girlFriend inner join imageurl on " +
                                            "girlFriend.girlFriendId = imageurl.girlFriendId INNER JOIN Tinhthanh ON girlFriend.gProvince = Tinhthanh.provinceid WHERE  gProvince={0} " +
                                            " order by imageurl.imageId", provinceid);
            dt = sql.getData(query);
            return dt;
        }

        public DataTable searchGirlFriend(string search)
        {
            DataTable dt = new DataTable();
            string query = String.Format("SELECT top(1) girlFriend.girlFriendId,girlFriend.gFullName,imageurl.imageurl,gStatus,rating,gNote, name,gBirthday from girlFriend inner join imageurl on "+
                                            "girlFriend.girlFriendId = imageurl.girlFriendId INNER JOIN Tinhthanh ON girlFriend.gProvince = Tinhthanh.provinceid WHERE gFullName LIKE N'%{0}%' OR "+
                                            "name LIKE N'%{0}%' order by imageurl.imageId", search);
            dt = sql.getData(query);
            return dt;
        }


        public DataTable getGirlFriend(string id)
        {
            Bean.GirlFriend girl = new Bean.GirlFriend();
            string query = String.Format("SELECT girlFriendId,gFullName,gBirthday,gNote,gStatus,rating,ratingAmount,Phuongxa.name as ward ,Quanhuyen.name as district, Tinhthanh.name as province"
                                        + " FROM girlFriend INNER JOIN Phuongxa ON girlFriend.gWardid = Phuongxa.wardid"
                                        + " INNER JOIN Quanhuyen ON girlFriend.gDistrictid = Quanhuyen.districtid"
                                        + " INNER JOIN Tinhthanh ON girlFriend.gProvince = Tinhthanh.provinceid WHERE girlFriendId = {0}", id);
            DataTable dt = new DataTable();
            dt = sql.getData(query);
            /*girl.ID1 = dt.Rows[0]["girlFriendId"].ToString();
            girl.FullName = dt.Rows[0]["gFullName"].ToString();
            girl.BirthDate = dt.Rows[0]["gBirthday"].ToString();
            girl.Note = dt.Rows[0]["gNote"].ToString();*/
            //girl.Status = bool(dt.Rows[0]["gStatus"].ToString());
            return dt;
        }

        public DataTable getGirlComment(string id)
        {
            DataTable dt = new DataTable();
            string query = String.Format("SELECT TOP 10 fullname,imageurl,commentContent FROM accountUser INNER JOIN comment ON accountUser.userid = comment.userId WHERE girlFriendId={0}", id);
            dt = sql.getData(query);
            return dt;
        }

        public void deleteGirl(int id)
        {
            string query3 = "DELETE FROM comment WHERE girlFriendId=" + id;
            sql.excuteNonQuery(query3);
            string query2 = "DELETE FROM imageurl WHERE girlFriendId=" + id;
            sql.excuteNonQuery(query2);
            string query = "DELETE girlFriend where girlFriendId =" + id;
            sql.excuteNonQuery(query);
            
        }

        public int insertGirlFriend(string fullname, int wardid, int districtid, int provinceid, string phone, string email, string birthday, string note)
        {
            int result = -1;
            string query = "insert girlFriend(gFUllName, gWardid, gDistrictid, gProvince, gPhone, gEmail, gBirthday, gNote,gStatus,rating,ratingAmount)"
               + "values (N'" + fullname + "', '" + wardid + "', '" + districtid + "', '" + provinceid + "', '" + phone + "', '" + email + "', '" + birthday + "', N'" + note + "'"+",'True',"+10+","+1+") ";
            try
            {
                result = sql.excuteNonQuery(query);
            }
            catch (Exception) { }

            return result;
        }

        public int updateGirlFriend(int girlfriendID, string fullname, int wardid, int districtid, int provinceid, string phone, string email, string birthday, string note)
        {
            int result = -1;
            string query = "UPDATE girlFriend set gFUllName = N'" + fullname + "', gWardid = '" + wardid + "', gDistrictid = '" + districtid + "', gProvince = '" + provinceid + "',"
                + "gPhone = '" + phone + "', gEmail = '" + email + "', gBirthday = '" + birthday + "', gNote= N'" + note + "' where girlFriendID = " + girlfriendID;
            try
            {
                result = sql.excuteNonQuery(query);
            }
            catch (Exception) { }

            return result;
        }

        public DataTable getTopGirl()
        {
            return sql.getData("select * from girlFriend order by girlFriendId desc");
        }

        public DataTable getGirlbyID(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select * from girlFriend where girlFriendId =" + id;
                dt = sql.getData(query);

            }
            catch (Exception) { }

            return dt;
        }

    }
}