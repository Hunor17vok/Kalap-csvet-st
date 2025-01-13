namespace Kalapácsvetést
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sportolo> sportolok = new();
            foreach (var sor in File.ReadAllLines("Kalapacsvetes.txt").Skip(1))
            {
                sportolok.Add(new Sportolo(sor));
            }
            Console.WriteLine($"4.Feladat:Dobások száma:{sportolok.Count}db");

            //5
            double összeg = 0;
            int db = 0;
            foreach (var h in sportolok)
            {
                if (h.Orszagkod == "HUN")
                {
                    összeg += h.Eredmyény;
                    db++;
                }
            }
            Console.WriteLine($"5.feladat: A magyar sportolok átlagosan {összeg/db} méter dobtak");

            //5.b
            double átlag = sportolok
                .Where(s => s.Orszagkod == "HUN")
                .Average(s => s.Eredmyény);
            Console.WriteLine($"5.feladat: A magyar sportolok átlagosan {átlag} méter dobtak");
        }
    }
}

