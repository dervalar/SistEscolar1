using SistEscolar1.Model;
using SistEscolar1.Model.Interface;
using SistEscolar1.Model.Strategies;
using System;
using System.Collections.Generic;
using SistEscolar1.Controller;
using SistEscolar1.View;
using SistEscolar1.Repositorios;

namespace SistEscolar1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║ SISTEMA ESCOLAR v3.0 ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine("¿Cómo desea iniciar el sistema?");
            Console.WriteLine(" 1. Datos en memoria (sin persistencia)");
            Console.WriteLine(" 2. Datos persistidos en disco (JSON)");
            Console.Write("Opción: ");
            string opcionInicio = Console.ReadLine() ?? "1";
            
            // Elegimos los repositorios según la preferencia del usuario.
            // El Controller nunca sabrá cuál de los dos se está usando.
            
            IRepositorioAlumnos repoAlumnos;
            IRepositorioMaterias repoMaterias;
            
            if (opcionInicio == "2")
            { 

                repoAlumnos = new RepositorioAlumnoJSON("alumnos.json");
                repoMaterias = new RepositorioMateriasJSON("materias.jseon", repoAlumnos);
                Console.WriteLine("→ Cargando datos desde disco...");
            }
            else
            {
                repoAlumnos = new RepositorioAlumnosMemoria();
                repoMaterias = new RepositorioMateriasMemoria();
                repoAlumnos.Agregar(new Alumno("Ana", "ana@mail.com", 1001));
                repoAlumnos.Agregar(new Alumno("Bruno", "bruno@mail.com", 1002));
                repoMaterias.Agregar(new Materia("MAT101", "Matematica I", 3));
                Console.WriteLine("→ Sistema iniciado con datos de prueba.");
            }

            EscolarModel model = new EscolarModel(repoAlumnos,repoMaterias);
            EscolarView view = new EscolarView();
            EscolarController cctr = new EscolarController(model, view);

            /* Cargar datos de prueba
            model.AgregarPersona(new Alumno("Ana", "ana@mail.com", 1001));
            model.AgregarPersona(new Alumno("Bruno", "bruno@mail.com", 1002));
            model.AgregarMateria(new Materia("MAT101", "Matematica I", 3));
            */

            cctr.Ejecutar();
        }

        /*
         static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            Alumno a1 = new Alumno("Ricardo", "Ricky@gmail.com", 12345);
            Alumno a2 = new Alumno("Sofia", "Sofi12@gmail.com", 54321);
            Alumno a3 = new Alumno("Federico", "Fedelol2@gmail.com", 67890);

            Docente d1 = new Docente("Maria", "Maria@gmail.com", "D1234");
            Docente d2 = new Docente("Julian", "Juli@gmail.com", "D4321");
           
            foreach (var p in personas)
                p.Presentarse();

            Materia m1 = new Materia("LEN1", "Lengua", 2);
            Materia m2 = new Materia("MAT1", "Matématicas", 3);
            m1.Inscribir(a1);
            m1.Inscribir(a2);
            m1.Inscribir(a3);

            m2.Inscribir(a1);
            m2.Inscribir(a2);
            m2.Inscribir(a3);

            List<IReportable> reportables = new List<IReportable>();
            reportables.Add(a1);
            reportables.Add(a2);
            reportables.Add(a3);

            reportables.Add(d1);
            reportables.Add(d2);

            reportables.Add(m1);
            reportables.Add(m2);

            a1.AgregarNota(4.0);
            a2.AgregarNota(9.0);
            a3.AgregarNota(6.0);

            // Estrategia Simple (por ejemplo)

            Console.WriteLine("Simple:   " + a1.ObtenerPromedio().ToString("F2"));
            Console.WriteLine("Simple:   " + a2.ObtenerPromedio().ToString("F2"));
            Console.WriteLine("Simple:   " + a3.ObtenerPromedio().ToString("F2"));


            // Cambiar a ponderado

            a1.CambiarEstrategia(new PromedioPonderado());
            Console.WriteLine("Ponderado: " + a1.ObtenerPromedio().ToString("F2"));

            a2.CambiarEstrategia(new PromedioPonderado());
            Console.WriteLine("Ponderado: " + a2.ObtenerPromedio().ToString("F2"));

            a3.CambiarEstrategia(new PromedioPonderado());
            Console.WriteLine("Ponderado: " + a3.ObtenerPromedio().ToString("F2"));


            // Cambiar a sin extremos

            a1.CambiarEstrategia(new PromedioSinExtremo());
            Console.WriteLine("Sin extremos: " + a1.ObtenerPromedio().ToString("F2"));

            a2.CambiarEstrategia(new PromedioSinExtremo());
            Console.WriteLine("Sin extremos: " + a2.ObtenerPromedio().ToString("F2"));

            a3.CambiarEstrategia(new PromedioSinExtremo());
            Console.WriteLine("Sin extremos: " + a3.ObtenerPromedio().ToString("F2"));
        } */
    }
}

    