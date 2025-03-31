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
    public partial class MainForm : Form
    {
        private PetHotelApp.Models.User _currentUser;

        public MainForm(PetHotelApp.Models.User user)
        {
            InitializeComponent();
            _currentUser = user;

            lblWelcome.Text = $"Welcome, {_currentUser.Username}!";

            btnManagePets.Visible = true;
            btnBookRoom.Visible = true;
            btnViewReservations.Visible = true;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
        private void btnManagePets_Click(object sender, EventArgs e)
        {
            new PetManagementForm(_currentUser).Show();
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            new RoomBookingForm(_currentUser).Show();
        }

        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            new ReservationViewForm(_currentUser).Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // This can be empty or used for initializing UI components
        }

        private void btnManagePets_Click_1(object sender, EventArgs e)
        {
            new PetManagementForm(_currentUser).Show();
        }

        private void btnBookRoom_Click_1(object sender, EventArgs e)
        {
            new RoomBookingForm(_currentUser).Show();
        }

        private void btnViewReservations_Click_1(object sender, EventArgs e)
        {
            new ReservationViewForm(_currentUser).Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}