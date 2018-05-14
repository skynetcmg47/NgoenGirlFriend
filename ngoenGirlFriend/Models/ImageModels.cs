using ngoenGirlFriend.Bean;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ngoenGirlFriend.Models
{
    public class ImageModels
    {
        SqlConnection sql = new SqlConnection();

        public void insertArrayImage(int girlfriendid, List<string> image)
        {
            foreach(string img in image)
            {
                sql.excuteNonQuery("insert imageurl(girlFriendID, imageurl) values ('"+ girlfriendid + "', '"+img+"')");
            }
        }

        public int insertImage(Image image)
        {
            return sql.excuteNonQuery("insert imageurl(girlFriendID, imageurl) values('"+ image.GirlFriendID+ "', '"+ image.Imageurl+"')");
        }

        public void insert(int girlfriendid, string imageurl)
        {
            sql.excuteNonQuery("insert imageurl(girlFriendID, imageurl) values('"+ girlfriendid+ "', '"+ imageurl + "')");
        }

        public int deleteImagebyGirlFriendID(int girlfriendID)
        {
            int result = -1;
            try
            {
                result = sql.excuteNonQuery("delele imageurl where girlFriendID=" + girlfriendID);
            }
            catch (Exception)
            {

            }
            return result;
        }

        public List<string> getListImagebyGFID(int girlfriendID)
        {
            List<string> list = new List<string>();

            string query = "select * from imageurl where girlfriendId ="+ girlfriendID;

            DataTable data = sql.getData(query);

            foreach (DataRow item in data.Rows)
            {
                string im = item["imageurl"].ToString();
                list.Add(im);
            }

            return list;
        }

        public DataTable getImagebyGFId(int id)
        {
            return sql.getData("select * from imageurl where girlFriendId= "+id);
        }

        public void deleteImagebyimgId(int id)
        {
            sql.excuteNonQuery("DELETE imageurl where imageId ="+id);
        }
    }
}