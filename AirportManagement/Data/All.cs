﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AirportManagement.Data
{  //будущая бз добавить списки
   //аэропортов, полётов, и авиакомпаний
    class All
    {
      public  List<Airport> Airports { get; set; }

        static void Create()
        {
            var airports = new List<Airport>()
            {
              new Airport(), new Airport (),new Airport(), new Airport ()
            };

            var airports2 = new List<Airport>();
            airports2.Add(new Airport());
            airports2.Add(new Airport());
            airports2.Add(new Airport());
            airports2.Add(new Airport());

            var airports3 = new List<Airport>();//список на входе
            airports3.AddRange(new List<Airport>() { new Airport(), new Airport(), new Airport(), new Airport() });
            airports3.AddRange(new Airport[] { new Airport(), new Airport(), new Airport(), new Airport() });//массив на выходе
        }
    }
}
