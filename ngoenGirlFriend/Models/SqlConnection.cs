using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace ngoenGirlFriend.Models
{
    public class SqlConnection
    {
        string ketNoi = WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        System.Data.SqlClient.SqlConnection cnn = new System.Data.SqlClient.SqlConnection();
        DataTable dt;
        public SqlConnection()
        {
            cnn.ConnectionString = ketNoi;
        }
        public void Open()
        {
            if (cnn.State != ConnectionState.Open)
            {
                cnn.Open();
            }
        }
        public void Close()
        {
            if (cnn.State != ConnectionState.Closed)
            {
                cnn.Close();
            }
        }

        public int excuteNonQuery(string sql)
        {
            Open();
            SqlCommand comm = new SqlCommand(sql, cnn);
            int ketqua = comm.ExecuteNonQuery();
            Close();
            return ketqua;
        }

        public DataTable getData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}