using System;
using System.Data.SqlClient;
using System.IO;

namespace Datas
{
    class Program
    {
        static void Main()
        {

            string CONSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@".\Database.mdf") + ";Integrated Security=True";
            string SQL = "select * from Dbo.Person";

            /// Sans IDispose
            SqlConnection SCon1 = new SqlConnection(CONSTR);
            SCon1.Open();
            SqlCommand SCom1 = new SqlCommand(SQL, SCon1);
            SqlDataReader SDR1 = SCom1.ExecuteReader();
            while (SDR1.Read())
            {
                Console.WriteLine(
                    $"{SDR1["Nom"]} " +
                    $"{SDR1["Prenom"]} " +
                    $"{SDR1["Birth"]}"
                );
            }
            SDR1.Close();
            SCon1.Close();

            Console.WriteLine();

            /// Avec IDispose
            using (SqlConnection SCon2 = new SqlConnection(CONSTR))
            {
                SCon2.Open();
                using (SqlCommand SCom2 = new SqlCommand(SQL, SCon2))
                {
                    using (SqlDataReader SDR2 = SCom2.ExecuteReader())
                    {
                        while (SDR2.Read())
                        {
                            Console.WriteLine(
                                $"{SDR2["Nom"]} " +
                                $"{SDR2["Prenom"]} " +
                                $"{SDR2["Birth"]}"
                            );
                        }
                    }
                }
            }

            Console.ReadLine();

        }
    }
}