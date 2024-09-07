using System.Xml.Linq;

namespace FirstAppMaja
{
    internal class ReadInput
    {
        static void Main(string[] args)
        {
            string flowerBouqet;
            int stems;
            double price;

            ReadInput(out flowerBouqet, out stems, out price);
            Console.WriteLine($"\nflowerbouqet: {flowerBouqet}");
            Console.WriteLine($"\nstems: {stems}");
            Console.WriteLine($"\nstems: {price}");
        }

        static void ReadInput(out string flowerBouquet, out int stems, out double price);
        Console.Write("Enter type of bouqet: ");
            flowerBouqet = Console.ReadLine();

    }
}
