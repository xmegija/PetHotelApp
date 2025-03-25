namespace PetHotelApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new MaterialSkin.Controls.MaterialLabel();
            btnManagePets = new MaterialSkin.Controls.MaterialButton();
            btnBookRoom = new MaterialSkin.Controls.MaterialButton();
            btnViewReservations = new MaterialSkin.Controls.MaterialButton();
            btnLogout = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Depth = 0;
            lblWelcome.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblWelcome.Location = new Point(85, 74);
            lblWelcome.MouseState = MaterialSkin.MouseState.HOVER;
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(66, 19);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // btnManagePets
            // 
            btnManagePets.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManagePets.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnManagePets.Depth = 0;
            btnManagePets.HighEmphasis = true;
            btnManagePets.Icon = null;
            btnManagePets.Location = new Point(71, 169);
            btnManagePets.Margin = new Padding(4, 6, 4, 6);
            btnManagePets.MouseState = MaterialSkin.MouseState.HOVER;
            btnManagePets.Name = "btnManagePets";
            btnManagePets.NoAccentTextColor = Color.Empty;
            btnManagePets.Size = new Size(64, 36);
            btnManagePets.TabIndex = 1;
            btnManagePets.Text = "Pets";
            btnManagePets.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnManagePets.UseAccentColor = false;
            btnManagePets.UseVisualStyleBackColor = true;
            // 
            // btnBookRoom
            // 
            btnBookRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBookRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBookRoom.Depth = 0;
            btnBookRoom.HighEmphasis = true;
            btnBookRoom.Icon = null;
            btnBookRoom.Location = new Point(85, 217);
            btnBookRoom.Margin = new Padding(4, 6, 4, 6);
            btnBookRoom.MouseState = MaterialSkin.MouseState.HOVER;
            btnBookRoom.Name = "btnBookRoom";
            btnBookRoom.NoAccentTextColor = Color.Empty;
            btnBookRoom.Size = new Size(106, 36);
            btnBookRoom.TabIndex = 2;
            btnBookRoom.Text = "Book Room";
            btnBookRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBookRoom.UseAccentColor = false;
            btnBookRoom.UseVisualStyleBackColor = true;
            // 
            // btnViewReservations
            // 
            btnViewReservations.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewReservations.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnViewReservations.Depth = 0;
            btnViewReservations.HighEmphasis = true;
            btnViewReservations.Icon = null;
            btnViewReservations.Location = new Point(96, 265);
            btnViewReservations.Margin = new Padding(4, 6, 4, 6);
            btnViewReservations.MouseState = MaterialSkin.MouseState.HOVER;
            btnViewReservations.Name = "btnViewReservations";
            btnViewReservations.NoAccentTextColor = Color.Empty;
            btnViewReservations.Size = new Size(162, 36);
            btnViewReservations.TabIndex = 3;
            btnViewReservations.Text = "ViewReservations";
            btnViewReservations.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnViewReservations.UseAccentColor = false;
            btnViewReservations.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.Location = new Point(120, 313);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(158, 36);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = false;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnViewReservations);
            Controls.Add(btnBookRoom);
            Controls.Add(btnManagePets);
            Controls.Add(lblWelcome);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblWelcome;
        private MaterialSkin.Controls.MaterialButton btnManagePets;
        private MaterialSkin.Controls.MaterialButton btnBookRoom;
        private MaterialSkin.Controls.MaterialButton btnViewReservations;
        private MaterialSkin.Controls.MaterialButton btnLogout;
    }
}