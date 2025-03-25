namespace PetHotelApp
{
    partial class PetManagementForm
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
            lvPets = new MaterialSkin.Controls.MaterialListView();
            txtPetName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnAddPet = new MaterialSkin.Controls.MaterialButton();
            txtPetType = new MaterialSkin.Controls.MaterialMaskedTextBox();
            btnRemovePet = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // lvPets
            // 
            lvPets.AutoSizeTable = false;
            lvPets.BackColor = Color.FromArgb(255, 255, 255);
            lvPets.BorderStyle = BorderStyle.None;
            lvPets.Depth = 0;
            lvPets.FullRowSelect = true;
            lvPets.Location = new Point(43, 46);
            lvPets.MinimumSize = new Size(200, 100);
            lvPets.MouseLocation = new Point(-1, -1);
            lvPets.MouseState = MaterialSkin.MouseState.OUT;
            lvPets.Name = "lvPets";
            lvPets.OwnerDraw = true;
            lvPets.Size = new Size(200, 100);
            lvPets.TabIndex = 0;
            lvPets.UseCompatibleStateImageBehavior = false;
            lvPets.View = View.Details;
            // 
            // txtPetName
            // 
            txtPetName.AllowPromptAsInput = true;
            txtPetName.AnimateReadOnly = false;
            txtPetName.AsciiOnly = false;
            txtPetName.BackgroundImageLayout = ImageLayout.None;
            txtPetName.BeepOnError = false;
            txtPetName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPetName.Depth = 0;
            txtPetName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPetName.HidePromptOnLeave = false;
            txtPetName.HideSelection = true;
            txtPetName.InsertKeyMode = InsertKeyMode.Default;
            txtPetName.LeadingIcon = null;
            txtPetName.Location = new Point(43, 179);
            txtPetName.Mask = "";
            txtPetName.MaxLength = 32767;
            txtPetName.MouseState = MaterialSkin.MouseState.OUT;
            txtPetName.Name = "txtPetName";
            txtPetName.PasswordChar = '\0';
            txtPetName.PrefixSuffixText = null;
            txtPetName.PromptChar = '_';
            txtPetName.ReadOnly = false;
            txtPetName.RejectInputOnFirstFailure = false;
            txtPetName.ResetOnPrompt = true;
            txtPetName.ResetOnSpace = true;
            txtPetName.RightToLeft = RightToLeft.No;
            txtPetName.SelectedText = "";
            txtPetName.SelectionLength = 0;
            txtPetName.SelectionStart = 0;
            txtPetName.ShortcutsEnabled = true;
            txtPetName.Size = new Size(250, 48);
            txtPetName.SkipLiterals = true;
            txtPetName.TabIndex = 1;
            txtPetName.TabStop = false;
            txtPetName.Text = "PetName";
            txtPetName.TextAlign = HorizontalAlignment.Left;
            txtPetName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPetName.TrailingIcon = null;
            txtPetName.UseSystemPasswordChar = false;
            txtPetName.ValidatingType = null;
            // 
            // btnAddPet
            // 
            btnAddPet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddPet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddPet.Depth = 0;
            btnAddPet.HighEmphasis = true;
            btnAddPet.Icon = null;
            btnAddPet.Location = new Point(117, 291);
            btnAddPet.Margin = new Padding(4, 6, 4, 6);
            btnAddPet.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddPet.Name = "btnAddPet";
            btnAddPet.NoAccentTextColor = Color.Empty;
            btnAddPet.Size = new Size(77, 36);
            btnAddPet.TabIndex = 2;
            btnAddPet.Text = "AddPet";
            btnAddPet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddPet.UseAccentColor = false;
            btnAddPet.UseVisualStyleBackColor = true;
            btnAddPet.Click += btnAddPet_Click;
            // 
            // txtPetType
            // 
            txtPetType.AllowPromptAsInput = true;
            txtPetType.AnimateReadOnly = false;
            txtPetType.AsciiOnly = false;
            txtPetType.BackgroundImageLayout = ImageLayout.None;
            txtPetType.BeepOnError = false;
            txtPetType.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPetType.Depth = 0;
            txtPetType.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPetType.HidePromptOnLeave = false;
            txtPetType.HideSelection = true;
            txtPetType.InsertKeyMode = InsertKeyMode.Default;
            txtPetType.LeadingIcon = null;
            txtPetType.Location = new Point(308, 179);
            txtPetType.Mask = "";
            txtPetType.MaxLength = 32767;
            txtPetType.MouseState = MaterialSkin.MouseState.OUT;
            txtPetType.Name = "txtPetType";
            txtPetType.PasswordChar = '\0';
            txtPetType.PrefixSuffixText = null;
            txtPetType.PromptChar = '_';
            txtPetType.ReadOnly = false;
            txtPetType.RejectInputOnFirstFailure = false;
            txtPetType.ResetOnPrompt = true;
            txtPetType.ResetOnSpace = true;
            txtPetType.RightToLeft = RightToLeft.No;
            txtPetType.SelectedText = "";
            txtPetType.SelectionLength = 0;
            txtPetType.SelectionStart = 0;
            txtPetType.ShortcutsEnabled = true;
            txtPetType.Size = new Size(250, 48);
            txtPetType.SkipLiterals = true;
            txtPetType.TabIndex = 3;
            txtPetType.TabStop = false;
            txtPetType.Text = "PetType";
            txtPetType.TextAlign = HorizontalAlignment.Left;
            txtPetType.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPetType.TrailingIcon = null;
            txtPetType.UseSystemPasswordChar = false;
            txtPetType.ValidatingType = null;
            // 
            // btnRemovePet
            // 
            btnRemovePet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemovePet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemovePet.Depth = 0;
            btnRemovePet.HighEmphasis = true;
            btnRemovePet.Icon = null;
            btnRemovePet.Location = new Point(308, 291);
            btnRemovePet.Margin = new Padding(4, 6, 4, 6);
            btnRemovePet.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemovePet.Name = "btnRemovePet";
            btnRemovePet.NoAccentTextColor = Color.Empty;
            btnRemovePet.Size = new Size(158, 36);
            btnRemovePet.TabIndex = 4;
            btnRemovePet.Text = "RemovePet";
            btnRemovePet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRemovePet.UseAccentColor = false;
            btnRemovePet.UseVisualStyleBackColor = true;
            btnRemovePet.Click += btnRemovePet_Click;
            // 
            // PetManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemovePet);
            Controls.Add(txtPetType);
            Controls.Add(btnAddPet);
            Controls.Add(txtPetName);
            Controls.Add(lvPets);
            Name = "PetManagementForm";
            Text = "PetManagementForm";
            Load += PetManagementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView lvPets;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPetName;
        private MaterialSkin.Controls.MaterialButton btnAddPet;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPetType;
        private MaterialSkin.Controls.MaterialButton btnRemovePet;
    }
}