namespace LakoparkProjekt
{
    partial class stat
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
            this.statisz = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // statisz
            // 
            this.statisz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisz.Location = new System.Drawing.Point(0, 0);
            this.statisz.Name = "statisz";
            this.statisz.Size = new System.Drawing.Size(800, 450);
            this.statisz.TabIndex = 0;
            this.statisz.Text = "";
            // 
            // stat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statisz);
            this.Name = "stat";
            this.Text = "stat";
            this.Load += new System.EventHandler(this.stat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox statisz;
    }
}