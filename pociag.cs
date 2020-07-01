using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _53427MateuszJanas
{
    class Pociag : SrodekLokomocji
    {
        private string kategoria;
        double bilet = 1.0;

        public Pociag(string model, int iloscMiejsc, string kategoria) : base(model, iloscMiejsc)
        {
            this.kategoria = kategoria;
        }


        public void Bilet(double bilet) => this.bilet *= 12.7;
    }
}
