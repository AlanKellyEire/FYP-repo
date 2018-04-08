using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_10_2_18
{
    class DatabaseIO
    {
        private SQLiteConnection dbconn;
        //private const string DataSource = "Data Source=C:\\Users\\Grim\\source\\repos\\FYP\\nodesDB.db;";
        //private const string DataSource = "Data Source=C:\\Users\\Grim\\source\\repos\\FYP\\nodesDB.db;";
        //string DataSource = "Data Source=" + System.Reflection.Assembly.GetEntryAssembly().Location;
        string DataSource = "Data Source=.\\nodesDB.db;";

        private const string NodeTable = "NodeRow";
        private const string ErrorTable = "ErrorsTable";
        private ObservableCollection<Node> nodeList = new ObservableCollection<Node>();

        private void PopulateListFromDB()
        {
            //DataSource += ".\\nodesDB.db;";
            Trace.Write("path == " + DataSource + "\n\n\n\n\n");
            
            dbconn = new SQLiteConnection(DataSource);
            dbconn.Open();

            string sql = "SELECT * From NodeRow";

            SQLiteCommand command = new SQLiteCommand(sql, dbconn);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Node n = new Node();
                long id;
                id = (long)reader["Id"];
                n.Id = id;
                n.Hostname = reader["Hostname"].ToString();
                n.Ip = reader["Ip"].ToString();
                n.Mac = reader["Mac"].ToString();
                n.IpSecondary = reader["Ip_Sec"].ToString();
                n.MacSecondary = reader["Mac_Sec"].ToString();
                n.IpThird = reader["Ip_Third"].ToString();
                n.MacThird = reader["Mac_Third"].ToString();
                n.IpFourth = reader["Ip_Fourth"].ToString();
                n.MacFourth = reader["Mac_Fourth"].ToString();
                nodeList.Add(n);

                //Trace.Write("ID: " + reader["Id"] + "\tHostname: " + reader["Hostname"] + "secondary ip = " + reader["Ip_Sec"] + "\n");
            }

            //for (int i = 0; i < nodeList.Count(); i++)
            //{

            //    Trace.Write("printed list " + i +
            //    nodeList[i].ToString());
            //}
            dbconn.Close();
        }

        public void PrintToTrace()
        {
            if(nodeList.Count() != 0)
            {
                Trace.Write("empty list");
            }
            for (int i = 0; i < nodeList.Count(); i++)
            {
                Trace.Write("printed list " + i +
                nodeList[i].ToString() + "\n");
            }
        }

        public ObservableCollection<Node> GetRows()
        {
            PopulateListFromDB();
            return nodeList;
        }

        public void UpdateList(ObservableCollection<Node> l)
        {
            nodeList = l;
        }

        public void WriteNodeToDB(ObservableCollection<Node> l)
        {
            DeleteRowsDB();
            dbconn = new SQLiteConnection(DataSource);
            dbconn.Open();

            for (int i = 0; i < l.Count(); i++)
            {
                string sql = "insert into " + NodeTable + " (hostname, ip, mac, Ip_Sec, Mac_Sec, Ip_Third, Mac_Third, Ip_Fourth, Mac_Fourth) values('" + l[i].Hostname + "', '" + l[i].Ip + "', '" + l[i].Mac + "', '" + l[i].IpSecondary + "', '" + l[i].MacSecondary + "', '" + l[i].IpThird + "', '" + l[i].MacThird + "', '" + l[i].IpFourth + "', '" + l[i].MacFourth + "')" ;
                SQLiteCommand command = new SQLiteCommand(sql, dbconn);
                command.ExecuteNonQuery();
            }
                
            dbconn.Close();
        }

        public void WriteErrorToDB(Node n)
        {
            //DeleteRowsDB();
            dbconn = new SQLiteConnection(DataSource);
            dbconn.Open();
            DateTime localDate = DateTime.Now;
            var culture = new CultureInfo("en-GB");
           
                string sql = "insert into " + ErrorTable + " (NodeId, Hostname, Error) values('" + n.Id + "', '" + n.Hostname + "', 'Ping Failed')";
                SQLiteCommand command = new SQLiteCommand(sql, dbconn);
                command.ExecuteNonQuery();
            

            dbconn.Close();
        }

        public void PopulateErrorListFromDB(ObservableCollection<Error> errorList)
        {
            countRows("table");
            dbconn = new SQLiteConnection(DataSource);
            dbconn.Open();

            string sql = "SELECT * From ErrorsTable";

            SQLiteCommand command = new SQLiteCommand(sql, dbconn);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Error e = new Error();
                long id;
                id = (long)reader["Id"];
                e.Id = id;
                id = (long)reader["NodeId"];
                e.NodeId = id;
                e.Hostname = reader["Hostname"].ToString();
                e.ErrorType = reader["Error"].ToString();
                e.Comment = reader["Comment"].ToString();
                e.Timestamp = reader["Timestamp"].ToString();
                errorList.Add(e);
            }
            dbconn.Close();
            
        }

        public void DeleteRowsDB()
        {
            dbconn = new SQLiteConnection(DataSource);
            dbconn.Open();
            string sql = "delete from " + NodeTable;
            SQLiteCommand command = new SQLiteCommand(sql, dbconn);
            command.ExecuteNonQuery();
            dbconn.Close();
        }

        public void DeleteErrorsDB()
        {
            dbconn = new SQLiteConnection(DataSource);
            dbconn.Open();
            string sql = "delete from " + ErrorTable;
            SQLiteCommand command = new SQLiteCommand(sql, dbconn);
            command.ExecuteNonQuery();
            dbconn.Close();
        }

        public int countRows(string table)
        {
            string sql;
            int i = 0;
            dbconn = new SQLiteConnection(DataSource);
            dbconn.Open();
            if (table == ErrorTable)
            {
                sql = " SELECT COUNT(*) from " + ErrorTable;
            }
            else
            {
                sql = " SELECT COUNT(*) from " + NodeTable;
            }
            SQLiteCommand command = new SQLiteCommand(sql, dbconn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                i = Int32.Parse(reader[0].ToString());
            }
            reader.Close();
            Trace.Write("\n\n\nnumber of rows = " + i);
            dbconn.Close();

            return i;
        }

        //private void populate_db_Click(object sender, EventArgs e)
        //{
        //    List<string> dblist = new List<string>();
        //    using (var db = new myDatabaseEntities())
        //    {
        //        dblist = (from g in db.NodeRows select g.Hostname).ToList();
        //        db.Dispose();
        //    }
        //    foreach (string str in dblist)
        //    {
        //        listView1.Items.Add(str);
        //    }
        //}

        //private void get_db_data(string s)
        //{
        //    DataTable dt = new DataTable();
        //    string datasource = "Data Source =C:\\Users\\Grim\\source\\repos\\FYP\\nodesDB.db;";
        //    SQLiteConnection conn = new SQLiteConnection(datasource);
        //    //using (SQLiteConnection conn = new SQLiteConnection(datasource))
        //    //{
        //    //    string sql = $"SELECT * From NodeRow(s);";
        //    //    SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
        //    //    da.Fill(dt);
        //    //    conn.Close();
        //    //}




        //    string sql = "select * from From NodeRow(s);";
        //    SQLiteCommand command = new SQLiteCommand(sql, conn);
        //    SQLiteDataReader reader = command.ExecuteReader();
        //    while (reader.Read())
        //        Trace.WriteLine("Name: " + reader["Ip"] + "\tScore: " + reader["Hostname"]);

        //    //List<Node> nodeList = new List<Node>();
        //    //while (reader.Read())
        //    //{
        //    //    //Create Human Object from Sql Reader
        //    //    Node n = new Node(reader.getString(0), reader.getInt(1));
        //    //    //Add the object to collection
        //    //    nodeList.Add(n);
        //    //}
        //}

        //private void addDB_but_Click(object sender, EventArgs e)
        //{
        //    using (var db = new myDatabaseEntities())
        //    {
        //        //got to use the class that the database creates in the DatabaseSqlite.edmx>DatabaseSqlite.tt>NodesTable
        //        NodeRow newNodeTable = new NodeRow
        //        {
        //            Id = db.NodeRows.Count() + 1,
        //            Hostname = add_DB_text.Text,
        //            Ip = "44",
        //            Mac = "mac"
        //        };

        //        db.NodeRows.Add(newNodeTable);
        //        db.SaveChanges();
        //        db.Dispose();
        //    }
        //}
    }
}
