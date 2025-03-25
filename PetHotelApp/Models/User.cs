using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHotelApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // "Admin" or "User"

        public List<Pet> Pets { get; set; }

        public static explicit operator User(User v)
        {
            throw new NotImplementedException();
        }
    }
}
