using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Grupo> grupos = new List<Grupo>();

            Grupo matematicas = new Grupo("Matematicas", "M14523");
            Grupo historia = new Grupo("Historia", "H14523");

            grupos.Add(matematicas);
            grupos.Add(historia);

            Alumno juan = new Alumno("Juan", "73687");
            Alumno paco = new Alumno("Paco", "73327");
            Alumno pedro = new Alumno("Pedro", "96547");
            Alumno mario = new Alumno("Mario", "74547");
            Alumno laura = new Alumno("Laura", "51547");

            historia.Alumnos.Add(juan);
            historia.Alumnos.Add(paco);
            historia.Alumnos.Add(pedro);

            matematicas.Alumnos.Add(mario);
            matematicas.Alumnos.Add(laura);
            matematicas.Alumnos.Add(juan);
            matematicas.Alumnos.Add(paco);
            matematicas.Alumnos.Add(pedro);


            foreach (Grupo grupo in grupos)
            {
                Console.WriteLine("Grupo:" + grupo.Codigo);
                Console.WriteLine("Materia:" + grupo.Materia);

                Console.WriteLine("Lista de  alumnos:");
                foreach (Alumno alumno in grupo.Alumnos)
                {
                    Console.WriteLine("*" + alumno.Nombre);
                }

            }

            Console.Read(); 
        }
    }
}

