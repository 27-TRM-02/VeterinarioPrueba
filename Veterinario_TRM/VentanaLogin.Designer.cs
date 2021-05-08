
namespace Veterinario_TRM
{
    partial class VentanaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLogin));
            this.DNIUsuario = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.passwordUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DNIUsuario
            // 
            this.DNIUsuario.Location = new System.Drawing.Point(94, 145);
            this.DNIUsuario.Name = "DNIUsuario";
            this.DNIUsuario.Size = new System.Drawing.Size(213, 20);
            this.DNIUsuario.TabIndex = 0;
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.Lime;
            this.Entrar.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrar.Location = new System.Drawing.Point(94, 327);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(213, 54);
            this.Entrar.TabIndex = 1;
            this.Entrar.Text = "ENTRAR...";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsuario.Location = new System.Drawing.Point(94, 79);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(213, 42);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "DNI:";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelContraseña
            // 
            this.labelContraseña.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelContraseña.Location = new System.Drawing.Point(96, 191);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(213, 42);
            this.labelContraseña.TabIndex = 4;
            this.labelContraseña.Text = "CONTRASEÑA:";
            this.labelContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordUsuario
            // 
            this.passwordUsuario.Location = new System.Drawing.Point(96, 257);
            this.passwordUsuario.Name = "passwordUsuario";
            this.passwordUsuario.Size = new System.Drawing.Size(213, 20);
            this.passwordUsuario.TabIndex = 3;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(404, 468);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.passwordUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.DNIUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaLogin";
            this.Text = "VentanaLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DNIUsuario;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.TextBox passwordUsuario;
    }
}