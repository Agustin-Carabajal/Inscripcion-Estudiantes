using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class Materia
    {
        private string NomMat;
        private int CodMat;
        private TimeSpan Horario;

        public string nomMat { get { return NomMat; } set { NomMat = value; } }
        public int codMat { get { return CodMat; } set { CodMat = value; } }
        public TimeSpan horario
        {
            get { return Horario; }
            set { Horario = value; }
        }

        public Materia(string nomMat, int codMat, TimeSpan horario)
        {

        }
    }
}
