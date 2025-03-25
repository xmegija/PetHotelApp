using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using PetHotelApp.Data;
using PetHotelApp.Models;

namespace PetHotelApp.Services
{
    public class AuthService
    {
        private readonly AppDbContext _context;

        public AuthService() { _context = new AppDbContext(); }

        public bool Register(string username, string password, string role)
        {
            if (_context.Users.Any(u => u.Username == username)) return false;

            var user = new User
            {
                Username = username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(password),
                Role = role
            };

            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public User Login(string username, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == username);
            return (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash)) ? user : null;
        }
    }
}
