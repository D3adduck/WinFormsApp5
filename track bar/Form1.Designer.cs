namespace track_bar
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
            displaylabel = new MaterialSkin.Controls.MaterialLabel();
            trackBar1 = new TrackBar();
            pictureBox1 = new PictureBox();
            materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // displaylabel
            // 
            displaylabel.BorderStyle = BorderStyle.FixedSingle;
            displaylabel.Depth = 0;
            displaylabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            displaylabel.Location = new Point(648, 317);
            displaylabel.MouseState = MaterialSkin.MouseState.HOVER;
            displaylabel.Name = "displaylabel";
            displaylabel.Size = new Size(50, 51);
            displaylabel.TabIndex = 0;
            displaylabel.TextAlign = ContentAlignment.MiddleCenter;
            displaylabel.Click += materialLabel1_Click;
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.BackColor = Color.MediumPurple;
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(653, 1);
            trackBar1.Maximum = 715;
            trackBar1.Minimum = 246;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(45, 299);
            trackBar1.TabIndex = 1;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Value = 246;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.monky;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // materialSlider1
            // 
            materialSlider1.Depth = 0;
            materialSlider1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialSlider1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            materialSlider1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialSlider1.Location = new Point(392, 328);
            materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialSlider1.Name = "materialSlider1";
            materialSlider1.RangeMax = 715;
            materialSlider1.RangeMin = 246;
            materialSlider1.Size = new Size(250, 40);
            materialSlider1.TabIndex = 3;
            materialSlider1.Text = "Size";
            materialSlider1.Value = 246;
            materialSlider1.onValueChanged += materialSlider1_onValueChanged;
            materialSlider1.Click += materialSlider1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 368);
            Controls.Add(materialSlider1);
            Controls.Add(pictureBox1);
            Controls.Add(trackBar1);
            Controls.Add(displaylabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel displaylabel;
        private TrackBar trackBar1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
    }
}