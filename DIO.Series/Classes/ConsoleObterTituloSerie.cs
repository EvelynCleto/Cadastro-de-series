using System;

namespace DIO.Series
{
    public class ConsoleObterTituloSerie
    {
        public string consoleObterTituloSerie()
        {

            Console.Write("****** DIOFLIX ****** Digite o título da série: ");  
            string entradaTitulo = Console.ReadLine();
            return entradaTitulo;

        }
        public static implicit operator string(ConsoleObterTituloSerie v)
        {

            Console.Write("****** DIOFLIX ****** Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
            return entradaTitulo;
            
        }
    }
}