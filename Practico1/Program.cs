using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor Andres = new Profesor();
            Materia Programacion1 = new Materia(Andres);
            Profesor Julio = new Profesor();
            Materia Programacion2 = new Materia(Julio);

            Console.WriteLine(Programacion1.eliminarmateria());
            Console.ReadLine();
        }
    }
}
