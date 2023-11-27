namespace flag_project
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
            text = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            countrylabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)text).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // text
            // 
            text.BackColor = Color.Transparent;
            text.BorderStyle = BorderStyle.FixedSingle;
            text.Image = (Image)resources.GetObject("text.Image");
            text.Location = new Point(48, 100);
            text.Name = "text";
            text.Size = new Size(215, 131);
            text.SizeMode = PictureBoxSizeMode.Zoom;
            text.TabIndex = 0;
            text.TabStop = false;
            text.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(476, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(215, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(269, 100);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(201, 131);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Depth = 0;
            materialLabel1.FlatStyle = FlatStyle.System;
            materialLabel1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            materialLabel1.ForeColor = SystemColors.ControlText;
            materialLabel1.Location = new Point(118, 45);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(505, 39);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "click flag to see the name of the country ";
            materialLabel1.TextAlign = ContentAlignment.MiddleCenter;
            materialLabel1.Click += materialLabel1_Click;
            // 
            // countrylabel
            // 
            countrylabel.BorderStyle = BorderStyle.FixedSingle;
            countrylabel.Depth = 0;
            countrylabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            countrylabel.Location = new Point(228, 255);
            countrylabel.MouseState = MaterialSkin.MouseState.HOVER;
            countrylabel.Name = "countrylabel";
            countrylabel.Size = new Size(264, 46);
            countrylabel.TabIndex = 4;
            countrylabel.TextAlign = ContentAlignment.MiddleCenter;
            countrylabel.Click += materialLabel2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 370);
            Controls.Add(countrylabel);
            Controls.Add(materialLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(text);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "flags";
            ((System.ComponentModel.ISupportInitialize)text).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox text;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel countrylabel;
    }
}