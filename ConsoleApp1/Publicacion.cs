using System;

public abstract class Publicacion
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public int AñoPublicacion { get; set; }

    public abstract void MostrarInformacion();
}
