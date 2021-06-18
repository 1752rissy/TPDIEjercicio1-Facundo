using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Alumno : IABM
    {
        public string Eliminar()
        {
            return "Elimine una materia";
        }

        public string Insertar()
        {
            return "Inserte una materia";
        }

        public string Modificar()
        {
            return "Modifique una materia";
        }
    }
}
