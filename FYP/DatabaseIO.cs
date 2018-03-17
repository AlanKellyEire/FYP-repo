using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYP_10_2_18
{
    class DatabaseIO
    {
        private SQLiteConnection dbconn;
        private const string DATASOURCE = "Data Source=C:\\Users\\Grim\\source\\repos\\FYP\\nodesDB.db;";
        private const string NODE_TABLE = "NodeRow";
        private const string ERR_TABLE = "ErrorsTable";
        private ObservableCollection<Node> nodeList = new ObservableCollection<Node>();

        private void populate_list_from_DB()
        {
            dbconn = new SQLiteConnection(DATASOURCE);
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
                n.Ip_sec = reader["Ip_Sec"].ToString();
                n.Mac_sec = reader["Mac_Sec"].ToString();
                n.Ip_third = reader["Ip_Third"].ToString();
                n.Mac_third = reader["Mac_Third"].ToString();
                nodeList.Add(n);

                Trace.Write("ID: " + reader["Id"] + "\tHostname: " + reader["Hostname"] + "secondary ip = " + reader["Ip_Sec"] + "\n");
            }

            for (int i = 0; i < nodeList.Count(); i++)
            {

                Trace.Write("printed list " + i +
                nodeList[i].ToString());
            }
            dbconn.Close();
        }

        public void print_to_trace()
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

        public ObservableCollection<Node> get_rows()
        {
            populate_list_from_DB();
            return nodeList;
        }

        public void update_list(ObservableCollection<Node> l)
        {
            nodeList = l;
        }

        public void write_Node_To_DB(ObservableCollection<Node> l)
        {
            delete_rows_DB();
            dbconn = new SQLiteConnection(DATASOURCE);
            dbconn.Open();

            for (int i = 0; i < l.Count(); i++)
            {
                string sql = "insert into " + NODE_TABLE + " (hostname, ip, mac, Ip_Sec, Mac_Sec, Ip_Third, Mac_Third) values('" + l[i].Hostname + "', '" + l[i].Ip + "', '" + l[i].Mac + "', '" + "', '" + l[i].Ip_sec + "', '" + l[i].Mac_sec + "', '" + l[i].Ip_third + "', '" + l[i].Mac_third + "')" ;
                SQLiteCommand command = new SQLiteCommand(sql, dbconn);
                command.ExecuteNonQuery();
            }
                
            dbconn.Close();
        }

        public void delete_rows_DB()
        {
            dbconn = new SQLiteConnection(DATASOURCE);
            dbconn.Open();
            string sql = "delete from " + NODE_TABLE;
            SQLiteCommand command = new SQLiteCommand(sql, dbconn);
            command.ExecuteNonQuery();
            dbconn.Close();
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
