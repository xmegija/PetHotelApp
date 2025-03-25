using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHotelApp.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public bool IsOccupied { get; set; }

        public List<Reservation> Reservations { get; set; }
    }

}
