using Tyuiu.GrigorenkoMR.Sprint0.Task6.V0.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма элементов массива * " + DataService.AdditionArray(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine("Разность элементов массива * " + DataService.SubtractionArray(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine("Произведение элементов массива * " + DataService.MultiplicationArray(new int[] { 1, 2, 3, 4, 5 }));
            Console.ReadKey();
        }
    }
}