using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Inscribe
    {
        private int _dni_Est;   
        private int _cod_Mat;
        private DateTime _fecha_Inscripcion;
        public int DNI_Est { get { return _dni_Est; } set { _dni_Est = value; } }
        public int Cod_Mat { get { return _cod_Mat; } set { _cod_Mat = value; } }
        public DateTime Fecha_Inscripcion { get { return _fecha_Inscripcion; } set { _fecha_Inscripcion = value; } } 


    }
}
