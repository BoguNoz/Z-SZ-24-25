using System;

namespace UMK.WzorceStrukturalne
{
    public interface IUrządzenieRTV
    {
        void Włącz();
        void Wyłącz();
        void UstawKanał(int numerKanału);
    }

    public class Telewizor : IUrządzenieRTV
    {
        public void Włącz()
        {
            Console.WriteLine("Telewizor zostal wlaczony");
        }
        public void Wyłącz()
        {
            Console.WriteLine("Telewizor zostal wylaczony");
        }
        public void UstawKanał(int numerKanału)
        {
            Console.WriteLine("Kanal w telewizorze zmieniony na: " + numerKanału);
        }
    }

    public class Radio : IUrządzenieRTV
    {
        public void Włącz()
        {
            Console.WriteLine("Radio zostalo wlaczone");
        }
        public void Wyłącz()
        {
            Console.WriteLine("Radio zostalo wylaczone");
        }
        public void UstawKanał(int numerKanału)
        {
            Console.WriteLine("Kanal w radiu zmieniony na: " + numerKanału);
        }
    }

    class Pilot
    {
        private int poprzedniKanał, bieżącyKanał;
        protected readonly IUrządzenieRTV urządzenie;

        public Pilot(IUrządzenieRTV urządzenie)
        {
            this.urządzenie = urządzenie;
        }

        public void Włącz()
        {
            urządzenie.Włącz();
            UstawKanał(1);
        }

        public void Wyłącz()
        {
            urządzenie.Wyłącz();
        }

        public void UstawKanał(int numerKanału)
        {
            poprzedniKanał = bieżącyKanał;
            bieżącyKanał = numerKanału;
            urządzenie.UstawKanał(numerKanału);
        }

        public void PrzywrócPoprzedniKanał()
        {
            UstawKanał(poprzedniKanał);
        }
    }

    class PilotZespolony
    {
        private int poprzedniKanał, bieżącyKanał;
        protected readonly IUrządzenieRTV[] urządzenia;

        public PilotZespolony(params IUrządzenieRTV[] urządzenia)
        {
            this.urządzenia = urządzenia;
        }

        public void Włącz()
        {
            foreach(var urządzenie in urządzenia)
            {
                urządzenie.Włącz();
            }
            UstawKanał(1);
        }

        public void Wyłącz()
        {
            foreach (var urządzenie in urządzenia)
            {
                urządzenie.Wyłącz();
            }
        }

        public void UstawKanał(int numerKanału)
        {
            poprzedniKanał = bieżącyKanał;
            bieżącyKanał = numerKanału;
            foreach (var urządzenie in urządzenia)
            {
                urządzenie.UstawKanał(numerKanału);
            }
        }

        public void PrzywrócPoprzedniKanał()
        {
            UstawKanał(poprzedniKanał);
        }
    }

    //PEŁNOMOCNIK
    public class PilotPełnonmocnikRadio
    {
        private int poprzedniKanał, bieżącyKanał;
        protected readonly IUrządzenieRTV urządzenie;

        public PilotPełnonmocnikRadio()
        {
            urządzenie = new Radio();
        }

        public void Włącz()
        {
            urządzenie.Włącz();
            UstawKanał(1);
        }

        public void Wyłącz()
        {
            urządzenie.Wyłącz();
        }

        public void UstawKanał(int numerKanału)
        {
            poprzedniKanał = bieżącyKanał;
            bieżącyKanał = numerKanału;
            urządzenie.UstawKanał(numerKanału);
        }

        public void PrzywrócPoprzedniKanał()
        {
            UstawKanał(poprzedniKanał);
        }
    }
}
