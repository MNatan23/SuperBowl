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
            //4.
            Console.WriteLine($"4.feladat: Döntők száma:{ döntők.Count}");


            //5.
            int pontkülömbség = 0;
            foreach (var d in döntők)

            {
                string[] e = d.Eredmény.Split('-');
                pontkülömbség += Math.Abs(int.Parse(e[0]) - int.Parse(e[1]));

                double átlag = pontkülömbség / döntők.Count;
                Console.WriteLine($"5.feladat: Átlagos pontkülömbség: {átlag:0.0}");
            }
        }


    }
}
