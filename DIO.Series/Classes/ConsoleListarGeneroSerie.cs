using System;
namespace DIO.Series
{
    public class ConsoleListarGeneroSerie
    {
        public ConsoleListarGeneroSerie()
        {

            Console.WriteLine("****** DIOFLIX ****** Lista de generos disponíveis: ");
            Console.WriteLine();

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }

        }
    }
}