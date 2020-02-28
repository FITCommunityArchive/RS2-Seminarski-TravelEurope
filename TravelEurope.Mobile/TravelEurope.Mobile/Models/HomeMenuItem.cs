using System;
using System.Collections.Generic;
using System.Text;

namespace TravelEurope.Mobile.Models
{
    public enum MenuItemType
    {
        Prijatelji,
        Ponuda,
        Pretplate,
        Preporuke,
        Profil,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
