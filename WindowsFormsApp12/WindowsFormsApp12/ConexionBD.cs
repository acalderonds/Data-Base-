using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    public class OperacionesDB
    {
        public string ConnectionString { get; private set; }

        private SqlConnection connection;

        public OperacionesDB(string connString)
        {
            ConnectionString = connString;
            //connection = new SqlConnection(ConnectionString);
            connection = new SqlConnection() { ConnectionString = connString };
            //connection.ConnectionString = connString;
        }

        public DataTable Getinfo()
        {


            try
            {
                connection.Open();
                string query = "select * from [HumanResources].[Employee]";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                cmd.CommandTimeout = 1;
                SqlDataAdapter customerDA = new SqlDataAdapter();
                customerDA.SelectCommand = cmd;

                DataSet customerDS = new DataSet();
                customerDA.Fill(customerDS, "JobTitle");
                connection.Close();
                return customerDS.Tables[0];
            }
            catch (Exception ex) //Placeholder
            {
                throw ex;
            }


        }

        public List<string> BasesD()
        {
            connection.Open();
            List<string> listabd = new List<string>();
            string query = "select * from master.sys.databases";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listabd.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return listabd;

        }

        public List<string> DatosBDTablas(string name)/////////////Revisar como se esta conectando no muestra nada
        {
            connection.ConnectionString = "data source = HGDLAPCALDERONA\\SQLEXPRESS; " + "initial catalog=" + name + ";integrated security = true;user id=sa"; connection.Open();
            List<string> listabd = new List<string>();
            string query = "select * from [" + name + "].sys.tables";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listabd.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return listabd;
        }

        public List<string> DatosBDViews(string name)
        {
            connection.ConnectionString = "data source = HGDLAPCALDERONA\\SQLEXPRESS; " + "initial catalog=" + name + ";integrated security = true;user id=sa";
            connection.Open();
            List<string> listabd = new List<string>();
            string query = "select * from [" + name + "].sys.all_views";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listabd.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return listabd;
        }

        public List<string> DatosBDSP(string name)
        {
            connection.ConnectionString = "data source = HGDLAPCALDERONA\\SQLEXPRESS; " + "initial catalog=" + name + ";integrated security = true;user id=sa";
            connection.Open();
            List<string> listabd = new List<string>();
            string query = "select * from [" + name + "].sys.procedures";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listabd.Add(reader.GetString(0));
            }
            reader.Close();
            connection.Close();
            return listabd;
        }

    }

}


