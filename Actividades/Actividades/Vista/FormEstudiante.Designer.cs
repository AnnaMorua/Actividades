namespace Actividades.Vista
{
    partial class FormEstudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.textoNumeroControl = new System.Windows.Forms.TextBox();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.textoEdad = new System.Windows.Forms.TextBox();
            this.textoGenero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de Estudiante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Control: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Género:";
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMostrar.Location = new System.Drawing.Point(917, 546);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(204, 49);
            this.buttonMostrar.TabIndex = 5;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // textoNumeroControl
            // 
            this.textoNumeroControl.Location = new System.Drawing.Point(350, 139);
            this.textoNumeroControl.Multiline = true;
            this.textoNumeroControl.Name = "textoNumeroControl";
            this.textoNumeroControl.Size = new System.Drawing.Size(345, 44);
            this.textoNumeroControl.TabIndex = 6;
            this.textoNumeroControl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(350, 225);
            this.textoNombre.Multiline = true;
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(345, 43);
            this.textoNombre.TabIndex = 7;
            // 
            // textoEdad
            // 
            this.textoEdad.Location = new System.Drawing.Point(350, 297);
            this.textoEdad.Multiline = true;
            this.textoEdad.Name = "textoEdad";
            this.textoEdad.Size = new System.Drawing.Size(345, 43);
            this.textoEdad.TabIndex = 8;
            // 
            // textoGenero
            // 
            this.textoGenero.Location = new System.Drawing.Point(350, 369);
            this.textoGenero.Multiline = true;
            this.textoGenero.Name = "textoGenero";
            this.textoGenero.Size = new System.Drawing.Size(345, 43);
            this.textoGenero.TabIndex = 9;
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1204, 635);
            this.Controls.Add(this.textoGenero);
            this.Controls.Add(this.textoEdad);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.textoNumeroControl);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEstudiante";
            this.Text = "FormEstudiante";
            this.Load += new System.EventHandler(this.FormEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.TextBox textoNumeroControl;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.TextBox textoEdad;
        private System.Windows.Forms.TextBox textoGenero;
    }
}