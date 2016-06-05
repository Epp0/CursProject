namespace CursMain
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.but_sklad = new System.Windows.Forms.Button();
            this.but_recept = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_sklad
            // 
            this.but_sklad.BackColor = System.Drawing.Color.Red;
            this.but_sklad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_sklad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_sklad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_sklad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_sklad.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_sklad.ForeColor = System.Drawing.Color.White;
            this.but_sklad.Location = new System.Drawing.Point(210, 245);
            this.but_sklad.Name = "but_sklad";
            this.but_sklad.Size = new System.Drawing.Size(105, 57);
            this.but_sklad.TabIndex = 0;
            this.but_sklad.Text = "Склад";
            this.but_sklad.UseVisualStyleBackColor = false;
            this.but_sklad.Click += new System.EventHandler(this.but_sklad_Click);
            // 
            // but_recept
            // 
            this.but_recept.BackColor = System.Drawing.Color.Red;
            this.but_recept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_recept.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.but_recept.FlatAppearance.BorderSize = 2;
            this.but_recept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_recept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_recept.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_recept.ForeColor = System.Drawing.Color.White;
            this.but_recept.Location = new System.Drawing.Point(67, 245);
            this.but_recept.Name = "but_recept";
            this.but_recept.Size = new System.Drawing.Size(105, 57);
            this.but_recept.TabIndex = 1;
            this.but_recept.Text = "Рецепты";
            this.but_recept.UseVisualStyleBackColor = false;
            this.but_recept.Click += new System.EventHandler(this.but_recept_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 188);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(384, 326);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_recept);
            this.Controls.Add(this.but_sklad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Шеф-Повар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_sklad;
        private System.Windows.Forms.Button but_recept;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}