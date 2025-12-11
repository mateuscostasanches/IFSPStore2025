namespace IFSPStore.App.Register
{
    partial class CustomerForm
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
            txtDistrict = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCityState = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDocument = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            TabPageRegister.Controls.Add(txtDocument);
            TabPageRegister.Controls.Add(txtCityState);
            TabPageRegister.Controls.Add(txtDistrict);
            TabPageRegister.Controls.Add(txtName);
            TabPageRegister.Controls.Add(txtId);
            TabPageRegister.Size = new Size(786, 348);
            TabPageRegister.Controls.SetChildIndex(txtId, 0);
            TabPageRegister.Controls.SetChildIndex(txtName, 0);
            TabPageRegister.Controls.SetChildIndex(txtDistrict, 0);
            TabPageRegister.Controls.SetChildIndex(txtCityState, 0);
            TabPageRegister.Controls.SetChildIndex(txtDocument, 0);
            // 
            // txtDistrict
            // 
            txtDistrict.AnimateReadOnly = false;
            txtDistrict.AutoCompleteMode = AutoCompleteMode.None;
            txtDistrict.AutoCompleteSource = AutoCompleteSource.None;
            txtDistrict.BackgroundImageLayout = ImageLayout.None;
            txtDistrict.CharacterCasing = CharacterCasing.Normal;
            txtDistrict.Depth = 0;
            txtDistrict.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDistrict.HideSelection = true;
            txtDistrict.Hint = "District";
            txtDistrict.LeadingIcon = null;
            txtDistrict.Location = new Point(333, 127);
            txtDistrict.MaxLength = 32767;
            txtDistrict.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDistrict.Name = "txtDistrict";
            txtDistrict.PasswordChar = '\0';
            txtDistrict.PrefixSuffixText = null;
            txtDistrict.ReadOnly = false;
            txtDistrict.RightToLeft = RightToLeft.No;
            txtDistrict.SelectedText = "";
            txtDistrict.SelectionLength = 0;
            txtDistrict.SelectionStart = 0;
            txtDistrict.ShortcutsEnabled = true;
            txtDistrict.Size = new Size(386, 48);
            txtDistrict.TabIndex = 12;
            txtDistrict.TabStop = false;
            txtDistrict.TextAlign = HorizontalAlignment.Left;
            txtDistrict.TrailingIcon = null;
            txtDistrict.UseSystemPasswordChar = false;
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
            txtName.Hint = "Name";
            txtName.LeadingIcon = null;
            txtName.Location = new Point(50, 73);
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
            txtName.Size = new Size(475, 48);
            txtName.TabIndex = 11;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(531, 73);
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
            txtId.Size = new Size(188, 48);
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtCityState
            // 
            txtCityState.AutoResize = false;
            txtCityState.BackColor = Color.FromArgb(255, 255, 255);
            txtCityState.Depth = 0;
            txtCityState.DrawMode = DrawMode.OwnerDrawVariable;
            txtCityState.DropDownHeight = 174;
            txtCityState.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCityState.DropDownWidth = 121;
            txtCityState.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtCityState.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtCityState.FormattingEnabled = true;
            txtCityState.Hint = "City - State";
            txtCityState.IntegralHeight = false;
            txtCityState.ItemHeight = 43;
            txtCityState.Location = new Point(50, 127);
            txtCityState.MaxDropDownItems = 4;
            txtCityState.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCityState.Name = "txtCityState";
            txtCityState.Size = new Size(277, 49);
            txtCityState.StartIndex = 0;
            txtCityState.TabIndex = 13;
            // 
            // txtDocument
            // 
            txtDocument.AllowPromptAsInput = true;
            txtDocument.AnimateReadOnly = false;
            txtDocument.AsciiOnly = false;
            txtDocument.BackgroundImageLayout = ImageLayout.None;
            txtDocument.BeepOnError = false;
            txtDocument.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDocument.Depth = 0;
            txtDocument.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDocument.HidePromptOnLeave = false;
            txtDocument.HideSelection = true;
            txtDocument.Hint = "Document";
            txtDocument.InsertKeyMode = InsertKeyMode.Default;
            txtDocument.LeadingIcon = null;
            txtDocument.Location = new Point(50, 182);
            txtDocument.Mask = "";
            txtDocument.MaxLength = 32767;
            txtDocument.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDocument.Name = "txtDocument";
            txtDocument.PasswordChar = '\0';
            txtDocument.PrefixSuffixText = null;
            txtDocument.PromptChar = '_';
            txtDocument.ReadOnly = false;
            txtDocument.RejectInputOnFirstFailure = false;
            txtDocument.ResetOnPrompt = true;
            txtDocument.ResetOnSpace = true;
            txtDocument.RightToLeft = RightToLeft.No;
            txtDocument.SelectedText = "";
            txtDocument.SelectionLength = 0;
            txtDocument.SelectionStart = 0;
            txtDocument.ShortcutsEnabled = true;
            txtDocument.Size = new Size(669, 48);
            txtDocument.SkipLiterals = true;
            txtDocument.TabIndex = 15;
            txtDocument.TabStop = false;
            txtDocument.Text = "999.999.999-99";
            txtDocument.TextAlign = HorizontalAlignment.Left;
            txtDocument.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtDocument.TrailingIcon = null;
            txtDocument.UseSystemPasswordChar = false;
            txtDocument.ValidatingType = null;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CustomerForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Register";
            Load += CustomerForm_Load;
            tabControlRegister.ResumeLayout(false);
            TabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox txtCityState;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDistrict;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDocument;
    }
}