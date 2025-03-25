using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetHotelApp.Data;
using PetHotelApp.Models;

namespace PetHotelApp
{
    public partial class RoomBookingForm : Form
    {

        private AppDbContext _context;
        private PetHotelApp.Models.User _currentUser;

        public RoomBookingForm(PetHotelApp.Models.User user)
        {
            InitializeComponent();
            _currentUser = user;
            _context = new AppDbContext();
            LoadPets();
            LoadRooms();
        }

        private void LoadPets()
        {
            cmbPets.Items.Clear();
            var pets = _context.Pets.Where(p => p.OwnerId == _currentUser.Id).ToList();
            foreach (var pet in pets)
            {
                cmbPets.Items.Add(new { pet.Id, pet.Name });
            }
        }
        private void LoadRooms()
        {
            cmbRooms.Items.Clear();
            var rooms = _context.Rooms.Where(r => !r.IsOccupied).ToList();
            foreach (var room in rooms)
            {
                cmbRooms.Items.Add(new { room.Id, room.RoomNumber });
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbPets.SelectedItem == null || cmbRooms.SelectedItem == null) return;

            var selectedPet = (dynamic)cmbPets.SelectedItem;
            var selectedRoom = (dynamic)cmbRooms.SelectedItem;

            var reservation = new Reservation
            {
                PetId = selectedPet.Id,
                RoomId = selectedRoom.Id,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            MessageBox.Show("Room booked successfully!");
        }
    }
}
