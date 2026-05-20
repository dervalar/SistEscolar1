using SistEscolar1.Model;
using SistEscolar1.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.View
{
    public class EscolarView
    {
        public void MostrarMenu()
        {
            Console.WriteLine("\n===== SISTEMA ESCOLAR =====");
            Console.WriteLine("1. Listar personas");
            Console.WriteLine("2. Agregar alumno");
            Console.WriteLine("3. Agregar docente");
            Console.WriteLine("4. Inscribir alumno en materia");
            Console.WriteLine("5. Ver reporte de materia");
            Console.WriteLine("6. Agregar nota");
            Console.WriteLine("7. Ver promedio de alumno");
            Console.WriteLine("8. Cambiar estrategia");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");
        }
        public void MostrarError(string mensaje)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" Error: {mensaje}");
            Console.ForegroundColor = prev;
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
        public void MostrarAlumnos(List<Alumno> alumnos)
        {
            Console.WriteLine("\n-- Alumnos en el sistema --");
            foreach (var p in alumnos)
                p.Presentarse();
        }
        public void MostrarPersonas(List<Persona> personas)
        {
            Console.WriteLine("\n-- Personas en el sistema --");
            foreach (var p in personas)
                p.Presentarse();
        }
        public void MostrarReporte(IReportable reportable)
        {
            Console.WriteLine(reportable.GenerarReporte());
        }
        public string PedirTexto(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        public int PedirEntero(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }




    }
}
