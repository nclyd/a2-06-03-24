using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace booking_a2
{
    public class Database
    {
        private SqlCommand cmd;
        private SqlConnection conn;
        private SqlDataReader rdr;

        public SqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        public SqlDataReader Rdr
        {
            get { return rdr; }
            set { rdr = value; }
        }

        //Constructor
        public Database()
        {

        }

        public Database(SqlCommand _cmd, SqlConnection _conn, SqlDataReader _rdr)
        {
            cmd = _cmd;
            conn = _conn;
            rdr = _rdr;
        }

        public bool connect()
        {
            SqlConnectionStringBuilder scStrBuild = new SqlConnectionStringBuilder();

            scStrBuild.DataSource = "(LocalDB)\\MSSQLLocalDB";
            scStrBuild.AttachDBFilename = "|DataDirectory|dbManagement.mdf";
            scStrBuild.InitialCatalog = "dbManagement";
            scStrBuild.IntegratedSecurity = true;

            conn = new SqlConnection(scStrBuild.ToString());
            try { conn.Open(); }
            catch (SqlException sqlE) { Console.WriteLine(sqlE.Message); }

            if (conn.State == System.Data.ConnectionState.Open)
                return true;
            else
                return false;
        }




    }
}
