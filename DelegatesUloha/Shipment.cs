using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesUloha
{
    class Shipment
    {

        ArrayList DBpolozek = new ArrayList();

        private string trackingNumber;

        public string TrackingNumber //Property, tymto vieme nalepit nalepky cisla na neho
        {
            
            get { return trackingNumber; }
            set {
                    trackingNumber = value;
                    TrackingNumberAdded?.Invoke(VratInfo()); //? (elvis operator) sa pyta ci neni TrackingNumberAdded null. Aby sa nemuselo robit if !null... 
                }
        }

        public void AddItem(Item item)
        {
            DBpolozek.Add(item); //v zatvorke je to co chcem polozit do tej DBpolozek
        }

        public delegate void OnShipmentMade(string message); //zere message, moze sa volat napr tracking nr handler... 
        public event OnShipmentMade TrackingNumberAdded;

        public string VratInfo() //vrati info o baliku
        {
            string info = "";
            foreach (Item i in DBpolozek)
            {
                info += i.ObsahZasielky + Environment.NewLine; // environment.newLine je ako "/n"
                info += i.Cena.ToString() + Environment.NewLine;
                info += i.TrackingNumber.ToString() + Environment.NewLine; // to += pricita do infa aby sa nestalo to, ze ked dame iba = tak sa to stale prepisuje
            }

            return info;
        } 

    }
}
