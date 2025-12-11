namespace IFSPStore.App.Register
{
    partial class ProductForm
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
            txtName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCategory = new ReaLTaiizor.Controls.MaterialComboBox();
            txtSalesUnit = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            TabPageRegister.Controls.Add(txtPrice);
            TabPageRegister.Controls.Add(txtSalesUnit);
            TabPageRegister.Controls.Add(txtCategory);
            TabPageRegister.Controls.Add(txtName);
            TabPageRegister.Controls.Add(txtId);
            TabPageRegister.Size = new Size(786, 348);
            TabPageRegister.Controls.SetChildIndex(txtId, 0);
            TabPageRegister.Controls.SetChildIndex(txtName, 0);
            TabPageRegister.Controls.SetChildIndex(txtCategory, 0);
            TabPageRegister.Controls.SetChildIndex(txtSalesUnit, 0);
            TabPageRegister.Controls.SetChildIndex(txtPrice, 0);
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
            txtName.Location = new Point(48, 99);
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
            txtName.TabIndex = 13;
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
            txtId.Location = new Point(529, 99);
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
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtCategory
            // 
            txtCategory.AutoResize = false;
            txtCategory.BackColor = Color.FromArgb(255, 255, 255);
            txtCategory.Depth = 0;
            txtCategory.DrawMode = DrawMode.OwnerDrawVariable;
            txtCategory.DropDownHeight = 174;
            txtCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCategory.DropDownWidth = 121;
            txtCategory.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtCategory.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtCategory.FormattingEnabled = true;
            txtCategory.Hint = "Category";
            txtCategory.IntegralHeight = false;
            txtCategory.ItemHeight = 43;
            txtCategory.Location = new Point(48, 153);
            txtCategory.MaxDropDownItems = 4;
            txtCategory.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(282, 49);
            txtCategory.StartIndex = 0;
            txtCategory.TabIndex = 14;
            // 
            // txtSalesUnit
            // 
            txtSalesUnit.AnimateReadOnly = false;
            txtSalesUnit.AutoCompleteMode = AutoCompleteMode.None;
            txtSalesUnit.AutoCompleteSource = AutoCompleteSource.None;
            txtSalesUnit.BackgroundImageLayout = ImageLayout.None;
            txtSalesUnit.CharacterCasing = CharacterCasing.Normal;
            txtSalesUnit.Depth = 0;
            txtSalesUnit.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalesUnit.HideSelection = true;
            txtSalesUnit.Hint = "Sales Unit";
            txtSalesUnit.LeadingIcon = null;
            txtSalesUnit.Location = new Point(529, 153);
            txtSalesUnit.MaxLength = 32767;
            txtSalesUnit.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSalesUnit.Name = "txtSalesUnit";
            txtSalesUnit.PasswordChar = '\0';
            txtSalesUnit.PrefixSuffixText = null;
            txtSalesUnit.ReadOnly = false;
            txtSalesUnit.RightToLeft = RightToLeft.No;
            txtSalesUnit.SelectedText = "";
            txtSalesUnit.SelectionLength = 0;
            txtSalesUnit.SelectionStart = 0;
            txtSalesUnit.ShortcutsEnabled = true;
            txtSalesUnit.Size = new Size(187, 48);
            txtSalesUnit.TabIndex = 17;
            txtSalesUnit.TabStop = false;
            txtSalesUnit.TextAlign = HorizontalAlignment.Left;
            txtSalesUnit.TrailingIcon = null;
            txtSalesUnit.UseSystemPasswordChar = false;
            // 
            // txtPrice
            // 
            txtPrice.AllowPromptAsInput = true;
            txtPrice.AnimateReadOnly = false;
            txtPrice.AsciiOnly = false;
            txtPrice.BackgroundImageLayout = ImageLayout.None;
            txtPrice.BeepOnError = false;
            txtPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrice.Depth = 0;
            txtPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrice.HidePromptOnLeave = false;
            txtPrice.HideSelection = true;
            txtPrice.Hint = "Price";
            txtPrice.InsertKeyMode = InsertKeyMode.Default;
            txtPrice.LeadingIcon = null;
            txtPrice.Location = new Point(335, 154);
            txtPrice.Mask = "";
            txtPrice.MaxLength = 32767;
            txtPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PrefixSuffixText = null;
            txtPrice.PromptChar = '_';
            txtPrice.ReadOnly = false;
            txtPrice.RejectInputOnFirstFailure = false;
            txtPrice.ResetOnPrompt = true;
            txtPrice.ResetOnSpace = true;
            txtPrice.RightToLeft = RightToLeft.No;
            txtPrice.SelectedText = "";
            txtPrice.SelectionLength = 0;
            txtPrice.SelectionStart = 0;
            txtPrice.ShortcutsEnabled = true;
            txtPrice.Size = new Size(188, 48);
            txtPrice.SkipLiterals = true;
            txtPrice.TabIndex = 19;
            txtPrice.TabStop = false;
            txtPrice.TextAlign = HorizontalAlignment.Left;
            txtPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrice.TrailingIcon = null;
            txtPrice.UseSystemPasswordChar = false;
            txtPrice.ValidatingType = null;
            txtPrice.Leave += txtPrice_Leave;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "ProductForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Register";
            Load += ProductForm_Load;
            tabControlRegister.ResumeLayout(false);
            TabPageRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox txtCategory;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSalesUnit;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPrice;
    }
}