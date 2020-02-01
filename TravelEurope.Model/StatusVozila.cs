using System;
using System.Collections.Generic;

namespace TravelEurope.Model
{
    public partial class StatusVozila
    {
        public int StatusVozilaId { get; set; }
        public string Status { get; set; }
        public bool Ispravnost { get; set; }
        public bool Rezervisano { get; set; }
        public override string ToString()
        {
            return Status.ToString();
        }
    }
}
