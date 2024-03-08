using System;
using System.Collections.Generic;

public class JuegoAhorcado
{
    private string palabraSecreta;
    private HashSet<char> letrasAdivinadas;

    public JuegoAhorcado(string palabra)
    {
        palabraSecreta = palabra.ToLower();
        letrasAdivinadas = new HashSet<char>();
    }

    public bool IntentarAdivinar(char letra)
    {
        letrasAdivinadas.Add(letra);
        return palabraSecreta.Contains(letra);
    }

    public bool Adivinado()
    {
        foreach (char letra in palabraSecreta)
        {
            if (!letrasAdivinadas.Contains(letra))
            {
                return false;
            }
        }
        return true;
    }

    public string ObtenerPalabraOculta()
    {
        string palabraOculta = "";
        foreach (char letra in palabraSecreta)
        {
            if (letrasAdivinadas.Contains(letra))
            {
                palabraOculta += letra;
            }
            else
            {
                palabraOculta += "_";
            }
            palabraOculta += " ";
        }
        return palabraOculta;
    }
}
