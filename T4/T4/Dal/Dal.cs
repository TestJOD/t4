using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace T4.Dal
{
    class Dal
    {
        public static void Main() //detta fungerar! Hurra!!
        {
            Dal d = new Dal();
            Console.WriteLine(d.TestarSql());
        }
        SqlConnection sc = new SqlConnection("Data Source=DAVID-PC;Integrated Security=SSPI;Initial Catalog=T4");
        SqlCommand cmd;

        public string TestarSql()
        {
            sc.Open();
            cmd = new SqlCommand("Insert into whore values('Kenny')", sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            return "Success";
        }
    }
}
