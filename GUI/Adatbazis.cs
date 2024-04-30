using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI
{
    class Adatbazis
    {
        MySqlCommand SqlCommand = null;
        MySqlConnection connection = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "munkasok";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                kapcsolatNyit();
                SqlCommand = connection.CreateCommand();
                kapcsolatZar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        internal List<Dolgozo> getAllDolgozo()
        {
            List<Dolgozo> dolgozos = new List<Dolgozo>();
            SqlCommand.CommandText = "SELECT * FROM `dolgozok`";
            kapcsolatNyit();
            using (MySqlDataReader dr = SqlCommand.ExecuteReader())
            {
                while (dr.Read())
                {
                    //-- rekordonkénti feldolgozás
                    Dolgozo dolgozo = new Dolgozo(dr.GetString("nev"), dr.GetString("neme"), dr.GetString("reszleg"), dr.GetInt32("belepesev"), dr.GetInt32("ber"));
                    dolgozos.Add(dolgozo);
                }
            }

            return dolgozos;
        }

        private void kapcsolatZar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void kapcsolatNyit()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        internal void insertDolgozo(string nev, string nem, string reszleg, int belepes, int ber)
        {
            SqlCommand.CommandText = "INSERT INTO `dolgozok` (`nev`, `neme`, `reszleg`, `belepesev`, `ber`) VALUES ('" + nev + "', '" + nem + "', '" + reszleg + "', " + belepes + ", " + ber + ")";
            kapcsolatNyit();
            if (SqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sikeres beszúrás!");
            }
            else
            {
                MessageBox.Show("Sikertelen beszúrás!");
            }
        }
    }
}
