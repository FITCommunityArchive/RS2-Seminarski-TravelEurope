using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Database
{
    public class PaymentModel
    {
        public string Token { get; set; }
        public decimal Amount { get; set; }
    }
}
