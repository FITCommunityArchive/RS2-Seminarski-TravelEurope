using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEurope.WebAPI.Database
{
    public class KorisniciFriends
    {
        [Key]
        public int KorisniciFriendsId { get; set; }

        public int KorisnikId { get; set; }
        public Korisnici Korisnik { get; set; }

        public int FriendId { get; set; }
        public Korisnici Friend { get; set; }

    }
}
