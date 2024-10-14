using System;

namespace Dekorator
{
    using UMK.WzorceStrukturalne;

    class Program
    {
        public static void NapójInfo(Napój napój)
        {
            Console.WriteLine(napój);
            Console.WriteLine("Cena: " + napój.Cena() + " zł");
        }

        static void Main(string[] args)
        {
            Napój kawa = new Kawa();
            Console.WriteLine(kawa);

            kawa = new NapójZeSzczyptąCynamonu(kawa);
            NapójInfo(kawa);

            var kawaZCzynamonem = Fasada.PrzygotujKawę(true);
            NapójInfo(kawaZCzynamonem);

            var HerbataZimowa = Fasada.PrzyhotujHerbatęZimową();
            NapójInfo(HerbataZimowa);

            Console.ReadLine();
        }
    }
}
