using LibraryN4_4;
namespace Es._4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci i valori dei Cerchi, seguiti da C^:");
            string inputc1 = Console.ReadLine();
            Cerchio c1 = Cerchio.Parse(inputc1);

            string inputc2 = Console.ReadLine();
            Cerchio c2 = Cerchio.Parse(inputc2);

            Cerchio sommaC = c1 + c2;
            Cerchio differenzaC = c1 - c2;

            Console.WriteLine($"Primo cerchio: {c1}");
            Console.WriteLine($"Secondo cerchio: {c2}");
            Console.WriteLine($"Somma: {sommaC}");
            Console.WriteLine($"Differenza: {differenzaC}");
            Console.WriteLine($"Uguaglianza: {c1 == c2}");

        }
    }
}
