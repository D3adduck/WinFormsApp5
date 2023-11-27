namespace picture_box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lowerrightLabel = new Label();
            middelbottomLabel = new Label();
            middelcenterlabel = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(180, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(453, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lowerrightLabel
            // 
            lowerrightLabel.BorderStyle = BorderStyle.FixedSingle;
            lowerrightLabel.Location = new Point(510, 113);
            lowerrightLabel.Name = "lowerrightLabel";
            lowerrightLabel.Size = new Size(242, 123);
            lowerrightLabel.TabIndex = 17;
            lowerrightLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // middelbottomLabel
            // 
            middelbottomLabel.BorderStyle = BorderStyle.FixedSingle;
            middelbottomLabel.Location = new Point(16, 113);
            middelbottomLabel.Name = "middelbottomLabel";
            middelbottomLabel.Size = new Size(241, 123);
            middelbottomLabel.TabIndex = 16;
            middelbottomLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // middelcenterlabel
            // 
            middelcenterlabel.BorderStyle = BorderStyle.FixedSingle;
            middelcenterlabel.Location = new Point(263, 113);
            middelcenterlabel.Name = "middelcenterlabel";
            middelcenterlabel.Size = new Size(241, 123);
            middelcenterlabel.TabIndex = 15;
            middelcenterlabel.TextAlign = ContentAlignment.BottomLeft;
            middelcenterlabel.Click += downleftLabel_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(308, 264);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 18;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 406);
            Controls.Add(materialButton1);
            Controls.Add(lowerrightLabel);
            Controls.Add(middelbottomLabel);
            Controls.Add(middelcenterlabel);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lowerrightLabel;
        private Label middelbottomLabel;
        private Label middelcenterlabel;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}