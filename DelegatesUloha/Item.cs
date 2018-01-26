using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesUloha
{
    public struct Item
    {
        public string ObsahZasielky;
        public double Cena;
        public int TrackingNumber;

        public Item(string ObsahZasielky, double Cena, int TrackingNumber)
        {
            this.ObsahZasielky = ObsahZasielky;
            this.Cena = Cena;
            this.TrackingNumber = TrackingNumber;
        }
    }

    
}
