
using System;

namespace DIO.Series
{
    internal class ConsoleObterDescSerie
    {
        public string consoleObterDescSerie()
        {

            Console.Write("****** DIOFLIX ****** Digite um resumo da série: ");
            string entradaDescricao = Console.ReadLine();
            return entradaDescricao;

        }

        public static implicit operator string(ConsoleObterDescSerie v)
        {

            Console.Write("****** DIOFLIX ****** Digite um resumo da série: ");
            string entradaDescricao = Console.ReadLine();
            return entradaDescricao;
            
        }
    }
}