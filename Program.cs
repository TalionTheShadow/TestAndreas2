using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestAndreas2
{
    internal class Program

    {
        public string connectionString { get; set; } = @"Server=TEC-8220-LA0025;Database=h1Tutorial001; Trusted_Connection=true; TrustServerCertificate=True ";

        public void InsertDelete()
        {
            Console.WriteLine("Denne metode skal kunne slette eller inserte ind i en database");
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        
        static public void TwoToFive()
        {
            Console.WriteLine("Denne metode skal kune lave 2 til 5 insert queries.");
            var rand = new Random();

            Console.WriteLine("Five numbers between 2 and 5");
            for (int ctr = 0; ctr <= 4; ctr++)
                Console.Write("{0,8:N0}", rand.Next(50, 101));
            Console.WriteLine();
        }
        public class Butterfly
        {
            public string Sweet { get; set; }
           



            static void Main(string[] args)
            {
                InsertDelete();
                
                // Exercise 4.
                // En class svarer til et blueprint, til koden. Hvis fx vi skal programmerer en bil, så er classen blueprintet til bilen.
                // Det vil sige, at bilen fx skal have attributes som farve og størrelse, men også methods som "brake" og "drive"
                // Et interface minder meget om en abstract class, men der er forskelle som gør at et Interface og en abstract class ikke er det samme.
                // Derfor har det også et andet navn. Et interface er nemlig en gruppe relaterede properties og methods som har at gøre med object, men ikke giver initialisering af det.



            }
        }
    }
}
