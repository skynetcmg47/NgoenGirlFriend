using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ngoenGirlFriend.Bean
{
    public class Image
    {
        string imageurl;
        int girlFriendID;

        public Image(int girlFriendID, string imageurl)
        {
            this.GirlFriendID = girlFriendID;
            this.Imageurl = imageurl;
        }
        public Image(DataRow row)
        {
            this.GirlFriendID = int.Parse(row["girlFriendId"].ToString());
            this.Imageurl = row["imageurl"].ToString();
        }

        public string Imageurl
        {
            get
            {
                return imageurl;
            }

            set
            {
                imageurl = value;
            }
        }

        public int GirlFriendID
        {
            get
            {
                return girlFriendID;
            }

            set
            {
                girlFriendID = value;
            }
        }
    }
}