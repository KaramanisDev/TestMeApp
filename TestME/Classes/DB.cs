using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TestME
{
    class DB
    {
        private MySqlConnection connect;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private string connectiondetails;
        private bool bConnected = false;
        private DataTable Table;
        private int affected_rows;
        private string squery;
        private List<string> parameters;

        public DB(string host, string user, string pass, string dbname)
        {
            connectiondetails = new StringBuilder("").AppendFormat("Server={0};Database={3};Uid={1};Pwd={2};", host, user, pass, dbname).ToString();
            Connect();
            Table = Table = new DataTable();
            parameters = new List<string>();
        }

        private void Connect()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectiondetails);
                connection.Open();
                connect = connection;
                bConnected = true;
            }
            catch (MySqlException ex)
            {
                string exception = "Exception : " + ex.Message.ToString() + " / " + squery;
                MessageBox.Show(exception, "Uncaught MYSQL Exception");
            }
        }

        public void CloseConn()
        {
            bConnected = false;
            connect.Close();
            connect.Dispose();
        }

        private void Init(string Query, string[] bindings = null)
        {
            // No connection with database? make connection
            if (bConnected == false)
            {
                Connect();
            }

            // Automatically disposes the MySQLcommand instance
            using (command = new MySqlCommand(Query, connect))
            {
                // 
                bind(bindings);

                // Prevents SQL injection
                if (parameters.Count > 0)
                {
                    parameters.ForEach(delegate (string parameter)
                    {
                        string[] sparameters = parameter.ToString().Split('\x7F');
                        command.Parameters.AddWithValue(sparameters[0], sparameters[1]);
                    });
                }

                this.squery = Query.ToLower();

                if (squery.Contains("select"))
                {
                    this.Table = execDatatable();
                }
                if (squery.Contains("delete") || squery.Contains("update") || squery.Contains("insert"))
                {
                    this.affected_rows = execNonquery();
                }

                // Clear thee parameters, 
                this.parameters.Clear();
            }
        }

        public void bind(string field, string value)
        {
            parameters.Add("@" + field + "\x7F" + value);
        }

        public void bind(string[] fields)
        {
            if (fields != null)
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    bind(fields[i], fields[i + 1]);
                    i += 1;
                }
            }
        }

        public void qBind(string[] fields)
        {
            if (fields != null)
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    bind(i.ToString(), fields[i]);
                }
            }
        }

        private DataTable execDatatable()
        {
            DataTable dt = new DataTable();
            try
            {
                reader = command.ExecuteReader();
                dt.Load(reader);
            }
            catch (MySqlException my)
            {
                string exception = "Exception : " + my.Message.ToString() + "\n\r SQL Query : \n\r" + squery;

                MessageBox.Show(exception, "Uncaught MYSQL Exception");
            }

            return dt;
        }

        private int execNonquery()
        {

            int affected = 0;

            try
            {
                affected = command.ExecuteNonQuery();
            }
            catch (MySqlException my)
            {
                string exception = "Exception : " + my.Message.ToString() + "\n\r SQL Query : \n\r" + squery;

                MessageBox.Show(exception, "Uncaught MYSQL Exception");
            }

            return affected;
        }

        public DataTable table(string table, string[] bindings = null)
        {
            Init("SELECT * FROM " + table, bindings);
            return this.Table;
        }

        public List<object> table(string table, Type t)
        {
            return new List<object>();
        }

        public DataTable query(string query, string[] bindings = null)
        {
            Init(query, bindings);
            return this.Table;
        }

        public int nQuery(string query, string[] bindings = null)
        {
            Init(query, bindings);
            return this.affected_rows;
        }

        public string single(string query, string[] bindings = null)
        {
            Init(query, bindings);

            if (Table.Rows.Count > 0)
            {
                return Table.Rows[0][0].ToString();
            }

            return string.Empty;
        }

        public string[] row(string query, string[] bindings = null)
        {
            Init(query, bindings);

            string[] row = new string[Table.Columns.Count];

            if (Table.Rows.Count > 0)
                for (int i = 0; i++ < Table.Columns.Count; row[i - 1] = Table.Rows[0][i - 1].ToString()) ;

            return row;
        }

        public List<string> column(string query, string[] bindings = null)
        {
            Init(query, bindings);

            List<string> column = new List<string>();

            for (int i = 0; i++ < Table.Rows.Count; column.Add(Table.Rows[i - 1][0].ToString())) ;

            return column;
        }
    }
}
