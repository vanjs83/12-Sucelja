﻿namespace Vsite.CSharp
{
    interface ISučelje
    {
        void Metoda();
        void VirtualnaMetoda();
    }

    class Bazna : ISučelje
    {
        public void Metoda() { }

        public virtual void VirtualnaMetoda() { }
    }


    // TODO: u klasi Izvedena pregazite (override) metode iz ISučelja. Provjerite poruke o pogreškama ili upozorenja prevoditelja
    class Izvedena : Bazna
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
