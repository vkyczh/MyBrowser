using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace MyBrowser.Util
{
    public class SqliteHelper
    {
        public static void Init()
        {
            const string TableName = "UserInfo";
            Connect((c) => {
                CreateTableIfNotExist(TableName, c);
            });
        }

        private static void CreateTableIfNotExist(string TableName, SQLiteConnection c)
        {
            var existCommandText = string.Format("SELECT COUNT(*) FROM sqlite_master where type='table' and name='{0}'", TableName);
            SQLiteCommand cmd = new SQLiteCommand(existCommandText, c);
            var dataAdapter = new SQLiteDataAdapter(cmd);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            if (ds.Tables[0].Rows[0][0].ToString() != "1")
            {
                cmd.CommandText = string.Format("create table {0} (ID int)", TableName);
                var r = cmd.ExecuteNonQuery();
            }
        }

        public static void Connect(Action<SQLiteConnection> action)
        {
            const string DbFileName = "MyBrowser.db";
            var dbPath = AppDomain.CurrentDomain.BaseDirectory + DbFileName;
            using (var c = new SQLiteConnection(string.Format("Data Source={0};Version=3;", dbPath)))
            {
                try
                {
                    c.Open();
                    action(c);
                }
                catch
                {

                }
                finally
                {
                    c.Close();
                }
            }
        }

        public static bool IsDbExist()
        {
            var dbPath = AppDomain.CurrentDomain.BaseDirectory + "MyBrowser.db";
            var exist = false;
            using (var c = new SQLiteConnection(string.Format("Data Source={0};Version=3;", dbPath)))
            {
                try
                {
                    c.Open();
                    var existCommandText = "SELECT COUNT(*) FROM sqlite_master where type='table' and name='Test'";
                    SQLiteCommand cmd = new SQLiteCommand(existCommandText, c);
                    var dataAdapter = new SQLiteDataAdapter(cmd);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    exist = ds.Tables[0].Rows[0][0].ToString() == "1";
                }
                catch
                {

                }
                finally
                {
                    c.Close();
                }
                return exist;
            }
        }

    }
}
