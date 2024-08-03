using System;


namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace ConsoleApp1
    {
        // Clase base Publicacion
        public abstract class Publicacion
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string ISBN { get; set; }
            public int AnoPublicacion { get; set; }

            public Publicacion(string titulo, string autor, string isbn, int anoPublicacion)
            {
                Titulo = titulo;
                Autor = autor;
                ISBN = isbn;
                AnoPublicacion = anoPublicacion;
            }

            public abstract void MostrarInformacion();
        }

        // Clase derivada Libro
        public class Libro : Publicacion, IPrestable
        {
            public int NumeroPaginas { get; set; }

            public Libro(string titulo, string autor, string isbn, int anoPublicacion, int numeroPaginas)
                : base(titulo, autor, isbn, anoPublicacion)
            {
                NumeroPaginas = numeroPaginas;
            }

            public override void MostrarInformacion()
            {
                Console.WriteLine($"Libro: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Año: {AnoPublicacion}, Páginas: {NumeroPaginas}");
            }

            public void Prestar()
            {
                Console.WriteLine($"El libro '{Titulo}' ha sido prestado.");
            }

            public void Devolver()
            {
                Console.WriteLine($"El libro '{Titulo}' ha sido devuelto.");
            }
        }

        // Clase Usuario
        public class Usuario
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int NumeroSocio { get; set; }

            public Usuario(string nombre, string apellido, int numeroSocio)
            {
                Nombre = nombre;
                Apellido = apellido;
                NumeroSocio = numeroSocio;
            }

            public void AgregarUsuario()
            {
                Console.WriteLine("Agregar nuevo usuario");

                Console.Write("Nombre: ");
                Nombre = Console.ReadLine();

                Console.Write("Apellido: ");
                Apellido = Console.ReadLine();

                Console.Write("Número de Socio: ");
                NumeroSocio = int.Parse(Console.ReadLine());

                // Aquí deberías agregar la lógica para guardar el usuario en una base de datos o lista
                Console.WriteLine("Usuario agregado exitosamente.");
            }

            public void ModificarUsuario()
            {
                Console.WriteLine("Modificar usuario");

                Console.Write("Ingrese el Número de Socio del usuario a modificar: ");
                int numeroSocio = int.Parse(Console.ReadLine());

                // Aquí deberías buscar el usuario en la base de datos o lista
                if (NumeroSocio == numeroSocio)
                {
                    Console.Write("Nuevo Nombre: ");
                    Nombre = Console.ReadLine();

                    Console.Write("Nuevo Apellido: ");
                    Apellido = Console.ReadLine();

                    Console.WriteLine("Usuario modificado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Usuario no encontrado.");
                }
            }

            public void EliminarUsuario()
            {
                Console.WriteLine("Eliminar usuario");

                Console.Write("Ingrese el Número de Socio del usuario a eliminar: ");
                int numeroSocio = int.Parse(Console.ReadLine());

                // Aquí deberías buscar y eliminar el usuario en la base de datos o lista
                if (NumeroSocio == numeroSocio)
                {
                    // Lógica para eliminar el usuario
                    Console.WriteLine("Usuario eliminado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Usuario no encontrado.");
                }
            }
        }

        // Interface IPrestable
        public interface IPrestable
        {
            void Prestar();
            void Devolver();
        }

        class Program
        {
            static List<Libro> libros = new List<Libro>();
            static List<Usuario> usuarios = new List<Usuario>();

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("\nSeleccione una opción:");
                    Console.WriteLine("1. Agregar libro");
                    Console.WriteLine("2. Modificar libro");
                    Console.WriteLine("3. Eliminar libro");
                    Console.WriteLine("4. Buscar libro");
                    Console.WriteLine("5. Prestar libro");
                    Console.WriteLine("6. Devolver libro");
                    Console.WriteLine("7. Agregar usuario");
                    Console.WriteLine("8. Modificar usuario");
                    Console.WriteLine("9. Eliminar usuario");
                    Console.WriteLine("10. Salir");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            AgregarLibro();
                            break;
                        case "2":
                            ModificarLibro();
                            break;
                        case "3":
                            EliminarLibro();
                            break;
                        case "4":
                            BuscarLibro();
                            break;
                        case "5":
                            PrestarLibro();
                            break;
                        case "6":
                            DevolverLibro();
                            break;
                        case "7":
                            AgregarUsuario();
                            break;
                        case "8":
                            ModificarUsuario();
                            break;
                        case "9":
                            EliminarUsuario();
                            break;
                        case "10":
                            return;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }

            static void AgregarLibro()
            {
                Console.WriteLine("Agregar nuevo libro");

                Console.Write("Título: ");
                string titulo = Console.ReadLine();

                Console.Write("Autor: ");
                string autor = Console.ReadLine();

                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();

                Console.Write("Año de Publicación: ");
                int anoPublicacion = int.Parse(Console.ReadLine());

                Console.Write("Número de Páginas: ");
                int numeroPaginas = int.Parse(Console.ReadLine());

                Libro nuevoLibro = new Libro(titulo, autor, isbn, anoPublicacion, numeroPaginas);
                libros.Add(nuevoLibro);

                Console.WriteLine("Libro agregado exitosamente.");
            }

            static void ModificarLibro()
            {
                Console.WriteLine("Modificar libro");

                Console.Write("Ingrese el ISBN del libro a modificar: ");
                string isbn = Console.ReadLine();

                Libro libro = libros.Find(l => l.ISBN == isbn);

                if (libro != null)
                {
                    Console.Write("Nuevo Título: ");
                    libro.Titulo = Console.ReadLine();

                    Console.Write("Nuevo Autor: ");
                    libro.Autor = Console.ReadLine();

                    Console.Write("Nuevo Año de Publicación: ");
                    libro.AnoPublicacion = int.Parse(Console.ReadLine());

                    Console.Write("Nuevo Número de Páginas: ");
                    libro.NumeroPaginas = int.Parse(Console.ReadLine());

                    Console.WriteLine("Libro modificado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Libro no encontrado.");
                }
            }

            static void EliminarLibro()
            {
                Console.WriteLine("Eliminar libro");

                Console.Write("Ingrese el ISBN del libro a eliminar: ");
                string isbn = Console.ReadLine();

                Libro libro = libros.Find(l => l.ISBN == isbn);

                if (libro != null)
                {
                    libros.Remove(libro);
                    Console.WriteLine("Libro eliminado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Libro no encontrado.");
                }
            }

            static void BuscarLibro()
            {
                Console.WriteLine("Buscar libro");

                Console.Write("Ingrese el título, autor o ISBN del libro: ");
                string busqueda = Console.ReadLine().ToLower();

                var resultados = libros.Where(l => l.Titulo.ToLower().Contains(busqueda) || l.Autor.ToLower().Contains(busqueda) || l.ISBN.ToLower().Contains(busqueda)).ToList();

                if (resultados.Count > 0)
                {
                    foreach (var libro in resultados)
                    {
                        libro.MostrarInformacion();
                    }
                }
                else
                {
                    Console.WriteLine("No se encontraron libros.");
                }
            }

            static void PrestarLibro()
            {
                Console.WriteLine("Prestar libro");

                Console.Write("Ingrese el ISBN del libro a prestar: ");
                string isbn = Console.ReadLine();

                Libro libro = libros.Find(l => l.ISBN == isbn);

                if (libro != null)
                {
                    libro.Prestar();
                }
                else
                {
                    Console.WriteLine("Libro no encontrado.");
                }
            }

            static void DevolverLibro()
            {
                Console.WriteLine("Devolver libro");

                Console.Write("Ingrese el ISBN del libro a devolver: ");
                string isbn = Console.ReadLine();

                Libro libro = libros.Find(l => l.ISBN == isbn);

                if (libro != null)
                {
                    libro.Devolver();
                }
                else
                {
                    Console.WriteLine("Libro no encontrado.");
                }
            }

            static void AgregarUsuario()
            {
                Console.WriteLine("Agregar nuevo usuario");

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Apellido: ");
                string apellido = Console.ReadLine();

                Console.Write("Número de Socio: ");
                int numeroSocio = int.Parse(Console.ReadLine());

                Usuario nuevoUsuario = new Usuario(nombre, apellido, numeroSocio);
                usuarios.Add(nuevoUsuario);

                Console.WriteLine("Usuario agregado exitosamente.");
            }

            static void ModificarUsuario()
            {
                Console.WriteLine("Modificar usuario");

                Console.Write("Ingrese el Número de Socio del usuario a modificar: ");
                int numeroSocio = int.Parse(Console.ReadLine());

                Usuario usuario = usuarios.Find(u => u.NumeroSocio == numeroSocio);

                if (usuario != null)
                {
                    Console.Write("Nuevo Nombre: ");
                    usuario.Nombre = Console.ReadLine();

                    Console.Write("Nuevo Apellido: ");
                    usuario.Apellido = Console.ReadLine();

                    Console.WriteLine("Usuario modificado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Usuario no encontrado.");
                }
            }

            static void EliminarUsuario()
            {
                Console.WriteLine("Eliminar usuario");

                Console.Write("Ingrese el Número de Socio del usuario a eliminar: ");
                int numeroSocio = int.Parse(Console.ReadLine());

                Usuario usuario = usuarios.Find(u => u.NumeroSocio == numeroSocio);

                if (usuario != null)
                {
                    usuarios.Remove(usuario);
                    Console.WriteLine("Usuario eliminado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Usuario no encontrado.");
                }
            }
        }
    }
}

