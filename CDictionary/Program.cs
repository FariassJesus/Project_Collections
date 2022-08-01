using System;
using System.Collections.Generic;
using static System.Console;

namespace CDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Dicionario das mentalidades da Gen.");

            Dictionary<string, Mentalidade> dic = new Dictionary<string, Mentalidade>();

            dic.Add("Mentalidade de Crescimento", new Mentalidade("Ter uma mentalidade de crescimento" +
                " é acreditar que suas competências mais básicas podem ser desenvolvidas através de dedicação " +
                "e trabalho árduo. O cérebro e o talento são apenas o ponto de partida.\n"));
            dic.Add("Mentalidade de Persistência", new Mentalidade("Ser persistente significa que você continuará " +
                "tentando vez após vez. Em cada tentativa, você estará mais próximo do sucesso.\n"));
            dic.Add("Mentalidade de Responsabilidade pessoal", new Mentalidade("Responsabilidade pessoal " +
                "significa assumir a responsabilidade por suas próprias ações, trabalhando arduamente, " +
                "mantendo seus compromissos e não dando desculpas.\n"));
            dic.Add("Mentalidade de Orientação ao Futuro", new Mentalidade("Ter orientação ao futuro significa " +
                "estabelecer metas para o seu futuro, compreender como as ações de hoje impactam nessas metas " +
                "e verificar seu progresso com frequência.\n"));

            dic.Add("Habilidade de Comunicação", new Mentalidade("Uma boa comunicação significa capacidade de " +
                "expressar ideias de forma clara e concisa, com linguagem apropriada ao público, assim como " +
                "ouvir com atençãom, manter contato visual com seus interlocutores e tomar notas ao receber " +
                "novas informações.\n"));
            dic.Add("Habilidade de Proatividade", new Mentalidade("Proatividade significa assumir a liderança" +
                " em seu emprego sem nenhum impulso de seu gerente, antecipando situações e tomando as ações " +
                "preventivas que forem necessárias.\n"));
            dic.Add("Habilidade de Orientação ao detalhe", new Mentalidade("Orientação ao detalhe consiste em " +
                "estar constantemente atento aos detalhes ao executar tarefas, a fim de serem completadas com " +
                "precisão e cuidado.\n"));
            dic.Add("Habilidade de Trabalho em equipe", new Mentalidade("Trabalho em equipe Consiste em um" +
                " trupo de pessoas, ou apenas duas pessoas, trabalhando em conjunto visando um objetivo em " +
                "comum.\n"));
            foreach (KeyValuePair<string, Mentalidade> kvp in dic)
            {
                WriteLine($"{kvp.Key} | " +
                    $"Descrição: {kvp.Value}");
            }

        }
        internal class Mentalidade
        {
            public string Texto { get; set; }

            public Mentalidade(string texto)
            {
                Texto = texto;
            }
        public override string ToString()
        {
            return $"{Texto}";
        }
        }

    }
}
