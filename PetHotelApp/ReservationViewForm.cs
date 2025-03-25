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

namespace PetHotelApp
{
    public partial class ReservationViewForm : Form
    {

        private AppDbContext _context;
        private PetHotelApp.Models.User _currentUser;

        public ReservationViewForm(PetHotelApp.Models.User user)
        {
            InitializeComponent();
            _currentUser = user;
            _context = new AppDbContext();
            LoadReservations();
        }
        private void LoadReservations()
        {
            lvReservations.Items.Clear();
            var reservations = _context.Reservations
                .Where(r => r.Pet.OwnerId == _currentUser.Id)
                .Select(r => new { r.Id, r.Pet.Name, r.Room.RoomNumber, r.StartDate, r.EndDate })
                .ToList();

            foreach (var res in reservations)
            {
                var item = new ListViewItem(new[] { res.Id.ToString(), res.Name, res.RoomNumber, res.StartDate.ToShortDateString(), res.EndDate.ToShortDateString() });
                lvReservations.Items.Add(item);
            }
        }
    }
}
