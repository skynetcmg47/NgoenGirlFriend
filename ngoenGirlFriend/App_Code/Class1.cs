using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    SqlConnection ketNoi; 

    public Class1()
    {
      ketNoi=  new SqlConnection(@"Data Source=DESKTOP-80TMQVU\SQLEXPRESS;Initial Catalog=ngoenGirlFriend;Integrated Security=True");

    }
    public int getMKCU(string s)
    {
        ketNoi.Open();
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM accountUser WHere password like @pass", ketNoi);
        cmd.Parameters.Add(new SqlParameter("@pass", s));
        Object value = cmd.ExecuteScalar();
        int re = 0;
        if(value!=null)
        {
            re = Int32.Parse(value.ToString());

        }
        ketNoi.Close();
        return re;

    }
}