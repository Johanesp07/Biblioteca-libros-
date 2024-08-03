using System;

namespace ConsoleApp1
{
    internal class Clases_DerivadasLibro__Revista_y_DVD
    {
        public class Libro : Publicacion, IPrestable
        {
            public int NumeroPaginas { get; set; }

            public override void MostrarInformacion()
            {
                Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Año: {AñoPublicacion}, Páginas: {NumeroPaginas}");
            }

            public void Prestar()
            {
                Console.WriteLine($"El libro {Titulo} ha sido prestado.");
            }

            public void Devolver()
            {
                Console.WriteLine($"El libro {Titulo} ha sido devuelto.");
            }

        }

        public class Revista : Publicacion
        {
            public int NumeroVolumenes { get; set; }

            public override void MostrarInformacion()
            {
                Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Año: {AñoPublicacion}, Volúmenes: {NumeroVolumenes}");
            }
        }

        public class DVD : Publicacion
        {
            public int Duracion { get; set; } // Duración en minutos

            public override void MostrarInformacion()
            {
                Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Año: {AñoPublicacion}, Duración: {Duracion} minutos");
            }
        }

        public interface IPrestable
        {
            void Prestar();
            void Devolver();
        }

    }
}
