using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Estudiante
    {
        private string NomEst;

        private int DniEst;

        public string nomEst { get { return NomEst; } set { NomEst = value; } }

        public int dniEst { get { return DniEst; } set { DniEst = value; } }

        public Estudiante(int dniEst, string nomEst)
        {

        }

        public Estudiante()
        {
            // Constructor por defecto


        }
    }
}
