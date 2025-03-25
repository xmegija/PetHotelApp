using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHotelApp.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // e.g., Dog, Cat
        public int OwnerId { get; set; }
        public User Owner { get; set; }

        public List<Reservation> Reservations { get; set; }
    }

}
