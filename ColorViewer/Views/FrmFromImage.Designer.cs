namespace ColorViewer.Views
{
    partial class FrmFromImage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnChooseImage = new System.Windows.Forms.Button();
            this.OfdChooseImageFile = new System.Windows.Forms.OpenFileDialog();
            this.Gb_ImageDetails = new System.Windows.Forms.GroupBox();
            this.Lbl_ZoomFactor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblDominantColor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_FileSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl_Resolution = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_PixelDepth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lbl_Height = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_Width = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_FileType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Filename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbPictureBox = new System.Windows.Forms.GroupBox();
            this.PibSelectedImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Trb_Zoom_In_Out = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.Gb_ImageDetails.SuspendLayout();
            this.GbPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PibSelectedImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Zoom_In_Out)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnChooseImage);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select an Image";
            // 
            // BtnChooseImage
            // 
            this.BtnChooseImage.Location = new System.Drawing.Point(15, 33);
            this.BtnChooseImage.Name = "BtnChooseImage";
            this.BtnChooseImage.Size = new System.Drawing.Size(154, 24);
            this.BtnChooseImage.TabIndex = 0;
            this.BtnChooseImage.Text = "Choose an Image File...";
            this.BtnChooseImage.UseVisualStyleBackColor = true;
            this.BtnChooseImage.Click += new System.EventHandler(this.BtnChooseImage_Click);
            // 
            // Gb_ImageDetails
            // 
            this.Gb_ImageDetails.Controls.Add(this.Lbl_ZoomFactor);
            this.Gb_ImageDetails.Controls.Add(this.label10);
            this.Gb_ImageDetails.Controls.Add(this.LblDominantColor);
            this.Gb_ImageDetails.Controls.Add(this.label9);
            this.Gb_ImageDetails.Controls.Add(this.Lbl_FileSize);
            this.Gb_ImageDetails.Controls.Add(this.label8);
            this.Gb_ImageDetails.Controls.Add(this.Lbl_Resolution);
            this.Gb_ImageDetails.Controls.Add(this.label7);
            this.Gb_ImageDetails.Controls.Add(this.Lbl_PixelDepth);
            this.Gb_ImageDetails.Controls.Add(this.label6);
            this.Gb_ImageDetails.Controls.Add(this.Lbl_Height);
            this.Gb_ImageDetails.Controls.Add(this.label5);
            this.Gb_ImageDetails.Controls.Add(this.Lbl_Width);
            this.Gb_ImageDetails.Controls.Add(this.label3);
            this.Gb_ImageDetails.Controls.Add(this.Lbl_FileType);
            this.Gb_ImageDetails.Controls.Add(this.label2);
            this.Gb_ImageDetails.Controls.Add(this.Lbl_Filename);
            this.Gb_ImageDetails.Controls.Add(this.label1);
            this.Gb_ImageDetails.Location = new System.Drawing.Point(12, 89);
            this.Gb_ImageDetails.Name = "Gb_ImageDetails";
            this.Gb_ImageDetails.Size = new System.Drawing.Size(278, 315);
            this.Gb_ImageDetails.TabIndex = 1;
            this.Gb_ImageDetails.TabStop = false;
            this.Gb_ImageDetails.Text = "Image Properties";
            // 
            // Lbl_ZoomFactor
            // 
            this.Lbl_ZoomFactor.AutoSize = true;
            this.Lbl_ZoomFactor.Location = new System.Drawing.Point(104, 286);
            this.Lbl_ZoomFactor.Name = "Lbl_ZoomFactor";
            this.Lbl_ZoomFactor.Size = new System.Drawing.Size(16, 15);
            this.Lbl_ZoomFactor.TabIndex = 17;
            this.Lbl_ZoomFactor.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Zoom:";
            // 
            // LblDominantColor
            // 
            this.LblDominantColor.Location = new System.Drawing.Point(104, 240);
            this.LblDominantColor.Name = "LblDominantColor";
            this.LblDominantColor.Size = new System.Drawing.Size(152, 44);
            this.LblDominantColor.TabIndex = 15;
            this.LblDominantColor.Text = "...";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 43);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dominant Color:";
            // 
            // Lbl_FileSize
            // 
            this.Lbl_FileSize.AutoSize = true;
            this.Lbl_FileSize.Location = new System.Drawing.Point(104, 213);
            this.Lbl_FileSize.Name = "Lbl_FileSize";
            this.Lbl_FileSize.Size = new System.Drawing.Size(16, 15);
            this.Lbl_FileSize.TabIndex = 13;
            this.Lbl_FileSize.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "File Size:";
            // 
            // Lbl_Resolution
            // 
            this.Lbl_Resolution.AutoSize = true;
            this.Lbl_Resolution.Location = new System.Drawing.Point(104, 187);
            this.Lbl_Resolution.Name = "Lbl_Resolution";
            this.Lbl_Resolution.Size = new System.Drawing.Size(16, 15);
            this.Lbl_Resolution.TabIndex = 11;
            this.Lbl_Resolution.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Resolution:";
            // 
            // Lbl_PixelDepth
            // 
            this.Lbl_PixelDepth.AutoSize = true;
            this.Lbl_PixelDepth.Location = new System.Drawing.Point(104, 157);
            this.Lbl_PixelDepth.Name = "Lbl_PixelDepth";
            this.Lbl_PixelDepth.Size = new System.Drawing.Size(16, 15);
            this.Lbl_PixelDepth.TabIndex = 9;
            this.Lbl_PixelDepth.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pixel Depth:";
            // 
            // Lbl_Height
            // 
            this.Lbl_Height.AutoSize = true;
            this.Lbl_Height.Location = new System.Drawing.Point(104, 127);
            this.Lbl_Height.Name = "Lbl_Height";
            this.Lbl_Height.Size = new System.Drawing.Size(16, 15);
            this.Lbl_Height.TabIndex = 7;
            this.Lbl_Height.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Height:";
            // 
            // Lbl_Width
            // 
            this.Lbl_Width.AutoSize = true;
            this.Lbl_Width.Location = new System.Drawing.Point(104, 102);
            this.Lbl_Width.Name = "Lbl_Width";
            this.Lbl_Width.Size = new System.Drawing.Size(16, 15);
            this.Lbl_Width.TabIndex = 5;
            this.Lbl_Width.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width:";
            // 
            // Lbl_FileType
            // 
            this.Lbl_FileType.AutoEllipsis = true;
            this.Lbl_FileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FileType.Location = new System.Drawing.Point(104, 54);
            this.Lbl_FileType.Name = "Lbl_FileType";
            this.Lbl_FileType.Size = new System.Drawing.Size(168, 48);
            this.Lbl_FileType.TabIndex = 3;
            this.Lbl_FileType.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Format:";
            // 
            // Lbl_Filename
            // 
            this.Lbl_Filename.AutoEllipsis = true;
            this.Lbl_Filename.AutoSize = true;
            this.Lbl_Filename.Location = new System.Drawing.Point(104, 27);
            this.Lbl_Filename.Name = "Lbl_Filename";
            this.Lbl_Filename.Size = new System.Drawing.Size(16, 15);
            this.Lbl_Filename.TabIndex = 1;
            this.Lbl_Filename.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename: ";
            // 
            // GbPictureBox
            // 
            this.GbPictureBox.Controls.Add(this.PibSelectedImage);
            this.GbPictureBox.Location = new System.Drawing.Point(295, 12);
            this.GbPictureBox.Name = "GbPictureBox";
            this.GbPictureBox.Size = new System.Drawing.Size(262, 332);
            this.GbPictureBox.TabIndex = 1;
            this.GbPictureBox.TabStop = false;
            this.GbPictureBox.Text = "Picture";
            // 
            // PibSelectedImage
            // 
            this.PibSelectedImage.Location = new System.Drawing.Point(6, 20);
            this.PibSelectedImage.Name = "PibSelectedImage";
            this.PibSelectedImage.Size = new System.Drawing.Size(250, 304);
            this.PibSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PibSelectedImage.TabIndex = 3;
            this.PibSelectedImage.TabStop = false;
            this.PibSelectedImage.Click += new System.EventHandler(this.PibSelectedImage_Click);
            this.PibSelectedImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PibSelectedImage_MouseDown);
            this.PibSelectedImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PibSelectedImage_MouseMove);
            this.PibSelectedImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PibSelectedImage_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Trb_Zoom_In_Out);
            this.groupBox2.Location = new System.Drawing.Point(295, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zoom-in/Zoom-out Image";
            // 
            // Trb_Zoom_In_Out
            // 
            this.Trb_Zoom_In_Out.AutoSize = false;
            this.Trb_Zoom_In_Out.LargeChange = 1;
            this.Trb_Zoom_In_Out.Location = new System.Drawing.Point(7, 20);
            this.Trb_Zoom_In_Out.Maximum = 7;
            this.Trb_Zoom_In_Out.Name = "Trb_Zoom_In_Out";
            this.Trb_Zoom_In_Out.Size = new System.Drawing.Size(249, 20);
            this.Trb_Zoom_In_Out.TabIndex = 0;
            this.Trb_Zoom_In_Out.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Trb_Zoom_In_Out.Scroll += new System.EventHandler(this.Trb_Zoom_In_Out_Scroll);
            // 
            // FrmFromImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbPictureBox);
            this.Controls.Add(this.Gb_ImageDetails);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFromImage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color from Image";
            this.Load += new System.EventHandler(this.FrmFromImage_Load);
            this.groupBox1.ResumeLayout(false);
            this.Gb_ImageDetails.ResumeLayout(false);
            this.Gb_ImageDetails.PerformLayout();
            this.GbPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PibSelectedImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Zoom_In_Out)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog OfdChooseImageFile;
        private System.Windows.Forms.Button BtnChooseImage;
        private System.Windows.Forms.GroupBox Gb_ImageDetails;
        private System.Windows.Forms.GroupBox GbPictureBox;
        private System.Windows.Forms.PictureBox PibSelectedImage;
        private System.Windows.Forms.Label Lbl_FileType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Filename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_Width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_PixelDepth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_Resolution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lbl_FileSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblDominantColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar Trb_Zoom_In_Out;
        private System.Windows.Forms.Label Lbl_ZoomFactor;
        private System.Windows.Forms.Label label10;
    }
}