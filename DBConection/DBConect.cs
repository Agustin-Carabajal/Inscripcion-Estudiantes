using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConection
{
    public class DBConect
    {
        public static void Main()
        {

            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-PBI6JJN\SQLEXPRESS;Initial Catalog=Inscripciones;Integrated Security=True;Encrypt=False");
            conexion.Open();

            string instertEstudiante = "insert into Estudiantes values ('0580000', 'pablo')";
            SqlCommand cmd = new SqlCommand(instertEstudiante, conexion);
            cmd.ExecuteNonQuery();
        }

        public static string MostrarEst()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-PBI6JJN\SQLEXPRESS;Initial Catalog=Inscripciones;Integrated Security=True;Encrypt=False");
            conexion.Open();
            string consulta = "select * from Estudiantes";
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            string res = "";

            while (datos.Read())
            {
                int documento = Convert.ToInt32(datos[0]);
                string nombre = Convert.ToString(datos[1]);
               
                res = res + "DNI: " + documento + ", Nombre: " + nombre + "\n";
            }
            conexion.Close();
            return res;

            
        }
    } 
}
