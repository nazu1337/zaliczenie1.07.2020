using System;
using System.Collections.Generic;
using System.Text;

namespace _53427MateuszJanas
{
    class Autobus : SrodekLokomocji
    {
        private bool klimatyzacja;
        double bilet = 5.2;

        public Autobus(string model, int iloscMiejsc,bool klimatyzacja ) : base(model, iloscMiejsc)
        {
            this.klimatyzacja = klimatyzacja;
        }


        public void Bilet(double y) => this.bilet *= 5.2;

        
    }
}
        