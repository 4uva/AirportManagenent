﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportManagement.Data
{
    class Flight
    {
        string FlightNumber { get; set; }
        FlightStatus current = FlightStatus.Checkin;
        int  Id { get; set; }
    }
}
