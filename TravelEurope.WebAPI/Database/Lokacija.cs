﻿using System;
using System.Collections.Generic;

namespace TravelEurope.WebAPI.Database
{
    public partial class Lokacija
    {
        public int LokacijaId { get; set; }
        public string Naziv { get; set; }
        public int DrzavaId { get; set; }

        public Drzava Drzava { get; set; }
    }
}