
namespace Veterinario_TRM
{
    partial class AltaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaUsuario));
            this.DNIAlta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Alta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.apellidosAlta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailAlta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombreAlta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordAlta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DNIAlta
            // 
            this.DNIAlta.Location = new System.Drawing.Point(151, 23);
            this.DNIAlta.Name = "DNIAlta";
            this.DNIAlta.Size = new System.Drawing.Size(430, 20);
            this.DNIAlta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI:";
            // 
            // Alta
            // 
            this.Alta.BackColor = System.Drawing.Color.Lime;
            this.Alta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Alta.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alta.Location = new System.Drawing.Point(16, 308);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(565, 43);
            this.Alta.TabIndex = 2;
            this.Alta.Text = "Crear Usuario";
            this.Alta.UseVisualStyleBackColor = false;
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "APELLIDOS:";
            // 
            // apellidosAlta
            // 
            this.apellidosAlta.Location = new System.Drawing.Point(151, 119);
            this.apellidosAlta.Name = "apellidosAlta";
            this.apellidosAlta.Size = new System.Drawing.Size(430, 20);
            this.apellidosAlta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "EMAIL:";
            // 
            // emailAlta
            // 
            this.emailAlta.Location = new System.Drawing.Point(151, 168);
            this.emailAlta.Name = "emailAlta";
            this.emailAlta.Size = new System.Drawing.Size(430, 20);
            this.emailAlta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "NOMBRE:";
            // 
            // nombreAlta
            // 
            this.nombreAlta.Location = new System.Drawing.Point(151, 72);
            this.nombreAlta.Name = "nombreAlta";
            this.nombreAlta.Size = new System.Drawing.Size(430, 20);
            this.nombreAlta.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "CONTRASEÑA:";
            // 
            // passwordAlta
            // 
            this.passwordAlta.Location = new System.Drawing.Point(151, 215);
            this.passwordAlta.Name = "passwordAlta";
            this.passwordAlta.Size = new System.Drawing.Size(430, 20);
            this.passwordAlta.TabIndex = 9;
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(598, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordAlta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombreAlta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailAlta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellidosAlta);
            this.Controls.Add(this.Alta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DNIAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AltaUsuario";
            this.Text = "AltaUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DNIAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Alta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellidosAlta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailAlta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombreAlta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordAlta;
    }
}