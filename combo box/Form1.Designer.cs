namespace combo_box
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.MaterialListBoxItem materialListBoxItem9 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem10 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem11 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem12 = new MaterialSkin.MaterialListBoxItem();
            comboBox1 = new ComboBox();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1 = new GroupBox();
            carbox = new ListBox();
            carbox2 = new MaterialSkin.Controls.MaterialListBox();
            groupBox2 = new GroupBox();
            materialMaskedTextBox1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            delbox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            delclick = new MaterialSkin.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.SandyBrown;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BMW ", "Toyota", "Ford", "Audi", "ferrai" });
            comboBox1.Location = new Point(245, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Default";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "BMW", "Ford" });
            materialComboBox1.Location = new Point(6, 26);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(121, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 4;
            materialComboBox1.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(6, 160);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(87, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "click me\r\n";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.BorderStyle = BorderStyle.FixedSingle;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 78);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(200, 67);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "selected index";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            materialLabel1.Click += materialLabel1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialComboBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(materialButton1);
            groupBox1.Controls.Add(materialLabel1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 264);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "comboboxgroup";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // carbox
            // 
            carbox.FormattingEnabled = true;
            carbox.ItemHeight = 21;
            carbox.Items.AddRange(new object[] { "bmw", "toyota", "audi", "ford" });
            carbox.Location = new Point(307, 71);
            carbox.Name = "carbox";
            carbox.Size = new Size(120, 88);
            carbox.TabIndex = 7;
            carbox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // carbox2
            // 
            carbox2.BackColor = Color.White;
            carbox2.BorderColor = Color.LightGray;
            carbox2.Depth = 0;
            carbox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBoxItem9.SecondaryText = "";
            materialListBoxItem9.Tag = null;
            materialListBoxItem9.Text = "BMW";
            materialListBoxItem10.SecondaryText = "";
            materialListBoxItem10.Tag = null;
            materialListBoxItem10.Text = "toyota";
            materialListBoxItem11.SecondaryText = "";
            materialListBoxItem11.Tag = null;
            materialListBoxItem11.Text = "audi";
            materialListBoxItem12.SecondaryText = "";
            materialListBoxItem12.Tag = null;
            materialListBoxItem12.Text = "ford";
            carbox2.Items.Add(materialListBoxItem9);
            carbox2.Items.Add(materialListBoxItem10);
            carbox2.Items.Add(materialListBoxItem11);
            carbox2.Items.Add(materialListBoxItem12);
            carbox2.Location = new Point(433, 71);
            carbox2.MouseState = MaterialSkin.MouseState.HOVER;
            carbox2.Name = "carbox2";
            carbox2.SelectedIndex = -1;
            carbox2.SelectedItem = null;
            carbox2.Size = new Size(154, 174);
            carbox2.TabIndex = 7;
            carbox2.SelectedIndexChanged += materialListBox1_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materialMaskedTextBox1);
            groupBox2.Controls.Add(delbox);
            groupBox2.Controls.Add(delclick);
            groupBox2.Controls.Add(carbox2);
            groupBox2.Controls.Add(carbox);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(18, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(619, 282);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "list boxs";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // materialMaskedTextBox1
            // 
            materialMaskedTextBox1.AllowPromptAsInput = true;
            materialMaskedTextBox1.AnimateReadOnly = false;
            materialMaskedTextBox1.AsciiOnly = false;
            materialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None;
            materialMaskedTextBox1.BeepOnError = false;
            materialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.Depth = 0;
            materialMaskedTextBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMaskedTextBox1.HidePromptOnLeave = false;
            materialMaskedTextBox1.HideSelection = true;
            materialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default;
            materialMaskedTextBox1.LeadingIcon = null;
            materialMaskedTextBox1.Location = new Point(6, 71);
            materialMaskedTextBox1.Mask = "";
            materialMaskedTextBox1.MaxLength = 32767;
            materialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialMaskedTextBox1.Name = "materialMaskedTextBox1";
            materialMaskedTextBox1.PasswordChar = '\0';
            materialMaskedTextBox1.PrefixSuffixText = null;
            materialMaskedTextBox1.PromptChar = '_';
            materialMaskedTextBox1.ReadOnly = false;
            materialMaskedTextBox1.RejectInputOnFirstFailure = false;
            materialMaskedTextBox1.ResetOnPrompt = true;
            materialMaskedTextBox1.ResetOnSpace = true;
            materialMaskedTextBox1.RightToLeft = RightToLeft.No;
            materialMaskedTextBox1.SelectedText = "";
            materialMaskedTextBox1.SelectionLength = 0;
            materialMaskedTextBox1.SelectionStart = 0;
            materialMaskedTextBox1.ShortcutsEnabled = true;
            materialMaskedTextBox1.Size = new Size(250, 48);
            materialMaskedTextBox1.SkipLiterals = true;
            materialMaskedTextBox1.TabIndex = 9;
            materialMaskedTextBox1.TabStop = false;
            materialMaskedTextBox1.Text = "materialMaskedTextBox1";
            materialMaskedTextBox1.TextAlign = HorizontalAlignment.Left;
            materialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            materialMaskedTextBox1.TrailingIcon = null;
            materialMaskedTextBox1.UseSystemPasswordChar = false;
            materialMaskedTextBox1.ValidatingType = null;
            // 
            // delbox
            // 
            delbox.AllowPromptAsInput = true;
            delbox.AnimateReadOnly = false;
            delbox.AsciiOnly = false;
            delbox.BackgroundImageLayout = ImageLayout.None;
            delbox.BeepOnError = false;
            delbox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            delbox.Depth = 0;
            delbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            delbox.HidePromptOnLeave = false;
            delbox.HideSelection = true;
            delbox.InsertKeyMode = InsertKeyMode.Default;
            delbox.LeadingIcon = null;
            delbox.Location = new Point(6, 71);
            delbox.Mask = "";
            delbox.MaxLength = 32767;
            delbox.MouseState = MaterialSkin.MouseState.OUT;
            delbox.Name = "delbox";
            delbox.PasswordChar = '\0';
            delbox.PrefixSuffixText = null;
            delbox.PromptChar = '_';
            delbox.ReadOnly = false;
            delbox.RejectInputOnFirstFailure = false;
            delbox.ResetOnPrompt = true;
            delbox.ResetOnSpace = true;
            delbox.RightToLeft = RightToLeft.No;
            delbox.SelectedText = "";
            delbox.SelectionLength = 0;
            delbox.SelectionStart = 0;
            delbox.ShortcutsEnabled = true;
            delbox.Size = new Size(250, 48);
            delbox.SkipLiterals = true;
            delbox.TabIndex = 9;
            delbox.TabStop = false;
            delbox.TextAlign = HorizontalAlignment.Left;
            delbox.TextMaskFormat = MaskFormat.IncludeLiterals;
            delbox.TrailingIcon = null;
            delbox.UseSystemPasswordChar = false;
            delbox.ValidatingType = null;
            delbox.Click += materialMaskedTextBox1_Click;
            // 
            // delclick
            // 
            delclick.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            delclick.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            delclick.Depth = 0;
            delclick.HighEmphasis = true;
            delclick.Icon = null;
            delclick.Location = new Point(7, 138);
            delclick.Margin = new Padding(4, 6, 4, 6);
            delclick.MouseState = MaterialSkin.MouseState.HOVER;
            delclick.Name = "delclick";
            delclick.NoAccentTextColor = Color.Empty;
            delclick.Size = new Size(73, 36);
            delclick.TabIndex = 8;
            delclick.Text = "delete";
            delclick.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            delclick.UseAccentColor = false;
            delclick.UseVisualStyleBackColor = true;
            delclick.Click += materialButton2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 626);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private GroupBox groupBox1;
        private ListBox carbox;
        private MaterialSkin.Controls.MaterialListBox carbox2;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialMaskedTextBox delbox;
        private MaterialSkin.Controls.MaterialButton delclick;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox1;
    }
}