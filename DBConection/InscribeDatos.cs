using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConection
{
    public class InscribeDatos
    {

        public bool YaEstaInscripto(Inscribe ins)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-PBI6JJN\SQLEXPRESS;Initial Catalog=Inscripciones;Integrated Security=True;Encrypt=False");
            conexion.Open();
            string query = "SELECT COUNT(*) FROM Inscribe WHERE DNI_Est = @dni AND Cod_Mat = @cod";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@dni", ins.DNI_Est);
                cmd.Parameters.AddWithValue("@cod", ins.Cod_Mat);

                
                int count = (int)cmd.ExecuteScalar();
                conexion.Close();
                return count > 0;
        }
        

        public void InsertarInscripcion(Inscribe ins)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-PBI6JJN\SQLEXPRESS;Initial Catalog=Inscripciones;Integrated Security=True;Encrypt=False");
            conexion.Open();
            string query = "INSERT INTO Inscribe (DNI_Est, Cod_Mat, Fecha_ins) VALUES (@dni, @cod, @fecha)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@dni", ins.DNI_Est);
                cmd.Parameters.AddWithValue("@cod", ins.Cod_Mat);
                cmd.Parameters.AddWithValue("@fecha", ins.Fecha_Inscripcion);

               
                cmd.ExecuteNonQuery();
                 conexion.Close();
        }
        }
    }

