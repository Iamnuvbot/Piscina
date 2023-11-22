using System;

namespace CapaEntidad
{
    public class entAlumno
    {
        public int idAlumno { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Categoria { get; set; }
        public string Horario { get; set; } 
        public int AsistenciasDisponibles { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public bool Estado { get; set; }
        public bool EstaDentro { get; set; }
        public string Nivel { get; set; }
    }
}
