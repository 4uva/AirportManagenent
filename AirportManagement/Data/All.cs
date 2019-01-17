﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AirportManagement.Data
{  //будущая бз добавить списки
   //аэропортов, полётов, и авиакомпаний
    public class All
    {
        public All()//модификаторы, имя класса, 
                    //в скобках список аргументов
        {
        }

        public Airport AddAirport(string locationName)
        // создали публичную функцию добавить аэропорт , котррая
        //возращает аэропорт и на вход получает имя аэропорта
        {
            var a = CreateAirport(locationName);
            //создали переменную и присвоили ей значение вызова 
            //функции с параметром локация аэропорта
            Airports.Add(a);//добавили экземпляр аэропорта 
            //со значением фактического параметра а
            return a;
            //вернули значение фактического параметра
        }
        Airport CreateAirport(string locationName)
        // создали функцию, которая создает
        // экземпляр класса аэропорт, присвоили ей значение локации , 
        //а потом дали имя, которое у нас уже есть в поле класса Location
        {
            var a = new Airport();//
            //1)мы присвоили переменной а значение нового аэропорта
            var f = new Location();//
            a.Location = f;
            f.Name = locationName;
            //2)мы присвоили переменной f значение локация var g = new Location();           
            //мы присвоили полю                                                                         Аэропорта 
            //значение объекта типа Location, у которого есть поле `Name`c.Location = g;
            //3)мы обратились к полю Name класса Location
            return a;//переменная умрет, а нам нужно сделать так,
            // чтоб эти данные а можно было записать в функции
        }

        //поле r
        //All All2 { get; set; }  свойство
        public void Create()
        {
            Airports = new List<Airport>();//создали список
            AddAirport("Florence");//вызвали экземпляр списка
            AddAirport("Elabuga");
            AddAirport("Gatwick");
            AddAirport("Innsbruk");
        }

        public List<Airport> GetFilteredByPartialLocationAirports(string partialLocation)
        {
            throw new NotImplementedException();
        }

        public List<Airport> Airports { get; set; }
    }
}


//var airports0 = new List<Airport>()
//{
//    new Airport(),
//    new Airport(),
//    new Airport(),
//    new Airport()
//};
//---------------------------------------

//var airports2 = new List<Airport>();
//airports2.Add(new Airport());//в
//airports2.Add(new Airport());
//airports2.Add(new Airport());
//airports2.Add(new Airport());

////---------------------------------------

//var airports3 = new List<Airport>();//список на входе
//airports3.AddRange(new List<Airport>() { new Airport(), new Airport(), new Airport(), new Airport() });
//airports3.AddRange(new Airport[] { new Airport(), new Airport(), new Airport(), new Airport() });//массив на выходе
