namespace PetHotelApp
{
    partial class RoomBookingForm
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
            cmbPets = new MaterialSkin.Controls.MaterialComboBox();
            cmbRooms = new MaterialSkin.Controls.MaterialComboBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnBook = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // cmbPets
            // 
            cmbPets.AutoResize = false;
            cmbPets.BackColor = Color.FromArgb(255, 255, 255);
            cmbPets.Depth = 0;
            cmbPets.DrawMode = DrawMode.OwnerDrawVariable;
            cmbPets.DropDownHeight = 174;
            cmbPets.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPets.DropDownWidth = 121;
            cmbPets.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbPets.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbPets.FormattingEnabled = true;
            cmbPets.IntegralHeight = false;
            cmbPets.ItemHeight = 43;
            cmbPets.Location = new Point(33, 44);
            cmbPets.MaxDropDownItems = 4;
            cmbPets.MouseState = MaterialSkin.MouseState.OUT;
            cmbPets.Name = "cmbPets";
            cmbPets.Size = new Size(200, 49);
            cmbPets.StartIndex = 0;
            cmbPets.TabIndex = 0;
            // 
            // cmbRooms
            // 
            cmbRooms.AutoResize = false;
            cmbRooms.BackColor = Color.FromArgb(255, 255, 255);
            cmbRooms.Depth = 0;
            cmbRooms.DrawMode = DrawMode.OwnerDrawVariable;
            cmbRooms.DropDownHeight = 174;
            cmbRooms.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRooms.DropDownWidth = 121;
            cmbRooms.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbRooms.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbRooms.FormattingEnabled = true;
            cmbRooms.IntegralHeight = false;
            cmbRooms.ItemHeight = 43;
            cmbRooms.Location = new Point(33, 110);
            cmbRooms.MaxDropDownItems = 4;
            cmbRooms.MouseState = MaterialSkin.MouseState.OUT;
            cmbRooms.Name = "cmbRooms";
            cmbRooms.Size = new Size(200, 49);
            cmbRooms.StartIndex = 0;
            cmbRooms.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(33, 178);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(33, 221);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 3;
            // 
            // btnBook
            // 
            btnBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnBook.Depth = 0;
            btnBook.HighEmphasis = true;
            btnBook.Icon = null;
            btnBook.Location = new Point(96, 264);
            btnBook.Margin = new Padding(4, 6, 4, 6);
            btnBook.MouseState = MaterialSkin.MouseState.HOVER;
            btnBook.Name = "btnBook";
            btnBook.NoAccentTextColor = Color.Empty;
            btnBook.Size = new Size(64, 36);
            btnBook.TabIndex = 4;
            btnBook.Text = "Book";
            btnBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnBook.UseAccentColor = false;
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // RoomBookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(291, 450);
            Controls.Add(btnBook);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(cmbRooms);
            Controls.Add(cmbPets);
            Name = "RoomBookingForm";
            Text = "RoomBookingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cmbPets;
        private MaterialSkin.Controls.MaterialComboBox cmbRooms;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private MaterialSkin.Controls.MaterialButton btnBook;
    }
}