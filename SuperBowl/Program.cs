namespace SuperBowl
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //BeolVASÁS
            List<Döntő> döntők = new();
            foreach (var sor in File.ReadAllLines("SuperBowl.txt").Skip(1));
            {
                döntők.Add(new Döntő(sor));
            }
            Console.WriteLine($"4.feladat: Döntők száma:"{ döntők.Count}");
        }
    }
}
