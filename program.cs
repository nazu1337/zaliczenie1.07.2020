using System;

namespace _53427MateuszJanas
{
    class Program
    {
        static void Main(string[] args)
        {
            SrodekLokomocji s1 = new SrodekLokomocji("samochod", 5);
            SrodekLokomocji s2 = new SrodekLokomocji("samolot", 2);


            Autobus a1 = new Autobus("Bus", 100, true);
            Autobus a2 = new Autobus("Miejski", 50, true);

            Pociag p1 = new Pociag("Tramwaj", 200, "Miejski");
            Pociag p2 = new Pociag("InterCity", 200, "Krajowy");

            p1.Bilet(1);
            p2.Bilet(1);
            a1.Bilet(1);
            a2.Bilet(1);

            Console.WriteLine(s1.Info());
            Console.WriteLine(s2.Info());
            Console.WriteLine(a1.Info());
            Console.WriteLine(a2.Info());
            Console.WriteLine(p1.Info());
            Console.WriteLine(p2.Info());
            Console.ReadKey();
        }
    }
}
