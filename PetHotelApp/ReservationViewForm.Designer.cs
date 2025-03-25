namespace PetHotelApp
{
    partial class ReservationViewForm
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
            lvReservations = new MaterialSkin.Controls.MaterialListView();
            SuspendLayout();
            // 
            // lvReservations
            // 
            lvReservations.AutoSizeTable = false;
            lvReservations.BackColor = Color.FromArgb(255, 255, 255);
            lvReservations.BorderStyle = BorderStyle.None;
            lvReservations.Depth = 0;
            lvReservations.FullRowSelect = true;
            lvReservations.Location = new Point(211, 139);
            lvReservations.MinimumSize = new Size(200, 100);
            lvReservations.MouseLocation = new Point(-1, -1);
            lvReservations.MouseState = MaterialSkin.MouseState.OUT;
            lvReservations.Name = "lvReservations";
            lvReservations.OwnerDraw = true;
            lvReservations.Size = new Size(200, 100);
            lvReservations.TabIndex = 0;
            lvReservations.UseCompatibleStateImageBehavior = false;
            lvReservations.View = View.Details;
            // 
            // ReservationViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvReservations);
            Name = "ReservationViewForm";
            Text = "ReservationViewForm";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView lvReservations;
    }
}