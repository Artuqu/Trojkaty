using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatTest
{
    class Trojkat
    {
        // fields
        private decimal a;
        public double A
        {
            get { return (double)a; }
            set {
                if (!jestWarunekTrojkata((decimal)value, b, c))
                    throw new ArgumentException("Nie można zmienić boku A");

                    a = (decimal)value; } 
                }


        private decimal b;
        public double B
        {
            get => (double)b; // inn sposób zapisu tego samego
            set {
                if (!jestWarunekTrojkata(a, (decimal)value, c))
                    throw new ArgumentException("Nie można zmienić boku B");

                b = (decimal)value;
            }
           
        }


        private decimal c;
        public double C
        { get => (double)c;
            set {
                if (!jestWarunekTrojkata(a, b, (decimal)value))
                    throw new ArgumentException("Nie można zmienić boku C");

                c = (decimal)value; }
        }
        private bool jestWarunekTrojkata(decimal x, decimal y, decimal z)
        {
            return x + y > z && x + z > y && z + y > x;
        }

        // konstruktory
        public Trojkat(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) // || znak mówiący lub
                throw new ArgumentException("Argument musi być dodatni.");

            if (!jestWarunekTrojkata ((decimal)a, (decimal)b, (decimal)c) )
                throw new ArgumentException("Nie spełniono warunku trójkąta.");


            this.a = (decimal)a; // this odwołuje się do pola fields
            this.b = (decimal)b;
            this.c = (decimal)c;
        }

        public Trojkat()
        {
            a = b = c = 1;
        }
        // przeciążenie ToString
        public override string ToString()
        {
            return $"Trojkat: a={a} b={b} c={c}";
        }

        public double Obwod()// public pozwala na widzenie obiektu w innym programie
        {
            return (double)(a + b + c);
        }

        public double Obwód
        {
            get { return (double)(a + b + c); }
        }

        public double Pole
        {
            get //pobiera wartość
            {
                decimal p = (decimal)(0.5 * Obwód);
                return Math.Sqrt( (double)(p * (p - a) * (p - b) * (p - c)) ); // sqrt to pierwiastek
            }
        }

       public bool jestProsotkatny
        {
            get
            {
               // if () ;
                throw new NotImplementedException();
            }
        }
    }
}
