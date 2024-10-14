using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMK.WzorceStrukturalne;

namespace Dekorator
{
    public static class Fasada
    {
        public static Napój PrzygotujKawę(bool cynamon)
        {
            Napój kawa = new Kawa();

            if(cynamon) kawa = new NapójZeSzczyptąCynamonu(kawa);
            return kawa;
        }

        public static Napój PrzyhotujHerbatęZimową()
        {
            return new NapójZeSzczyptąCynamonu(
                new NapójZCytryną(new Herbata(), 2));
        }
    }
}
