namespace ColorViewer.Views
{
    partial class FrmViewColorPattern
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
            this.Gb_ColorCollection = new System.Windows.Forms.GroupBox();
            this.DgvColorPattern = new System.Windows.Forms.DataGridView();
            this.Btn_ViewPattern = new System.Windows.Forms.Button();
            this.Btn_DeletePattern = new System.Windows.Forms.Button();
            this.Gb_ColorCollection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvColorPattern)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_ColorCollection
            // 
            this.Gb_ColorCollection.Controls.Add(this.DgvColorPattern);
            this.Gb_ColorCollection.Location = new System.Drawing.Point(15, 15);
            this.Gb_ColorCollection.Name = "Gb_ColorCollection";
            this.Gb_ColorCollection.Size = new System.Drawing.Size(698, 404);
            this.Gb_ColorCollection.TabIndex = 0;
            this.Gb_ColorCollection.TabStop = false;
            this.Gb_ColorCollection.Text = "Color Pattern Collection";
            // 
            // DgvColorPattern
            // 
            this.DgvColorPattern.AllowUserToAddRows = false;
            this.DgvColorPattern.AllowUserToDeleteRows = false;
            this.DgvColorPattern.AllowUserToResizeRows = false;
            this.DgvColorPattern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvColorPattern.Location = new System.Drawing.Point(6, 30);
            this.DgvColorPattern.MultiSelect = false;
            this.DgvColorPattern.Name = "DgvColorPattern";
            this.DgvColorPattern.ReadOnly = true;
            this.DgvColorPattern.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvColorPattern.Size = new System.Drawing.Size(686, 368);
            this.DgvColorPattern.TabIndex = 0;
            this.DgvColorPattern.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvColorPattern_CellClick);
            // 
            // Btn_ViewPattern
            // 
            this.Btn_ViewPattern.Location = new System.Drawing.Point(268, 425);
            this.Btn_ViewPattern.Name = "Btn_ViewPattern";
            this.Btn_ViewPattern.Size = new System.Drawing.Size(94, 33);
            this.Btn_ViewPattern.TabIndex = 1;
            this.Btn_ViewPattern.Text = "View Pattern";
            this.Btn_ViewPattern.UseVisualStyleBackColor = true;
            this.Btn_ViewPattern.Click += new System.EventHandler(this.Btn_ViewPattern_Click);
            // 
            // Btn_DeletePattern
            // 
            this.Btn_DeletePattern.Location = new System.Drawing.Point(379, 425);
            this.Btn_DeletePattern.Name = "Btn_DeletePattern";
            this.Btn_DeletePattern.Size = new System.Drawing.Size(94, 33);
            this.Btn_DeletePattern.TabIndex = 2;
            this.Btn_DeletePattern.Text = "Delete Pattern";
            this.Btn_DeletePattern.UseVisualStyleBackColor = true;
            this.Btn_DeletePattern.Click += new System.EventHandler(this.Btn_DeletePattern_Click);
            // 
            // FrmViewColorPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 464);
            this.Controls.Add(this.Btn_DeletePattern);
            this.Controls.Add(this.Btn_ViewPattern);
            this.Controls.Add(this.Gb_ColorCollection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmViewColorPattern";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Pattern Collection";
            this.Load += new System.EventHandler(this.FrmViewColorPattern_Load);
            this.Gb_ColorCollection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvColorPattern)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_ColorCollection;
        private System.Windows.Forms.DataGridView DgvColorPattern;
        private System.Windows.Forms.Button Btn_ViewPattern;
        private System.Windows.Forms.Button Btn_DeletePattern;
    }
}