
namespace Cliente_Proyecto
{
    partial class Logging
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
            this.ContraseñaT = new System.Windows.Forms.TextBox();
            this.UsuarioT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnviarB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContraseñaT
            // 
            this.ContraseñaT.Location = new System.Drawing.Point(242, 230);
            this.ContraseñaT.Name = "ContraseñaT";
            this.ContraseñaT.Size = new System.Drawing.Size(204, 22);
            this.ContraseñaT.TabIndex = 0;
            // 
            // UsuarioT
            // 
            this.UsuarioT.Location = new System.Drawing.Point(242, 103);
            this.UsuarioT.Name = "UsuarioT";
            this.UsuarioT.Size = new System.Drawing.Size(204, 22);
            this.UsuarioT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // EnviarB
            // 
            this.EnviarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnviarB.Location = new System.Drawing.Point(279, 330);
            this.EnviarB.Name = "EnviarB";
            this.EnviarB.Size = new System.Drawing.Size(117, 35);
            this.EnviarB.TabIndex = 4;
            this.EnviarB.Text = "Enviar";
            this.EnviarB.UseVisualStyleBackColor = true;
            this.EnviarB.Click += new System.EventHandler(this.EnviarB_Click);
            // 
            // Logging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 445);
            this.Controls.Add(this.EnviarB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuarioT);
            this.Controls.Add(this.ContraseñaT);
            this.Name = "Logging";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Logging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContraseñaT;
        private System.Windows.Forms.TextBox UsuarioT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EnviarB;
    }
}