using System;

namespace Vsite.CSharp
{
    // ilustracija kako svojstvo ne može biti tipa void i kako se ne mogu preopterećivati 
    class Preopterećenje
    {
        // TODO: Zadati svojstvo VoidSvojstvo tipa void i pokušati prevesti kod.
        //public void VoidSvojstvo
        //{
        //    get { }
        //}


        // svojstvo se ne može preopterećivati
        public double PreopterećenoSvojstvo
        {
            get { return Math.PI; }
        }

        // TODO: Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int.

      /*  public int PreopterećenoSvojstvo
        {
            get { return Convert.ToInt32(Math.PI); }
        }
        */


        static void Main(string[] args)
        {
        }
    }
}
