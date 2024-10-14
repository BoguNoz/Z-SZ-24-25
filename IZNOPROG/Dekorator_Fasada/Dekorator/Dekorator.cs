using System;

namespace UMK.WzorceStrukturalne
{
    //component
    public abstract class Napój
    {
        public abstract decimal Cena();
        public void Objętość() //funckja nie podlegająca zmianom podczas dekoracji
        {
            Console.WriteLine("\nObjetosc: 330 ml");
        }
    }

    //concrete components
    class Herbata : Napój
    {
        public override decimal Cena()
        {
            return 6.70M;
        }

        public override string ToString()
        {
            return "Herbata";
        }

    }

    class Kawa : Napój
    {
        public override decimal Cena()
        {
            return 7.90M;
        }

        public override string ToString()
        {
            return "Kawa";
        }
    }

    //DECORATOR
    abstract class NapójZDodatkiem : Napój 
    {
        protected Napój napój;

        public NapójZDodatkiem(Napój napój)
        {
            this.napój = napój;
        }
    }

    //CONCRETE DECORATOR
    class NapójZeSzczyptąCynamonu : NapójZDodatkiem
    {
        public NapójZeSzczyptąCynamonu(Napój napój) : base(napój) { }

        public override decimal Cena()
        {
            return napój.Cena() + 0.5M;
        }

        public override string ToString()
        {
            return napój.ToString() + " ze szczyptą cynamonu";
        }
    }

    class NapójZCytryną : NapójZDodatkiem
    {
        private int ilośćPlasterków;

        public NapójZCytryną(Napój napój, int ilo) : base(napój)
        {
            this.ilośćPlasterków = ilo;
        }

        public override decimal Cena()
        {
            return napój.Cena() + ilośćPlasterków * 1M;
        }

        public override string ToString()
        {
            return napój.ToString() + $" z {ilośćPlasterków} plasterkami cytryny";
        }

    }

}
