using System;

class Program
{
    static void Main(string[] args)
    {
        string[] palabras = { "manzana", "banana", "naranja", "sandia", "pera" };
        Random random = new Random();
        string palabraSeleccionada = palabras[random.Next(palabras.Length)];

        JuegoAhorcado juego = new JuegoAhorcado(palabraSeleccionada);
        int intentosRestantes = 4;

        while (intentosRestantes > 0 && !juego.Adivinado())
        {
            InterfazUsuario.MostrarEstadoJuego(juego.ObtenerPalabraOculta(), intentosRestantes);
            char letra = InterfazUsuario.LeerLetra();
            if (!juego.IntentarAdivinar(letra))
            {
                intentosRestantes--;
            }
        }

        if (intentosRestantes > 0)
        {
            InterfazUsuario.MostrarMensaje("¡Has adivinado la palabra!");
            Console.WriteLine("Hola soy cristina y estoy realizando la practica");
        }
        else
        {
            InterfazUsuario.MostrarMensaje($"¡Lo siento, la palabra era '{palabraSeleccionada}'!");
        }

        Console.ReadLine(); // Esperar a que el usuario presione Enter antes de cerrar la consola
    }
}
