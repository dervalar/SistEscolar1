using SistEscolar1.Model;
using SistEscolar1.Repositorios;
using System;
using System.Windows.Forms;

namespace SistemaEscolar.UI
{
    static class Program
    {
        [STAThread] // requerido por WinForms para el modelo de threading
        static void Main()
        {
            // Configuración estándar de WinForms
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // ── 1. Crear los repositorios ──────────────────────────────────
            // Usamos JSON para que los datos persistan entre sesiones.
            // Si querés empezar con datos en memoria para probar,
            // reemplazá por RepositorioAlumnosMemoria() y RepositorioMateriasMemoria().
            var repoAlumnos = new RepositorioAlumnoJSON("almunos.json");
            var repoDocentes = new RepositorioDocenteJSON("docentes.json");
            var repoMaterias = new RepositorioMateriasJSON("materias.json", repoAlumnos);
            // ── 2. Crear el Model ──────────────────────────────────────────
            var model = new EscolarModel(repoAlumnos,repoMaterias, repoDocentes);
            // ── 3. Crear el Controller ─────────────────────────────────────
            var controller = new EscolarControllerUI(model);
            // ── 4. Crear y mostrar el formulario principal ─────────────────
            // El formulario se suscribe al Model en su constructor.
            var formPrincipal = new FormPrincipal(model, controller);
            // Application.Run inicia el loop de eventos de WinForms.
            // La app corre hasta que el usuario cierra la ventana.
            Application.Run(formPrincipal);
        }
    }
}