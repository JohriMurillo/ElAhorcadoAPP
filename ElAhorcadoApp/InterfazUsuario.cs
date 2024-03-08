using System;

public class InterfazUsuario
{
    public static char LeerLetra()
    {
        Console.WriteLine("Ingresa una letra: ");
        return Console.ReadLine().ToLower()[0];
    }

    public static void MostrarEstadoJuego(string palabraOculta, int intentosRestantes)
    {
        Console.WriteLine($"Palabra: {palabraOculta}");
        Console.WriteLine($"Intentos restantes: {intentosRestantes}");
    }

    public static void MostrarMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}
