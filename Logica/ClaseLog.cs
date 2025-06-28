using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DBConection;
using Entities;

namespace Logica
{
    public class ClaseLog
    {
        

        public int Cbmateriaselegir(string seleccion)
        {

            Materia mat = new Materia("", 0, new TimeSpan(0, 0, 0));




            switch (seleccion)
            {
                case "Matemática(07:30:00)":
                    mat.nomMat = "Matemáticas";
                    mat.codMat = 1;
                    mat.horario = new TimeSpan(7, 30, 0);
                    break;


                case "Biología(11:00:00)":
                    mat.nomMat = "Biología";
                    mat.codMat = 2;
                    mat.horario = new TimeSpan(11, 0, 0);
                    break;

                case "Lengua(09:30:00)":
                    mat.nomMat = "Lengua";
                    mat.codMat = 3;
                    mat.horario = new TimeSpan(09, 30, 0);
                    break;

                case "Matemática(16:00:00)":
                    // label2.Text = "mates";
                    break;

                case "Programación(14:30:00)":
                    // label2.Text = "mates";
                    break;

                case "Economía(12:00:00)":
                    // label2.Text = "mates";
                    break; ;

                case "Física Cuántica(18:00:00)":
                    // label2.Text = "mates";
                    break;

                default:
                    throw new ArgumentException("Materia no válida");
                   



            }
            return mat.codMat;

        }
        
        private DatosEstudiantes estudianteDatos = new DatosEstudiantes();
        private InscribeDatos inscribeDatos = new InscribeDatos();

        public string InscribirSiCorresponde(Estudiante est, int codMateria)
        {   
            if (!estudianteDatos.ExisteEstudiante(est))
                return "El estudiante no existe.";

                var ins = new Inscribe
                {
                    DNI_Est = est.dniEst,
                    Cod_Mat = codMateria,
                    Fecha_Inscripcion = DateTime.Now
                };

                if (inscribeDatos.YaEstaInscripto(ins))
                    return "El estudiante ya está inscripto en esa materia.";

                inscribeDatos.InsertarInscripcion(ins);

                return "Inscripción realizada con éxito.";
                
        }

        public List<Estudiante> ObtenerEstudiantesInscriptos(int codMat)
        {
            return inscribeDatos.ObtenerEstudiantesPorMateria(codMat);
        }

    }
}
