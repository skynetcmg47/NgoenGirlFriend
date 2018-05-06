using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngoenGirlFriend.Models
{
    public class Comment
    {
        SqlConnection sql = new SqlConnection();
        public void leaveComment(string userid,string girlid, string comment)
        {
            string query = String.Format("INSERT INTO comment(userId,girlFriendId,commentContent) VALUES({0},{1},N'{2}')", userid, girlid, comment);
            sql.excuteNonQuery(query); 
        }
    }
}