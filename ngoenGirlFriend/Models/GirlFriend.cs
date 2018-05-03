using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data;

namespace ngoenGirlFriend.Models
{
    public class GirlFriend
    {
        SqlConnection sql = new SqlConnection();
        
        ArrayList girls = new ArrayList();
        public DataTable getGirlFriends()
        {
            DataTable dt = new DataTable();
            dt = sql.getData("SELECT * FROM girlFriend");
            /* for(int i=0;i<dt.Rows.Count;i++)
             {
                 Bean.GirlFriend girl = new Bean.GirlFriend();
                 girl.ID1 = dt.Rows[0][0].ToString();
                 girl.FullName = dt.Rows[0][1].ToString();
                 girl.Phone = dt.Rows[0][5].ToString();
                 girl.BirthDate = dt.Rows[0][7].ToString();
                 girl.Note = dt.Rows[0][8].ToString();
                 girls.Add(girl);
             }
             return girls;*/
            return dt;
        }
    }
}