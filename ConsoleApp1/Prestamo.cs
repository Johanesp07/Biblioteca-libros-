using System;
using static ConsoleApp1.Clases_DerivadasLibro__Revista_y_DVD;

namespace ConsoleApp1
{
    internal class Prestamo
    {
        public Clases_DerivadasLibro__Revista_y_DVD LibroPrestado { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
    }
}






