namespace IFSPStore.App.Register
{
    partial class CityForm
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtState = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabControlRegister.SuspendLayout();
            TabPageRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(794, 383);
            // 
            // TabPageRegister
            // 
            TabPageRegister.Controls.Add(txtState);
            TabPageRegister.Controls.Add(txtName);
            TabPageRegister.Controls.Add(txtId);
            TabPageRegister.Size = new Size(786, 348);
            TabPageRegister.Controls.SetChildIndex(txtId, 0);
            TabPageRegister.Controls.SetChildIndex(txtName, 0);
            TabPageRegister.Controls.SetChildIndex(txtState, 0);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Enabled = false;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.LeadingIcon = Properties.Resources.id;
            txtId.Location = new Point(250, 174);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(250, 48);
            txtId.TabIndex = 7;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            txtName.AnimateReadOnly = false;
            txtName.AutoCompleteMode = AutoCompleteMode.None;
            txtName.AutoCompleteSource = AutoCompleteSource.None;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Depth = 0;
            txtName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HideSelection = true;
            txtName.Hint = "City";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(250, 66);
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.ReadOnly = false;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(250, 48);
            txtName.TabIndex = 8;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtState
            // 
            txtState.AnimateReadOnly = false;
            txtState.AutoCompleteMode = AutoCompleteMode.None;
            txtState.AutoCompleteSource = AutoCompleteSource.None;
            txtState.BackgroundImageLayout = ImageLayout.None;
            txtState.CharacterCasing = CharacterCasing.Normal;
            txtState.Depth = 0;
            txtState.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtState.HideSelection = true;
            txtState.Hint = "State";
            txtState.LeadingIcon = null;
            txtState.Location = new Point(250, 120);
            txtState.MaxLength = 32767;
            txtState.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtState.Name = "txtState";
            txtState.PasswordChar = '\0';
            txtState.PrefixSuffixText = null;
            txtState.ReadOnly = false;
            txtState.RightToLeft = RightToLeft.No;
            txtState.SelectedText = "";
            txtState.SelectionLength = 0;
            txtState.SelectionStart = 0;
            txtState.ShortcutsEnabled = true;
            txtState.Size = new Size(250, 48);
            txtState.TabIndex = 9;
            txtState.TabStop = false;
            txtState.TextAlign = HorizontalAlignment.Left;
            txtState.TrailingIcon = null;
            txtState.UseSystemPasswordChar = false;
            // 
            // CityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CityForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "City Register";
            Load += CityForm_Load;
            tabControlRegister.ResumeLayout(false);
            TabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtState;
    }
}