namespace elektronikai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefon t1 = new Telefon();
            t1.Bekapcsol();
            Console.WriteLine(t1);
            t1.Toltes(10);
            Console.WriteLine(t1);
            t1.Kikapcsol();
            Console.WriteLine(t1);
            t1.Toltes(100);
            Console.WriteLine(t1);

            List<IKapcsolhato> eszkozok = new List<IKapcsolhato>();
            eszkozok.Add(t1);
            eszkozok.Add(new Zseblampa());
            eszkozok.Add(new Telefon());
            eszkozok.Add(new Zseblampa());
            eszkozok.Add(new Telefon());
            //1. Eszközök állapotának kiírása:
            kiiras(eszkozok);
            Console.WriteLine("-----------");


            //2. Bekapcsolt eszközök számlálása:
            int osszesbekapcsolt = 0;
            foreach(var item in eszkozok)
            {
                if (item.Bekapcsolva)
                {
                    osszesbekapcsolt++;
                }
            }
            Console.WriteLine($"Bekapcsolt eszközök száma: {osszesbekapcsolt}");
            Console.WriteLine("------------");

            //3. Eszközök kikapcsolása:
            foreach (var item in eszkozok)
            {
                item.Kikapcsol();
            }
            kiiras(eszkozok);
            Console.WriteLine("------------");

            //4. Zseblámpák keresése:
            foreach (var item in eszkozok)
            {
                if (item is Zseblampa z)
                {
                    Console.WriteLine(z);
                }
            }
        }

        public static void kiiras(List<IKapcsolhato> eszkozok)
        {
            int i = 1;
            foreach (var e in eszkozok)
            {
                Console.WriteLine($"{i++}." + e);
            }
        }
    }
}
