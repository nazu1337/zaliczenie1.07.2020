using System;
using System.Collections.Generic;
using System.Text;

namespace _53427MateuszJanas
{
    class SrodekLokomocji
    {
        internal protected int iloscMiejsc;
        internal protected string model;



        public SrodekLokomocji(string model)
        {
        }

        public SrodekLokomocji(string model, int iloscMiejsc)
        {
            this.iloscMiejsc = iloscMiejsc;
            this.model = model;
        }


        public string Info() => (model + " " + iloscMiejsc.ToString());
    }
}

