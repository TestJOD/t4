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
            Controller.Controller c = new Controller.Controller();
            Dal d = new Dal();
            Console.WriteLine(d.TestarSql());
        }
        SqlConnection sc = new SqlConnection("Data Source=DAVID-PC;Integrated Security=SSPI;Initial Catalog=T4");
        //connection för David: Data Source=DAVID-PC;Integrated Security=SSPI;Initial Catalog=T4
        //connection för Jocke: 
        //connecton för Olle: 

        SqlCommand sqlString;

        public string TestarSql()
        {
            sc.Open();
            sqlString = new SqlCommand("insert into users values('Sara', 'Nilsson', 'email@gmail.com', '0707')", sc);
            sqlString.ExecuteNonQuery();
            sc.Close();
            return "Successfully registered";
        }
    }
}
