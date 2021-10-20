using System;
namespace DIO.Series
{
    public class ConsoleObterAnoSerie
    {
          public int consoleObterAnoSerie()
        {

            Console.Write("****** DIOFLIX ****** Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            return entradaAno;

        }

        public static implicit operator int(ConsoleObterAnoSerie v)
        {

            Console.Write("****** DIOFLIX ****** Digite o ano de início da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            return entradaAno;
            
        }
    }
}