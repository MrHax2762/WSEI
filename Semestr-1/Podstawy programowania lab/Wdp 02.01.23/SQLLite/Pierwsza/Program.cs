using System;
using System.Data.SQLite;

namespace Pierwsza
{
    class Program
    {
        SQLiteConnection con;

        static void Main(string[] args)
        {
            Program p = new Program();
        }

        public Program()
        {
            TestujBaze();
            
        }

        void TestujBaze()
        {
            SQLiteConnection.CreateFile("test.db");

            con = new SQLiteConnection("Data Source=test.db;Version=3;");
            con.Open();

            string sql = "create table firma (nazwa varchar(20), nip int)";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();

            sql = "insert into firma (nazwa, nip) values ('F1', 343004230)";
            command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            sql = "insert into firma (nazwa, nip) values ('F2', 552002340)";
            command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            sql = "insert into firma (nazwa, nip) values ('F3', 338760621)";
            command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();

            sql = "select * from firma order by nip desc";
            command = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("nazwa: " + reader["nazwa"] + "\tnip: " + reader["nip"]);
            Console.ReadLine();
        }
    }
}
