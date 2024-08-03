using System;

namespace ConsoleApp1
{
    internal class Usuario
    {
        // atributos 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroSocio { get; set; }

        //constructor
        public Usuario () 
        {
            Nombre = "Johan";
            Apellido = "Espinoza";
            NumeroSocio = "01";
        }

        //metodos o funciones

        public void AgregarUsuario()
        {
            Console.WriteLine("¿Desea agregar un nuevo usuario? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
            {
                Console.WriteLine("Digite el Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Digite el Apellido:");
                Apellido = Console.ReadLine();
                Console.WriteLine("Digite el Número de Socio:");
                NumeroSocio = Console.ReadLine();
                Console.WriteLine("Usuario agregado exitosamente.");
            }
            else
            {
                Console.WriteLine("Operación cancelada.");
            }
        }

        public void ModificarUsuario()
        {
            Console.WriteLine("¿Desea modificar este usuario? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
            {
                Console.WriteLine("Digite el nuevo Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Digite el nuevo Apellido:");
                Apellido = Console.ReadLine();
                Console.WriteLine("Digite el nuevo Número de Socio:");
                NumeroSocio = Console.ReadLine();
                Console.WriteLine("Usuario modificado exitosamente.");
            }
            else
            {
                Console.WriteLine("Operación cancelada.");
            }
        }

        public void EliminarUsuario()
        {
            Console.WriteLine("¿Desea eliminar este usuario? (s/n)");
            if (Console.ReadLine().ToLower() == "s")
            {
                Nombre = string.Empty;
                Apellido = string.Empty;
                NumeroSocio = string.Empty;
                Console.WriteLine("Usuario eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Operación cancelada.");
            }
        }

    }
}
