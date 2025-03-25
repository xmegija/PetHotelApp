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
    public partial class PetManagementForm : Form
    {
        private AppDbContext _context;
        private PetHotelApp.Models.User _currentUser;

        public PetManagementForm(PetHotelApp.Models.User user)
        {
            InitializeComponent();
            _currentUser = user;
            _context = new AppDbContext();
            LoadPets();
        }

        private void LoadPets()
        {
            lvPets.Items.Clear();
            var pets = _context.Pets.Where(p => p.OwnerId == _currentUser.Id).ToList();

            foreach (var pet in pets)
            {
                var item = new ListViewItem(new[] { pet.Id.ToString(), pet.Name, pet.Type });
                lvPets.Items.Add(item);
            }
        }


        private void PetManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            var pet = new Pet
            {
                Name = txtPetName.Text,
                Type = txtPetType.Text,
                OwnerId = _currentUser.Id
            };

            _context.Pets.Add(pet);
            _context.SaveChanges();
            LoadPets();
        }

        private void btnRemovePet_Click(object sender, EventArgs e)
        {
            if (lvPets.SelectedItems.Count == 0) return;

            int petId = int.Parse(lvPets.SelectedItems[0].Text);
            var pet = _context.Pets.Find(petId);

            if (pet != null)
            {
                _context.Pets.Remove(pet);
                _context.SaveChanges();
                LoadPets();
            }
        }
    }
}
