namespace Labels
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
            topleftLabel = new Label();
            topcenterLabel = new Label();
            toprightLabel = new Label();
            middelleftLabel = new Label();
            middelcenterLabel = new Label();
            middelrightLabel = new Label();
            downleftLabel = new Label();
            middelbottomLabel = new Label();
            lowerrightLabel = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // topleftLabel
            // 
            topleftLabel.BorderStyle = BorderStyle.FixedSingle;
            topleftLabel.Location = new Point(32, 32);
            topleftLabel.Name = "topleftLabel";
            topleftLabel.Size = new Size(200, 87);
            topleftLabel.TabIndex = 0;
            topleftLabel.Click += topleftLabel_Click;
            // 
            // topcenterLabel
            // 
            topcenterLabel.BorderStyle = BorderStyle.FixedSingle;
            topcenterLabel.Location = new Point(308, 32);
            topcenterLabel.Name = "topcenterLabel";
            topcenterLabel.Size = new Size(200, 87);
            topcenterLabel.TabIndex = 1;
            topcenterLabel.TextAlign = ContentAlignment.TopCenter;
            topcenterLabel.Click += topcenterLabel_Click;
            // 
            // toprightLabel
            // 
            toprightLabel.BorderStyle = BorderStyle.FixedSingle;
            toprightLabel.Location = new Point(564, 32);
            toprightLabel.Name = "toprightLabel";
            toprightLabel.Size = new Size(200, 87);
            toprightLabel.TabIndex = 2;
            toprightLabel.TextAlign = ContentAlignment.TopRight;
            toprightLabel.Click += topightLabel_Click;
            // 
            // middelleftLabel
            // 
            middelleftLabel.BorderStyle = BorderStyle.FixedSingle;
            middelleftLabel.Location = new Point(32, 154);
            middelleftLabel.Name = "middelleftLabel";
            middelleftLabel.Size = new Size(200, 87);
            middelleftLabel.TabIndex = 3;
            middelleftLabel.TextAlign = ContentAlignment.MiddleLeft;
            middelleftLabel.Click += middelleftLabel_Click;
            // 
            // middelcenterLabel
            // 
            middelcenterLabel.BorderStyle = BorderStyle.FixedSingle;
            middelcenterLabel.Location = new Point(308, 154);
            middelcenterLabel.Name = "middelcenterLabel";
            middelcenterLabel.Size = new Size(200, 87);
            middelcenterLabel.TabIndex = 4;
            middelcenterLabel.TextAlign = ContentAlignment.MiddleCenter;
            middelcenterLabel.Click += middelcenterLabel_Click;
            // 
            // middelrightLabel
            // 
            middelrightLabel.BorderStyle = BorderStyle.FixedSingle;
            middelrightLabel.Location = new Point(564, 154);
            middelrightLabel.Name = "middelrightLabel";
            middelrightLabel.Size = new Size(200, 87);
            middelrightLabel.TabIndex = 5;
            middelrightLabel.TextAlign = ContentAlignment.MiddleRight;
            middelrightLabel.Click += middelrightLabel_Click;
            // 
            // downleftLabel
            // 
            downleftLabel.BorderStyle = BorderStyle.FixedSingle;
            downleftLabel.Location = new Point(32, 271);
            downleftLabel.Name = "downleftLabel";
            downleftLabel.Size = new Size(200, 87);
            downleftLabel.TabIndex = 6;
            downleftLabel.TextAlign = ContentAlignment.BottomLeft;
            downleftLabel.Click += downleftLabel_Click;
            // 
            // middelbottomLabel
            // 
            middelbottomLabel.BorderStyle = BorderStyle.FixedSingle;
            middelbottomLabel.Location = new Point(308, 271);
            middelbottomLabel.Name = "middelbottomLabel";
            middelbottomLabel.Size = new Size(200, 87);
            middelbottomLabel.TabIndex = 7;
            middelbottomLabel.TextAlign = ContentAlignment.BottomCenter;
            middelbottomLabel.Click += middelbottomLabel_Click;
            // 
            // lowerrightLabel
            // 
            lowerrightLabel.BorderStyle = BorderStyle.FixedSingle;
            lowerrightLabel.Location = new Point(564, 271);
            lowerrightLabel.Name = "lowerrightLabel";
            lowerrightLabel.Size = new Size(200, 87);
            lowerrightLabel.TabIndex = 8;
            lowerrightLabel.TextAlign = ContentAlignment.BottomRight;
            lowerrightLabel.Click += lowerrightLabel_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(330, 415);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 9;
            materialButton1.Text = "materialButton1";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 539);
            Controls.Add(materialButton1);
            Controls.Add(lowerrightLabel);
            Controls.Add(middelbottomLabel);
            Controls.Add(downleftLabel);
            Controls.Add(middelrightLabel);
            Controls.Add(middelcenterLabel);
            Controls.Add(middelleftLabel);
            Controls.Add(toprightLabel);
            Controls.Add(topcenterLabel);
            Controls.Add(topleftLabel);
            Name = "Form1";
            Text = "label alignment";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label topleftLabel;
        private Label topcenterLabel;
        private Label toprightLabel;
        private Label middelleftLabel;
        private Label middelcenterLabel;
        private Label middelrightLabel;
        private Label downleftLabel;
        private Label middelbottomLabel;
        private Label lowerrightLabel;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}