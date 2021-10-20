using System;

namespace DIO.Series
{
    public class ConsoleObterGeneroSerie
    {
        public int consoleObterGeneroSerie()
        {

            Console.Write("****** DIOFLIX ****** Digite o gênero desejado: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            while (!Enum.IsDefined(typeof(Genero), entradaGenero))
            {
                Console.Write("****** DIOFLIX ****** Digite o gênero desejado que exista na lista: ");
                entradaGenero = int.Parse(Console.ReadLine());
            }

            return entradaGenero;

        }

        public static implicit operator int(ConsoleObterGeneroSerie v)
        {
            Console.Write("****** DIOFLIX ****** Digite o gênero desejado: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            while (!Enum.IsDefined(typeof(Genero), entradaGenero))
            {
                Console.Write("****** DIOFLIX ****** Digite o gênero desejado que exista na lista: ");
                entradaGenero = int.Parse(Console.ReadLine());
            }

            return entradaGenero;
        }
    }
}