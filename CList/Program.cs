using System;
using System.Collections.Generic;
using static System.Console;

namespace CList
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bem vindo a lista de animais pantaneiros");

            List<string> Animais = new List<string> ();
            
            Animais.Add("Onça Pintada");
            Animais.Add("Ariranha");
            Animais.Add("Jacaré");
            Animais.Add("Sucuri");

            Animais.Insert(2, "Tuiuiu");

            Animais.Remove("Sucuri");
            Animais.RemoveAt(1);

            foreach (string i in Animais)
            {
                WriteLine($"No pantanal encontramos: {i}");
            }

            
        }
    }
}
