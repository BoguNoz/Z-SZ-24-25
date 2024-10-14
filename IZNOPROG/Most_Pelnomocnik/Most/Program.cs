using System;
using UMK.WzorceStrukturalne;

namespace Most
{
    class Program
    {
        static void Main(string[] args)
        {
            IUrządzenieRTV radio = new Radio();
            Pilot pilotRadio = new Pilot(radio);
            pilotRadio.Wyłącz();
            pilotRadio.UstawKanał(3);
            pilotRadio.PrzywrócPoprzedniKanał();
            pilotRadio.Wyłącz();

            Console.ReadLine();
        }
    }
}
