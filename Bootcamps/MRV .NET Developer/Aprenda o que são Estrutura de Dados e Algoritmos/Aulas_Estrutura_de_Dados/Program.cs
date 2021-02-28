using System;
using System.Collections.Generic;

namespace Aulas_Estrutura_de_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matriz();
            //Registro();
            //Lista();
            //Pilha();
            //Fila();

            Console.ReadKey();
        }

        private static void Fila()
        {
            //Fila ou Pilha_FIFO
            Queue<int> fila = new Queue<int>();
            fila.Enqueue(1);
            MostraFila(fila);
            fila.Enqueue(2);
            MostraFila(fila);
            fila.Enqueue(3);
            MostraFila(fila);
            fila.Dequeue();
            MostraFila(fila);
            fila.Dequeue();
            MostraFila(fila);
            fila.Dequeue();
            MostraFila(fila);
        }

        private static void MostraFila(Queue<int> fila)
        {
            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void Pilha()
        {
            Stack<int> pilha_lifo = new Stack<int>();
            pilha_lifo.Push(1);
            MostraPilha(pilha_lifo);
            pilha_lifo.Push(2);
            MostraPilha(pilha_lifo);
            pilha_lifo.Push(3);
            MostraPilha(pilha_lifo);
            pilha_lifo.Pop();
            MostraPilha(pilha_lifo);
            pilha_lifo.Pop();
            MostraPilha(pilha_lifo);
            pilha_lifo.Pop();
            MostraPilha(pilha_lifo);
        }

        private static void MostraPilha(Stack<int> pilha)
        {
            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void Lista()
        {
            List<int> numeros = new List<int>();
            numeros.Add(5);
            numeros.Add(12);
            numeros.Add(20);
            foreach (var item in numeros)
            {
                Console.WriteLine(item + "\t");
            }
        }

        private static void Registro()
        {
            Aluno[] alunos =
                        {
                new Aluno("João", 20, DateTime.Parse("15/03/2020")),
                new Aluno("Maria", 56, DateTime.Parse("06/02/2021"))
            };

            //for (var i = 0; i < alunos.Length; i++)
            //{
            //    Console.WriteLine("Nome: " + alunos[i].nome + "\t Idade: " + alunos[i].idade + "\t Data Cadastro: " + alunos[i].dt_cadastro);
            //}

            foreach (var aluno in alunos)
            {
                Console.WriteLine("Nome: " + aluno.nome + "\t Idade: " + aluno.idade + "\t Data Cadastro: " + aluno.dt_cadastro.ToShortDateString());
            }
        }

        private static void Matriz()
        {
            int[,] numeros = new int[3, 3] {
                {1, 3, 6},
                {7, 9, 12},
                {15, 26, 30}
            };

            Console.WriteLine("------------------");
            Console.WriteLine("      TABELA      ");
            Console.WriteLine("------------------");

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    Console.Write(numeros[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    class Aluno {
        public string nome;
        public int idade;
        public DateTime dt_cadastro;

        public Aluno(string nome, int idade, DateTime dt_cadastro)
        {
            this.nome = nome;
            this.idade = idade;
            this.dt_cadastro = dt_cadastro;
        }
    }
}
