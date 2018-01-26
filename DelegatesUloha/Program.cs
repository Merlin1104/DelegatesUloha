using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesUloha
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipment S = new Shipment();

            Item item = new Item(); //vytvorenie bez konstruktora
            item.Cena = 5.4;
            item.ObsahZasielky = "Zasielka A";
            item.TrackingNumber = 123;

            S.AddItem(item);

            item = new Item();  //vytvorenie bez konstruktora
            item.Cena = 3.9;
            item.ObsahZasielky = "Zasielka B";
            item.TrackingNumber = 567;

            S.AddItem(item);

            item = new Item("Zasielka C", 9.3, 890); //vytvorenie s construktorom

            S.AddItem(item);

            Notification n = new Notification();
            S.TrackingNumberAdded += n.Notify;  //tuto sa spaja event s handlerom

            S.TrackingNumber = "1";
            

            Console.ReadLine();

        }
    }
}
