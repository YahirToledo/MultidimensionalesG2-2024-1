using System;


namespace MultidimensionalesG2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,,] miArregloCaracteres = { { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } }, { { 'g', 'h', 'i' }, { 'j', 'k', 'l' } } };
            Console.WriteLine(miArregloCaracteres[1,1,1]);
            Console.ReadLine();
        }
    }
}
