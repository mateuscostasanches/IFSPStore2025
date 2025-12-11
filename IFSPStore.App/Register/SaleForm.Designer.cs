namespace IFSPStore.App.Register
{
    partial class SaleForm
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
            txtUser = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCustomer = new ReaLTaiizor.Controls.MaterialComboBox();
            gpboxSaleItem = new GroupBox();
            btnRemove = new ReaLTaiizor.Controls.MaterialButton();
            txtQuantity = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtTotalPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtUnitPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnAdd = new ReaLTaiizor.Controls.MaterialButton();
            lblQuantityItems = new Label();
            lblValue = new Label();
            dataGridViewSaleItems = new DataGridView();
            txtProduct = new ReaLTaiizor.Controls.MaterialComboBox();
            tabControlRegister.SuspendLayout();
            TabPageRegister.SuspendLayout();
            gpboxSaleItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaleItems).BeginInit();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(794, 474);
            // 
            // TabPageRegister
            // 
            TabPageRegister.Controls.Add(gpboxSaleItem);
            TabPageRegister.Controls.Add(txtCustomer);
            TabPageRegister.Controls.Add(txtUser);
            TabPageRegister.Controls.Add(txtId);
            TabPageRegister.Size = new Size(786, 439);
            TabPageRegister.Controls.SetChildIndex(txtId, 0);
            TabPageRegister.Controls.SetChildIndex(txtUser, 0);
            TabPageRegister.Controls.SetChildIndex(txtCustomer, 0);
            TabPageRegister.Controls.SetChildIndex(gpboxSaleItem, 0);
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
            txtId.Location = new Point(637, 16);
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
            txtId.Size = new Size(129, 48);
            txtId.TabIndex = 13;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtUser
            // 
            txtUser.AutoResize = false;
            txtUser.BackColor = Color.FromArgb(255, 255, 255);
            txtUser.Depth = 0;
            txtUser.DrawMode = DrawMode.OwnerDrawVariable;
            txtUser.DropDownHeight = 174;
            txtUser.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUser.DropDownWidth = 121;
            txtUser.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtUser.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtUser.FormattingEnabled = true;
            txtUser.Hint = "User";
            txtUser.IntegralHeight = false;
            txtUser.ItemHeight = 43;
            txtUser.Location = new Point(16, 16);
            txtUser.MaxDropDownItems = 4;
            txtUser.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(300, 49);
            txtUser.StartIndex = 0;
            txtUser.TabIndex = 14;
            // 
            // txtCustomer
            // 
            txtCustomer.AutoResize = false;
            txtCustomer.BackColor = Color.FromArgb(255, 255, 255);
            txtCustomer.Depth = 0;
            txtCustomer.DrawMode = DrawMode.OwnerDrawVariable;
            txtCustomer.DropDownHeight = 174;
            txtCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCustomer.DropDownWidth = 121;
            txtCustomer.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtCustomer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtCustomer.FormattingEnabled = true;
            txtCustomer.Hint = "Customer";
            txtCustomer.IntegralHeight = false;
            txtCustomer.ItemHeight = 43;
            txtCustomer.Location = new Point(322, 16);
            txtCustomer.MaxDropDownItems = 4;
            txtCustomer.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(309, 49);
            txtCustomer.StartIndex = 0;
            txtCustomer.TabIndex = 15;
            // 
            // gpboxSaleItem
            // 
            gpboxSaleItem.Controls.Add(btnRemove);
            gpboxSaleItem.Controls.Add(txtQuantity);
            gpboxSaleItem.Controls.Add(txtTotalPrice);
            gpboxSaleItem.Controls.Add(txtUnitPrice);
            gpboxSaleItem.Controls.Add(btnAdd);
            gpboxSaleItem.Controls.Add(lblQuantityItems);
            gpboxSaleItem.Controls.Add(lblValue);
            gpboxSaleItem.Controls.Add(dataGridViewSaleItems);
            gpboxSaleItem.Controls.Add(txtProduct);
            gpboxSaleItem.Location = new Point(16, 71);
            gpboxSaleItem.Name = "gpboxSaleItem";
            gpboxSaleItem.Size = new Size(750, 304);
            gpboxSaleItem.TabIndex = 17;
            gpboxSaleItem.TabStop = false;
            gpboxSaleItem.Text = "Sale Items";
            // 
            // btnRemove
            // 
            btnRemove.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemove.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemove.Depth = 0;
            btnRemove.HighEmphasis = true;
            btnRemove.Icon = null;
            btnRemove.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRemove.Location = new Point(670, 68);
            btnRemove.Margin = new Padding(4, 6, 4, 6);
            btnRemove.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRemove.Name = "btnRemove";
            btnRemove.NoAccentTextColor = Color.Empty;
            btnRemove.Size = new Size(64, 36);
            btnRemove.TabIndex = 29;
            btnRemove.Text = "-";
            btnRemove.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRemove.UseAccentColor = false;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.AllowPromptAsInput = true;
            txtQuantity.AnimateReadOnly = false;
            txtQuantity.AsciiOnly = false;
            txtQuantity.BackgroundImageLayout = ImageLayout.None;
            txtQuantity.BeepOnError = false;
            txtQuantity.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtQuantity.Depth = 0;
            txtQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantity.HidePromptOnLeave = false;
            txtQuantity.HideSelection = true;
            txtQuantity.Hint = "Quantity";
            txtQuantity.InsertKeyMode = InsertKeyMode.Default;
            txtQuantity.LeadingIcon = null;
            txtQuantity.Location = new Point(511, 25);
            txtQuantity.Mask = "";
            txtQuantity.MaxLength = 32767;
            txtQuantity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PasswordChar = '\0';
            txtQuantity.PrefixSuffixText = null;
            txtQuantity.PromptChar = '_';
            txtQuantity.ReadOnly = false;
            txtQuantity.RejectInputOnFirstFailure = false;
            txtQuantity.ResetOnPrompt = true;
            txtQuantity.ResetOnSpace = true;
            txtQuantity.RightToLeft = RightToLeft.No;
            txtQuantity.SelectedText = "";
            txtQuantity.SelectionLength = 0;
            txtQuantity.SelectionStart = 0;
            txtQuantity.ShortcutsEnabled = true;
            txtQuantity.Size = new Size(152, 48);
            txtQuantity.SkipLiterals = true;
            txtQuantity.TabIndex = 28;
            txtQuantity.TabStop = false;
            txtQuantity.TextAlign = HorizontalAlignment.Left;
            txtQuantity.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtQuantity.TrailingIcon = null;
            txtQuantity.UseSystemPasswordChar = false;
            txtQuantity.ValidatingType = null;
            txtQuantity.Leave += txtQuantity_Leave;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.AllowPromptAsInput = true;
            txtTotalPrice.AnimateReadOnly = false;
            txtTotalPrice.AsciiOnly = false;
            txtTotalPrice.BackgroundImageLayout = ImageLayout.None;
            txtTotalPrice.BeepOnError = false;
            txtTotalPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalPrice.Depth = 0;
            txtTotalPrice.Enabled = false;
            txtTotalPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTotalPrice.HidePromptOnLeave = false;
            txtTotalPrice.HideSelection = true;
            txtTotalPrice.Hint = "Total Price";
            txtTotalPrice.InsertKeyMode = InsertKeyMode.Default;
            txtTotalPrice.LeadingIcon = null;
            txtTotalPrice.Location = new Point(347, 25);
            txtTotalPrice.Mask = "";
            txtTotalPrice.MaxLength = 32767;
            txtTotalPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.PasswordChar = '\0';
            txtTotalPrice.PrefixSuffixText = null;
            txtTotalPrice.PromptChar = '_';
            txtTotalPrice.ReadOnly = false;
            txtTotalPrice.RejectInputOnFirstFailure = false;
            txtTotalPrice.ResetOnPrompt = true;
            txtTotalPrice.ResetOnSpace = true;
            txtTotalPrice.RightToLeft = RightToLeft.No;
            txtTotalPrice.SelectedText = "";
            txtTotalPrice.SelectionLength = 0;
            txtTotalPrice.SelectionStart = 0;
            txtTotalPrice.ShortcutsEnabled = true;
            txtTotalPrice.Size = new Size(158, 48);
            txtTotalPrice.SkipLiterals = true;
            txtTotalPrice.TabIndex = 27;
            txtTotalPrice.TabStop = false;
            txtTotalPrice.TextAlign = HorizontalAlignment.Left;
            txtTotalPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTotalPrice.TrailingIcon = null;
            txtTotalPrice.UseSystemPasswordChar = false;
            txtTotalPrice.ValidatingType = null;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.AllowPromptAsInput = true;
            txtUnitPrice.AnimateReadOnly = false;
            txtUnitPrice.AsciiOnly = false;
            txtUnitPrice.BackgroundImageLayout = ImageLayout.None;
            txtUnitPrice.BeepOnError = false;
            txtUnitPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtUnitPrice.Depth = 0;
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUnitPrice.HidePromptOnLeave = false;
            txtUnitPrice.HideSelection = true;
            txtUnitPrice.Hint = "Unit Price";
            txtUnitPrice.InsertKeyMode = InsertKeyMode.Default;
            txtUnitPrice.LeadingIcon = null;
            txtUnitPrice.Location = new Point(217, 25);
            txtUnitPrice.Mask = "";
            txtUnitPrice.MaxLength = 32767;
            txtUnitPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.PasswordChar = '\0';
            txtUnitPrice.PrefixSuffixText = null;
            txtUnitPrice.PromptChar = '_';
            txtUnitPrice.ReadOnly = false;
            txtUnitPrice.RejectInputOnFirstFailure = false;
            txtUnitPrice.ResetOnPrompt = true;
            txtUnitPrice.ResetOnSpace = true;
            txtUnitPrice.RightToLeft = RightToLeft.No;
            txtUnitPrice.SelectedText = "";
            txtUnitPrice.SelectionLength = 0;
            txtUnitPrice.SelectionStart = 0;
            txtUnitPrice.ShortcutsEnabled = true;
            txtUnitPrice.Size = new Size(124, 48);
            txtUnitPrice.SkipLiterals = true;
            txtUnitPrice.TabIndex = 26;
            txtUnitPrice.TabStop = false;
            txtUnitPrice.TextAlign = HorizontalAlignment.Left;
            txtUnitPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUnitPrice.TrailingIcon = null;
            txtUnitPrice.UseSystemPasswordChar = false;
            txtUnitPrice.ValidatingType = null;
            txtUnitPrice.Leave += txtUnitValue_Leave;
            // 
            // btnAdd
            // 
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdd.Depth = 0;
            btnAdd.HighEmphasis = true;
            btnAdd.Icon = null;
            btnAdd.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdd.Location = new Point(670, 25);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdd.Name = "btnAdd";
            btnAdd.NoAccentTextColor = Color.Empty;
            btnAdd.Size = new Size(64, 36);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "+";
            btnAdd.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdd.UseAccentColor = false;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblQuantityItems
            // 
            lblQuantityItems.AutoSize = true;
            lblQuantityItems.Location = new Point(544, 86);
            lblQuantityItems.Name = "lblQuantityItems";
            lblQuantityItems.Size = new Size(56, 15);
            lblQuantityItems.TabIndex = 24;
            lblQuantityItems.Text = "Quantity:";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(16, 86);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(70, 15);
            lblValue.TabIndex = 23;
            lblValue.Text = "Total Value: ";
            // 
            // dataGridViewSaleItems
            // 
            dataGridViewSaleItems.AllowUserToAddRows = false;
            dataGridViewSaleItems.AllowUserToDeleteRows = false;
            dataGridViewSaleItems.AllowUserToResizeColumns = false;
            dataGridViewSaleItems.AllowUserToResizeRows = false;
            dataGridViewSaleItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaleItems.Location = new Point(16, 113);
            dataGridViewSaleItems.Name = "dataGridViewSaleItems";
            dataGridViewSaleItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSaleItems.Size = new Size(738, 185);
            dataGridViewSaleItems.TabIndex = 22;
            // 
            // txtProduct
            // 
            txtProduct.AutoResize = false;
            txtProduct.BackColor = Color.FromArgb(255, 255, 255);
            txtProduct.Depth = 0;
            txtProduct.DrawMode = DrawMode.OwnerDrawVariable;
            txtProduct.DropDownHeight = 174;
            txtProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            txtProduct.DropDownWidth = 121;
            txtProduct.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            txtProduct.ForeColor = Color.FromArgb(222, 0, 0, 0);
            txtProduct.FormattingEnabled = true;
            txtProduct.Hint = "Product";
            txtProduct.IntegralHeight = false;
            txtProduct.ItemHeight = 43;
            txtProduct.Location = new Point(6, 25);
            txtProduct.MaxDropDownItems = 4;
            txtProduct.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(205, 49);
            txtProduct.StartIndex = 0;
            txtProduct.TabIndex = 18;
            txtProduct.SelectedIndexChanged += txtProduct_SelectedIndexChanged;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Location = new Point(0, 0);
            Name = "SaleForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Register";
            Load += SaleForm_Load;
            tabControlRegister.ResumeLayout(false);
            TabPageRegister.ResumeLayout(false);
            gpboxSaleItem.ResumeLayout(false);
            gpboxSaleItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaleItems).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private GroupBox gpboxSaleItem;
        private ReaLTaiizor.Controls.MaterialComboBox txtProduct;
        private ReaLTaiizor.Controls.MaterialComboBox txtCustomer;
        private ReaLTaiizor.Controls.MaterialComboBox txtUser;
        private DataGridView dataGridViewSaleItems;
        private Label lblQuantityItems;
        private Label lblValue;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtQuantity;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTotalPrice;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtUnitPrice;
        private ReaLTaiizor.Controls.MaterialButton btnAdd;
        private ReaLTaiizor.Controls.MaterialButton btnRemove;
    }
}