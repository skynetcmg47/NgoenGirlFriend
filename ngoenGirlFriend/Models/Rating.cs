using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ngoenGirlFriend.Models
{
    public class Rating
    {
        SqlConnection sql = new SqlConnection();
        public void leaveRating(string girlid, string rating,string ratingAmount)
        {
            string query = String.Format("UPDATE girlFriend SET rating={0},ratingAmount={1} WHERE girlFriendId = {2}",rating,ratingAmount,girlid);
            sql.excuteNonQuery(query);
        }
    }
}