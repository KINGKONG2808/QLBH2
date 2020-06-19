using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QL_BanHang.DAL
{
    class DataConnect
    {
        public SqlConnection getConnect()
        {
            //(TUNG) Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QL_BanHang;Integrated Security=True
            //(HUNG) Data Source=VUHUNGA49E;Initial Catalog=QL_BANHANG2;Integrated Security=True
            //(HIEU) Data Source=DESKTOP-MVH8GU2;Initial Catalog=QL_BanHang;Integrated Security=True
            //(YEN) Data Source=ADMIN;Initial Catalog=QL_BANHANG2;Integrated Security=True
            
<<<<<<< HEAD
<<<<<<< HEAD
            return new SqlConnection(@"Data Source=ADMIN;Initial Catalog=QL_BANHANG2;Integrated Security=True");
=======
            return new SqlConnection(@"null");
>>>>>>> 3eed25adc376d9501900b633f8586a594143de7d
=======
            return new SqlConnection(@"null");
>>>>>>> 3eed25adc376d9501900b633f8586a594143de7d

        }

        public DataTable GetTable(string sql)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return (dt);
        }

        public bool GetTaiKhoan(string sql)
        {
            SqlConnection con = getConnect();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataReader da = cmd.ExecuteReader();
            if (da.Read() == true)
                return true;
            return false;
        }

        public void ExcuteNonQuery(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }

        public int ExecuteScalar(string sql)
        {
            int x;
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                x = (int)cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                x = -1;
            }
            if (x > 0)
                return x;
            else
                return 0;
        }
    }
}
