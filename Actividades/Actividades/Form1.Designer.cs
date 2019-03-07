namespace Actividades
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
            this.pictureEstudents = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEstudents)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEstudents
            // 
            this.pictureEstudents.Image = ((System.Drawing.Image)(resources.GetObject("pictureEstudents.Image")));
            this.pictureEstudents.Location = new System.Drawing.Point(-2, -1);
            this.pictureEstudents.Name = "pictureEstudents";
            this.pictureEstudents.Size = new System.Drawing.Size(508, 374);
            this.pictureEstudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEstudents.TabIndex = 11;
            this.pictureEstudents.TabStop = false;
            this.pictureEstudents.Click += new System.EventHandler(this.pictureEstudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 374);
            this.Controls.Add(this.pictureEstudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEstudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureEstudents;
    }
}

