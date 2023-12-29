using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DataAcces.IRepository
{
    public class IUserRepository
    {
        public static NpgsqlConnection conn = new NpgsqlConnection("server = localhost; port = 5432; User Id = postgres; password = bekzod28072009; Database = bank");


        public static async void GetAll()
        {
            conn.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand("select * from users", conn))
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + " | " + reader.GetString(1) + "  | " + reader.GetString(2) + " | " + reader.GetString(3) + " | " + reader.GetInt32(4));
                }
            }
            conn.Close();
        }

        public static async void Insert(int Id, string Name, string Familiya, string BankName, int Shot)
        {
            conn.Open();
            using(NpgsqlCommand cmd = new NpgsqlCommand("insert into users values(@Id, @Name, @Familiya, @BankName, @Shot)", conn))
            {
                cmd.Parameters.AddWithValue("id", Id);
                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("familiya", Familiya);
                cmd.Parameters.AddWithValue("bankname", BankName);
                cmd.Parameters.AddWithValue("shot", Shot);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public static async void Delete(int Id)
        {
            conn.Open();
            using(NpgsqlCommand cmd = new NpgsqlCommand("delete from users where id = @Id", conn))
            {
                cmd.Parameters.AddWithValue("Id", Id);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public static async void Update(int Id, string Name, string Familiya, string BankName, int Shot)
        {
            conn.Open();
            using(NpgsqlCommand cmd = new NpgsqlCommand("update users set name = 'Abduahad' where name = 'Bekzod'", conn))
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetInt32(0) + " | " + reader.GetString(1) + "  | " + reader.GetString(2) + " | " + reader.GetString(3) + " | " + reader.GetInt32(4));
                }
            }
            conn.Close() ;
        }
    }
}
