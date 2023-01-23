namespace LakoparkProjekt
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
            this.tarolo = new System.Windows.Forms.Panel();
            this.statisz = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.jobb_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bal_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tarolo
            // 
            this.tarolo.Location = new System.Drawing.Point(153, 0);
            this.tarolo.Name = "tarolo";
            this.tarolo.Size = new System.Drawing.Size(647, 363);
            this.tarolo.TabIndex = 0;
            // 
            // statisz
            // 
            this.statisz.Location = new System.Drawing.Point(21, 311);
            this.statisz.Name = "statisz";
            this.statisz.Size = new System.Drawing.Size(100, 43);
            this.statisz.TabIndex = 3;
            this.statisz.Text = "Statisztika";
            this.statisz.UseVisualStyleBackColor = true;
            this.statisz.Click += new System.EventHandler(this.statisz_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(21, 378);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 38);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // jobb_button
            // 
            this.jobb_button.Image = global::LakoparkProjekt.Properties.Resources.jobbnyil;
            this.jobb_button.Location = new System.Drawing.Point(338, 369);
            this.jobb_button.Name = "jobb_button";
            this.jobb_button.Size = new System.Drawing.Size(112, 56);
            this.jobb_button.TabIndex = 1;
            this.jobb_button.UseVisualStyleBackColor = true;
            this.jobb_button.Click += new System.EventHandler(this.jobb_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 205);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bal_button
            // 
            this.bal_button.Image = global::LakoparkProjekt.Properties.Resources.balnyil;
            this.bal_button.Location = new System.Drawing.Point(153, 369);
            this.bal_button.Name = "bal_button";
            this.bal_button.Size = new System.Drawing.Size(112, 56);
            this.bal_button.TabIndex = 0;
            this.bal_button.UseVisualStyleBackColor = true;
            this.bal_button.Click += new System.EventHandler(this.bal_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.statisz);
            this.Controls.Add(this.jobb_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bal_button);
            this.Controls.Add(this.tarolo);
            this.Name = "Form1";
            this.Text = "LakóPark";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tarolo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button jobb_button;
        public System.Windows.Forms.Button bal_button;
        private System.Windows.Forms.Button statisz;
        private System.Windows.Forms.Button save;
    }
}

