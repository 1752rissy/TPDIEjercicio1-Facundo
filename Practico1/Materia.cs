using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Materia
    {
        private readonly IABM _iabm;

        public Materia(IABM operacionesmaterias)
        {
            _iabm = operacionesmaterias;
        }

        public string eliminarmateria()
        {
            return _iabm.Eliminar();
        }
    }
}
