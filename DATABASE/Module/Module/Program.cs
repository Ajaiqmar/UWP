using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Program
{
    class Lesson
    {
        public static void Main(string[] args)
        {
            using (SQLiteConnection conn = new SQLiteConnection("Data Source=E:/ZOHO/DATABASE/Module/Module/db/hotel.db;"))
            {
                try
                {
                    conn.Open();

                    SQLiteCommand comm = conn.CreateCommand();
                    comm.CommandText = "SELECT * FROM users;";

                    SQLiteDataReader reader = comm.ExecuteReader();

                    while(reader.Read())
                    {
                        Console.WriteLine(reader.GetInt32(0)+" "+reader.GetString(1));
                    }
                }
                catch (Exception ex) { }
            }

        }
    }
}