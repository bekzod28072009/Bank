using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DataAcces.IRepository
{
    public class IBankRepository
    {
        public static NpgsqlConnection conn = new NpgsqlConnection("server = localhost; port = 5432; User Id = postgres; password = bekzod28072009; Database = bank");


        public static async void GetAll()
        {
            conn.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand("select * from bankname", conn))
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + " | " + reader.GetString(1) + " | " + reader.GetInt32(2));
                }
            }
            conn.Close();
        }

        public static async void Insert(int Id, string Name, int Yosh)
        {
            conn.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand("insert into bankname values(@Id, @Name, @Yosh)", conn))
            {
                cmd.Parameters.AddWithValue("id", Id);
                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("yosh", Yosh);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public static async void Delete(int Id)
        {
            conn.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand("delete from bankname where id = @Id", conn))
            {
                cmd.Parameters.AddWithValue("Id", Id);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public static async void Update()
        {
            conn.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand("update  bankname set name = 'Anorbank' where name = 'Ipoteka'", conn))
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + " | " + reader.GetString(1) + " | " + reader.GetInt32(4));
                }
            }
            conn.Close() ;
        }
    }
}
