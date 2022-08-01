using System;
using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace CQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bem vindo a nossa fila de pessoas");

            Queue<Pessoa> Pessoas = new Queue<Pessoa>();

            Pessoas.Enqueue(new Pessoa("Jesus", "25"));
            Pessoas.Enqueue(new Pessoa("Boaz", "30"));
            Pessoas.Enqueue(new Pessoa("Binho", "30"));
            Pessoas.Enqueue(new Pessoa("Maria", "24"));
            Pessoas.Enqueue(new Pessoa("João", "26"));



            WriteLine($"Primeiro da fila é: {Pessoas.Dequeue()}");

            
            WriteLine($"Restam {Pessoas.Count} pessoas na fila.");
            
            foreach (var i in Pessoas)
            {
                WriteLine(i.ToString());
            }

        }
        public class Pessoa
        {
            string Nome { get; set; }
            string Idade { get; set; }

            public Pessoa(string nome, string idade)
            {
                Nome = nome;
                Idade = idade;
            }
            public override string ToString()
            {
                return $"Nome: {Nome} | Idade: {Idade}";
            }
        }
    }
}
