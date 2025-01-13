namespace Kalapácsvetést
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sportolo> sportolok = new();
            foreach (var sor in File.ReadAllLines("Kalaoacsvetes.txt").Skip(1))
            {
                sportolok.Add(new Sportolo(sor));
            }
            Console.WriteLine($"4.Feladat:Dobások száma:{sportolok.Count}db");
            foreach (var h in )
            {
                if ()
                {
                    
                }
            }
        }
    }
}
