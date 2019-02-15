namespace ColorViewer.Views
{
    partial class FrmColorPalette
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
            this.CldlgColorPicker = new System.Windows.Forms.ColorDialog();
            this.BtnShowColor = new System.Windows.Forms.Button();
            this.Gb_ColorSelection = new System.Windows.Forms.GroupBox();
            this.Gb_ArgbSpecifications = new System.Windows.Forms.GroupBox();
            this.Txt_Percent_Alpha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Percent_Red = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Alpha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Red = new System.Windows.Forms.TextBox();
            this.Txt_Percent_Blue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Green = new System.Windows.Forms.TextBox();
            this.Txt_Percent_Green = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Blue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Trb_Alpha = new System.Windows.Forms.TrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Trb_Blue = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.Trb_Green = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.Trb_Red = new System.Windows.Forms.TrackBar();
            this.Txt_HEXColorCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_SelectedColor = new System.Windows.Forms.Label();
            this.Gb_CMYK_Specifications = new System.Windows.Forms.GroupBox();
            this.Txt_Black_K = new System.Windows.Forms.TextBox();
            this.Txt_Yellow = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Txt_Magenta = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Txt_Cyan = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnChooseColorFromImage = new System.Windows.Forms.Button();
            this.TxtPatterName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Btn_ViewCollection = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblLoggedInAs = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblMachineName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Gb_ColorSelection.SuspendLayout();
            this.Gb_ArgbSpecifications.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Red)).BeginInit();
            this.Gb_CMYK_Specifications.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CldlgColorPicker
            // 
            this.CldlgColorPicker.Color = System.Drawing.Color.White;
            this.CldlgColorPicker.FullOpen = true;
            // 
            // BtnShowColor
            // 
            this.BtnShowColor.Location = new System.Drawing.Point(6, 29);
            this.BtnShowColor.Name = "BtnShowColor";
            this.BtnShowColor.Size = new System.Drawing.Size(129, 28);
            this.BtnShowColor.TabIndex = 0;
            this.BtnShowColor.Text = "Open Color Wizard";
            this.BtnShowColor.UseVisualStyleBackColor = true;
            this.BtnShowColor.Click += new System.EventHandler(this.BtnShowColor_Click);
            // 
            // Gb_ColorSelection
            // 
            this.Gb_ColorSelection.Controls.Add(this.Gb_ArgbSpecifications);
            this.Gb_ColorSelection.Controls.Add(this.groupBox1);
            this.Gb_ColorSelection.Controls.Add(this.Txt_HEXColorCode);
            this.Gb_ColorSelection.Controls.Add(this.label1);
            this.Gb_ColorSelection.Controls.Add(this.Lbl_SelectedColor);
            this.Gb_ColorSelection.Location = new System.Drawing.Point(12, 12);
            this.Gb_ColorSelection.Name = "Gb_ColorSelection";
            this.Gb_ColorSelection.Size = new System.Drawing.Size(386, 371);
            this.Gb_ColorSelection.TabIndex = 1;
            this.Gb_ColorSelection.TabStop = false;
            this.Gb_ColorSelection.Text = "Color Selection";
            // 
            // Gb_ArgbSpecifications
            // 
            this.Gb_ArgbSpecifications.Controls.Add(this.Txt_Percent_Alpha);
            this.Gb_ArgbSpecifications.Controls.Add(this.label6);
            this.Gb_ArgbSpecifications.Controls.Add(this.Txt_Percent_Red);
            this.Gb_ArgbSpecifications.Controls.Add(this.label5);
            this.Gb_ArgbSpecifications.Controls.Add(this.Txt_Alpha);
            this.Gb_ArgbSpecifications.Controls.Add(this.label4);
            this.Gb_ArgbSpecifications.Controls.Add(this.Txt_Red);
            this.Gb_ArgbSpecifications.Controls.Add(this.Txt_Percent_Blue);
            this.Gb_ArgbSpecifications.Controls.Add(this.label3);
            this.Gb_ArgbSpecifications.Controls.Add(this.Txt_Green);
            this.Gb_ArgbSpecifications.Controls.Add(this.Txt_Percent_Green);
            this.Gb_ArgbSpecifications.Controls.Add(this.label2);
            this.Gb_ArgbSpecifications.Controls.Add(this.Txt_Blue);
            this.Gb_ArgbSpecifications.Location = new System.Drawing.Point(124, 70);
            this.Gb_ArgbSpecifications.Name = "Gb_ArgbSpecifications";
            this.Gb_ArgbSpecifications.Size = new System.Drawing.Size(256, 124);
            this.Gb_ArgbSpecifications.TabIndex = 14;
            this.Gb_ArgbSpecifications.TabStop = false;
            this.Gb_ArgbSpecifications.Text = "ARGB Specifications";
            // 
            // Txt_Percent_Alpha
            // 
            this.Txt_Percent_Alpha.Location = new System.Drawing.Point(42, 85);
            this.Txt_Percent_Alpha.Name = "Txt_Percent_Alpha";
            this.Txt_Percent_Alpha.ReadOnly = true;
            this.Txt_Percent_Alpha.Size = new System.Drawing.Size(35, 21);
            this.Txt_Percent_Alpha.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "% CA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Percent_Red
            // 
            this.Txt_Percent_Red.Location = new System.Drawing.Point(96, 85);
            this.Txt_Percent_Red.Name = "Txt_Percent_Red";
            this.Txt_Percent_Red.ReadOnly = true;
            this.Txt_Percent_Red.Size = new System.Drawing.Size(35, 21);
            this.Txt_Percent_Red.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Blue";
            // 
            // Txt_Alpha
            // 
            this.Txt_Alpha.Location = new System.Drawing.Point(42, 45);
            this.Txt_Alpha.Name = "Txt_Alpha";
            this.Txt_Alpha.ReadOnly = true;
            this.Txt_Alpha.Size = new System.Drawing.Size(35, 21);
            this.Txt_Alpha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Green";
            // 
            // Txt_Red
            // 
            this.Txt_Red.Location = new System.Drawing.Point(96, 45);
            this.Txt_Red.Name = "Txt_Red";
            this.Txt_Red.ReadOnly = true;
            this.Txt_Red.Size = new System.Drawing.Size(35, 21);
            this.Txt_Red.TabIndex = 8;
            // 
            // Txt_Percent_Blue
            // 
            this.Txt_Percent_Blue.Location = new System.Drawing.Point(203, 85);
            this.Txt_Percent_Blue.Name = "Txt_Percent_Blue";
            this.Txt_Percent_Blue.ReadOnly = true;
            this.Txt_Percent_Blue.Size = new System.Drawing.Size(35, 21);
            this.Txt_Percent_Blue.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Red";
            // 
            // Txt_Green
            // 
            this.Txt_Green.Location = new System.Drawing.Point(149, 45);
            this.Txt_Green.Name = "Txt_Green";
            this.Txt_Green.ReadOnly = true;
            this.Txt_Green.Size = new System.Drawing.Size(35, 21);
            this.Txt_Green.TabIndex = 9;
            // 
            // Txt_Percent_Green
            // 
            this.Txt_Percent_Green.Location = new System.Drawing.Point(149, 85);
            this.Txt_Percent_Green.Name = "Txt_Percent_Green";
            this.Txt_Percent_Green.ReadOnly = true;
            this.Txt_Percent_Green.Size = new System.Drawing.Size(35, 21);
            this.Txt_Percent_Green.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alpha";
            // 
            // Txt_Blue
            // 
            this.Txt_Blue.Location = new System.Drawing.Point(203, 45);
            this.Txt_Blue.Name = "Txt_Blue";
            this.Txt_Blue.ReadOnly = true;
            this.Txt_Blue.Size = new System.Drawing.Size(35, 21);
            this.Txt_Blue.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Trb_Alpha);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Trb_Blue);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Trb_Green);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Trb_Red);
            this.groupBox1.Location = new System.Drawing.Point(8, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 164);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Range Control";
            // 
            // Trb_Alpha
            // 
            this.Trb_Alpha.AutoSize = false;
            this.Trb_Alpha.Location = new System.Drawing.Point(54, 130);
            this.Trb_Alpha.Maximum = 255;
            this.Trb_Alpha.Name = "Trb_Alpha";
            this.Trb_Alpha.Size = new System.Drawing.Size(306, 32);
            this.Trb_Alpha.TabIndex = 26;
            this.Trb_Alpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Trb_Alpha.Value = 255;
            this.Trb_Alpha.Scroll += new System.EventHandler(this.Trb_Alpha_Scroll);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 15);
            this.label19.TabIndex = 25;
            this.label19.Text = "Alpha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Blue";
            // 
            // Trb_Blue
            // 
            this.Trb_Blue.AutoSize = false;
            this.Trb_Blue.Location = new System.Drawing.Point(54, 98);
            this.Trb_Blue.Maximum = 255;
            this.Trb_Blue.Name = "Trb_Blue";
            this.Trb_Blue.Size = new System.Drawing.Size(306, 32);
            this.Trb_Blue.TabIndex = 23;
            this.Trb_Blue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Trb_Blue.Scroll += new System.EventHandler(this.Trb_Blue_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "Green";
            // 
            // Trb_Green
            // 
            this.Trb_Green.AutoSize = false;
            this.Trb_Green.Location = new System.Drawing.Point(54, 64);
            this.Trb_Green.Maximum = 255;
            this.Trb_Green.Name = "Trb_Green";
            this.Trb_Green.Size = new System.Drawing.Size(306, 32);
            this.Trb_Green.TabIndex = 21;
            this.Trb_Green.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Trb_Green.Scroll += new System.EventHandler(this.Trb_Green_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Red";
            // 
            // Trb_Red
            // 
            this.Trb_Red.AutoSize = false;
            this.Trb_Red.Location = new System.Drawing.Point(54, 26);
            this.Trb_Red.Maximum = 255;
            this.Trb_Red.Name = "Trb_Red";
            this.Trb_Red.Size = new System.Drawing.Size(306, 32);
            this.Trb_Red.TabIndex = 19;
            this.Trb_Red.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Trb_Red.Scroll += new System.EventHandler(this.Trb_Red_Scroll);
            // 
            // Txt_HEXColorCode
            // 
            this.Txt_HEXColorCode.Location = new System.Drawing.Point(122, 43);
            this.Txt_HEXColorCode.MaxLength = 8;
            this.Txt_HEXColorCode.Name = "Txt_HEXColorCode";
            this.Txt_HEXColorCode.Size = new System.Drawing.Size(258, 21);
            this.Txt_HEXColorCode.TabIndex = 2;
            this.Txt_HEXColorCode.Leave += new System.EventHandler(this.Txt_HEXColorCode_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "HEX Color Name";
            // 
            // Lbl_SelectedColor
            // 
            this.Lbl_SelectedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_SelectedColor.Location = new System.Drawing.Point(8, 23);
            this.Lbl_SelectedColor.Name = "Lbl_SelectedColor";
            this.Lbl_SelectedColor.Size = new System.Drawing.Size(107, 171);
            this.Lbl_SelectedColor.TabIndex = 0;
            this.Lbl_SelectedColor.Text = "Click here to Open Color Palatte";
            this.Lbl_SelectedColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_SelectedColor.Click += new System.EventHandler(this.Lbl_SelectedColor_Click);
            // 
            // Gb_CMYK_Specifications
            // 
            this.Gb_CMYK_Specifications.Controls.Add(this.Txt_Black_K);
            this.Gb_CMYK_Specifications.Controls.Add(this.Txt_Yellow);
            this.Gb_CMYK_Specifications.Controls.Add(this.label18);
            this.Gb_CMYK_Specifications.Controls.Add(this.Txt_Magenta);
            this.Gb_CMYK_Specifications.Controls.Add(this.label17);
            this.Gb_CMYK_Specifications.Controls.Add(this.Txt_Cyan);
            this.Gb_CMYK_Specifications.Controls.Add(this.label16);
            this.Gb_CMYK_Specifications.Controls.Add(this.label15);
            this.Gb_CMYK_Specifications.Location = new System.Drawing.Point(404, 12);
            this.Gb_CMYK_Specifications.Name = "Gb_CMYK_Specifications";
            this.Gb_CMYK_Specifications.Size = new System.Drawing.Size(283, 89);
            this.Gb_CMYK_Specifications.TabIndex = 14;
            this.Gb_CMYK_Specifications.TabStop = false;
            this.Gb_CMYK_Specifications.Text = "CMYK Specifications";
            // 
            // Txt_Black_K
            // 
            this.Txt_Black_K.Location = new System.Drawing.Point(193, 43);
            this.Txt_Black_K.Name = "Txt_Black_K";
            this.Txt_Black_K.ReadOnly = true;
            this.Txt_Black_K.Size = new System.Drawing.Size(52, 21);
            this.Txt_Black_K.TabIndex = 26;
            // 
            // Txt_Yellow
            // 
            this.Txt_Yellow.Location = new System.Drawing.Point(135, 43);
            this.Txt_Yellow.Name = "Txt_Yellow";
            this.Txt_Yellow.ReadOnly = true;
            this.Txt_Yellow.Size = new System.Drawing.Size(52, 21);
            this.Txt_Yellow.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 15);
            this.label18.TabIndex = 19;
            this.label18.Text = "Cyan";
            // 
            // Txt_Magenta
            // 
            this.Txt_Magenta.Location = new System.Drawing.Point(77, 43);
            this.Txt_Magenta.Name = "Txt_Magenta";
            this.Txt_Magenta.ReadOnly = true;
            this.Txt_Magenta.Size = new System.Drawing.Size(52, 21);
            this.Txt_Magenta.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(73, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 15);
            this.label17.TabIndex = 20;
            this.label17.Text = "Magenta";
            // 
            // Txt_Cyan
            // 
            this.Txt_Cyan.Location = new System.Drawing.Point(19, 43);
            this.Txt_Cyan.Name = "Txt_Cyan";
            this.Txt_Cyan.ReadOnly = true;
            this.Txt_Cyan.Size = new System.Drawing.Size(52, 21);
            this.Txt_Cyan.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(135, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 15);
            this.label16.TabIndex = 21;
            this.label16.Text = "Yellow";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(190, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "Black(K)";
            // 
            // BtnChooseColorFromImage
            // 
            this.BtnChooseColorFromImage.Location = new System.Drawing.Point(138, 29);
            this.BtnChooseColorFromImage.Name = "BtnChooseColorFromImage";
            this.BtnChooseColorFromImage.Size = new System.Drawing.Size(139, 28);
            this.BtnChooseColorFromImage.TabIndex = 15;
            this.BtnChooseColorFromImage.Text = "Pick Color from Image\r\n";
            this.BtnChooseColorFromImage.UseVisualStyleBackColor = true;
            this.BtnChooseColorFromImage.Click += new System.EventHandler(this.BtnChooseColorFromImage_Click);
            // 
            // TxtPatterName
            // 
            this.TxtPatterName.Location = new System.Drawing.Point(98, 105);
            this.TxtPatterName.Name = "TxtPatterName";
            this.TxtPatterName.Size = new System.Drawing.Size(126, 21);
            this.TxtPatterName.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 15);
            this.label20.TabIndex = 21;
            this.label20.Text = "Pattern Name:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(228, 105);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(49, 24);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Btn_ViewCollection
            // 
            this.Btn_ViewCollection.Location = new System.Drawing.Point(6, 63);
            this.Btn_ViewCollection.Name = "Btn_ViewCollection";
            this.Btn_ViewCollection.Size = new System.Drawing.Size(129, 25);
            this.Btn_ViewCollection.TabIndex = 23;
            this.Btn_ViewCollection.Text = "View Collection";
            this.Btn_ViewCollection.UseVisualStyleBackColor = true;
            this.Btn_ViewCollection.Click += new System.EventHandler(this.Btn_ViewCollection_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnShowColor);
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.Btn_ViewCollection);
            this.groupBox2.Controls.Add(this.TxtPatterName);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.BtnChooseColorFromImage);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(404, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 146);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activity Panel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblLoggedInAs);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.LblMachineName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(404, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 116);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Machine Details";
            // 
            // LblLoggedInAs
            // 
            this.LblLoggedInAs.AutoSize = true;
            this.LblLoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoggedInAs.Location = new System.Drawing.Point(110, 56);
            this.LblLoggedInAs.Name = "LblLoggedInAs";
            this.LblLoggedInAs.Size = new System.Drawing.Size(91, 13);
            this.LblLoggedInAs.TabIndex = 3;
            this.LblLoggedInAs.Text = "Machine Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Logged in as:";
            // 
            // LblMachineName
            // 
            this.LblMachineName.AutoSize = true;
            this.LblMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMachineName.Location = new System.Drawing.Point(110, 35);
            this.LblMachineName.Name = "LblMachineName";
            this.LblMachineName.Size = new System.Drawing.Size(91, 13);
            this.LblMachineName.TabIndex = 1;
            this.LblMachineName.Text = "Machine Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Machine Name: ";
            // 
            // FrmColorPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 388);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Gb_CMYK_Specifications);
            this.Controls.Add(this.Gb_ColorSelection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmColorPalette";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Palatte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmColorPalette_FormClosing);
            this.Load += new System.EventHandler(this.FrmColorPalette_Load);
            this.Gb_ColorSelection.ResumeLayout(false);
            this.Gb_ColorSelection.PerformLayout();
            this.Gb_ArgbSpecifications.ResumeLayout(false);
            this.Gb_ArgbSpecifications.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trb_Red)).EndInit();
            this.Gb_CMYK_Specifications.ResumeLayout(false);
            this.Gb_CMYK_Specifications.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog CldlgColorPicker;
        private System.Windows.Forms.Button BtnShowColor;
        private System.Windows.Forms.GroupBox Gb_ColorSelection;
        private System.Windows.Forms.TextBox Txt_HEXColorCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_SelectedColor;
        private System.Windows.Forms.TextBox Txt_Blue;
        private System.Windows.Forms.TextBox Txt_Green;
        private System.Windows.Forms.TextBox Txt_Red;
        private System.Windows.Forms.TextBox Txt_Alpha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Percent_Red;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Percent_Blue;
        private System.Windows.Forms.TextBox Txt_Percent_Green;
        private System.Windows.Forms.GroupBox Gb_CMYK_Specifications;
        private System.Windows.Forms.TextBox Txt_Black_K;
        private System.Windows.Forms.TextBox Txt_Yellow;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Txt_Magenta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Txt_Cyan;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar Trb_Blue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar Trb_Green;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar Trb_Red;
        private System.Windows.Forms.GroupBox Gb_ArgbSpecifications;
        private System.Windows.Forms.TrackBar Trb_Alpha;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnChooseColorFromImage;
        private System.Windows.Forms.TextBox TxtPatterName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button Btn_ViewCollection;
        private System.Windows.Forms.TextBox Txt_Percent_Alpha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblMachineName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblLoggedInAs;
        private System.Windows.Forms.Label label9;
    }
}

