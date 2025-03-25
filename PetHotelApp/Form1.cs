using PetHotelApp.Services;

namespace PetHotelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AuthService authService = new AuthService();
            var user = authService.Login(txtUsername.Text, txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.Username}! Role: {user.Role}");
                new MainForm(user).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AuthService authService = new AuthService();
            bool success = authService.Register(txtUsername.Text, txtPassword.Text, "User");

            if (success)
                MessageBox.Show("Registration successful!");
            else
                MessageBox.Show("Username already exists!");

        }
    }
}
