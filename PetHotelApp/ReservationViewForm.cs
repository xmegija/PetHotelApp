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

            SetupListView();
            LoadReservations();
        }

        private void SetupListView()
        {
            lvReservations.View = View.Details;
            lvReservations.FullRowSelect = true;
            lvReservations.GridLines = true;

            lvReservations.Columns.Clear();
            lvReservations.Columns.Add("ID", 50);
            lvReservations.Columns.Add("Pet", 100);
            lvReservations.Columns.Add("Room", 100);
            lvReservations.Columns.Add("Start Date", 100);
            lvReservations.Columns.Add("End Date", 100);
        }

        private void LoadReservations()
        {
            lvReservations.Items.Clear();

            var reservations = _context.Reservations
                .Where(r => r.Pet.OwnerId == _currentUser.Id)
                .Select(r => new
                {
                    r.Id,
                    PetName = r.Pet.Name,
                    Room = r.Room.RoomNumber,
                    Start = r.StartDate,
                    End = r.EndDate
                })
                .ToList();

            foreach (var res in reservations)
            {
                var item = new ListViewItem(res.Id.ToString());
                item.SubItems.Add(res.PetName);
                item.SubItems.Add(res.Room);
                item.SubItems.Add(res.Start.ToShortDateString());
                item.SubItems.Add(res.End.ToShortDateString());

                lvReservations.Items.Add(item);
            }
        }
    }
}
