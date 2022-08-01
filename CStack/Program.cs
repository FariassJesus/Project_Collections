using System;
using System.Collections.Generic;
using static System.Console;

namespace CStack
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Minha pilha de livros.\n");

            Stack<Livro> stack = new Stack<Livro>();

            stack.Push(new Livro("Star Wars Ep I", 258));
            stack.Push(new Livro("Star Wars Ep II", 144));
            stack.Push(new Livro("Star Wars Ep III", 96));

            WriteLine($"{stack.Peek()} é o primeiro livro da pilha.\n");

            WriteLine($"Estamos removendo {stack.Pop().ToString()} da pilha.\n");

            WriteLine($"Livros na pilha: {stack.Count}\n");

            foreach(Livro livro in stack)
            {
                WriteLine($"Possuimos os seguintes livros: {livro.ToString()}");
            }
        }

        internal class Livro
        {
            string Titulo { get; set; }
            int Paginas { get; set; }

            public Livro(string titulo, int paginas)
            {
                Titulo = titulo;
                Paginas = paginas;
            }
            public override string ToString()
            {
                return $"{Titulo}";
            }
            
        }
    }
}
