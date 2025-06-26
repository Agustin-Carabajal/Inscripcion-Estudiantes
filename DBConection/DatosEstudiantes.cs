using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConection
{
    public class DatosEstudiantes
    {

        public bool ExisteEstudiante(Estudiante est)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-PBI6JJN\SQLEXPRESS;Initial Catalog=Inscripciones;Integrated Security=True;Encrypt=False");
            conexion.Open();
            string query = "SELECT COUNT(*) FROM Estudiantes WHERE DNI_Est = @dni AND Nombre_Est = @nombre";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@dni", est.dniEst);
                cmd.Parameters.AddWithValue("@nombre", est.nomEst);

                
                int count = (int)cmd.ExecuteScalar();
            conexion.Close();
            return count > 0;
            
        }
    }
}
