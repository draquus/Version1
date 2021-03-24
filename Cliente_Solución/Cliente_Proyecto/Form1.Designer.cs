
namespace Cliente_Proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResultadosR = new System.Windows.Forms.RadioButton();
            this.PganadasR = new System.Windows.Forms.RadioButton();
            this.MostrarJR = new System.Windows.Forms.RadioButton();
            this.nombreG = new System.Windows.Forms.TextBox();
            this.ConectarB = new System.Windows.Forms.Button();
            this.DesconectarB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IniciarSB = new System.Windows.Forms.Button();
            this.RegistrarB = new System.Windows.Forms.Button();
            this.EnviarB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultadosR
            // 
            this.ResultadosR.AutoSize = true;
            this.ResultadosR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadosR.Location = new System.Drawing.Point(182, 155);
            this.ResultadosR.Name = "ResultadosR";
            this.ResultadosR.Size = new System.Drawing.Size(203, 22);
            this.ResultadosR.TabIndex = 0;
            this.ResultadosR.TabStop = true;
            this.ResultadosR.Text = "Resultados de las partidas";
            this.ResultadosR.UseVisualStyleBackColor = true;
            // 
            // PganadasR
            // 
            this.PganadasR.AutoSize = true;
            this.PganadasR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PganadasR.Location = new System.Drawing.Point(182, 195);
            this.PganadasR.Name = "PganadasR";
            this.PganadasR.Size = new System.Drawing.Size(173, 22);
            this.PganadasR.TabIndex = 1;
            this.PganadasR.TabStop = true;
            this.PganadasR.Text = "Partidas ganadas por:";
            this.PganadasR.UseVisualStyleBackColor = true;
            // 
            // MostrarJR
            // 
            this.MostrarJR.AutoSize = true;
            this.MostrarJR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarJR.Location = new System.Drawing.Point(182, 237);
            this.MostrarJR.Name = "MostrarJR";
            this.MostrarJR.Size = new System.Drawing.Size(216, 22);
            this.MostrarJR.TabIndex = 3;
            this.MostrarJR.TabStop = true;
            this.MostrarJR.Text = "Mostrar todos los jugadores";
            this.MostrarJR.UseVisualStyleBackColor = true;
            // 
            // nombreG
            // 
            this.nombreG.Location = new System.Drawing.Point(379, 195);
            this.nombreG.Name = "nombreG";
            this.nombreG.Size = new System.Drawing.Size(112, 22);
            this.nombreG.TabIndex = 4;
            // 
            // ConectarB
            // 
            this.ConectarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConectarB.Location = new System.Drawing.Point(51, 359);
            this.ConectarB.Name = "ConectarB";
            this.ConectarB.Size = new System.Drawing.Size(105, 32);
            this.ConectarB.TabIndex = 5;
            this.ConectarB.Text = "Conectar";
            this.ConectarB.UseVisualStyleBackColor = true;
            this.ConectarB.Click += new System.EventHandler(this.ConectarB_Click);
            // 
            // DesconectarB
            // 
            this.DesconectarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesconectarB.Location = new System.Drawing.Point(162, 359);
            this.DesconectarB.Name = "DesconectarB";
            this.DesconectarB.Size = new System.Drawing.Size(129, 32);
            this.DesconectarB.TabIndex = 6;
            this.DesconectarB.Text = "Desconectar";
            this.DesconectarB.UseVisualStyleBackColor = true;
            this.DesconectarB.Click += new System.EventHandler(this.DesconectarB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menú";
            // 
            // IniciarSB
            // 
            this.IniciarSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSB.Location = new System.Drawing.Point(563, 141);
            this.IniciarSB.Name = "IniciarSB";
            this.IniciarSB.Size = new System.Drawing.Size(176, 42);
            this.IniciarSB.TabIndex = 8;
            this.IniciarSB.Text = "Iniciar sesión";
            this.IniciarSB.UseVisualStyleBackColor = true;
            this.IniciarSB.Click += new System.EventHandler(this.IniciarSB_Click);
            // 
            // RegistrarB
            // 
            this.RegistrarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarB.Location = new System.Drawing.Point(563, 205);
            this.RegistrarB.Name = "RegistrarB";
            this.RegistrarB.Size = new System.Drawing.Size(176, 37);
            this.RegistrarB.TabIndex = 9;
            this.RegistrarB.Text = "Registrarse";
            this.RegistrarB.UseVisualStyleBackColor = true;
            this.RegistrarB.Click += new System.EventHandler(this.RegistrarB_Click);
            // 
            // EnviarB
            // 
            this.EnviarB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnviarB.Location = new System.Drawing.Point(379, 359);
            this.EnviarB.Name = "EnviarB";
            this.EnviarB.Size = new System.Drawing.Size(142, 31);
            this.EnviarB.TabIndex = 10;
            this.EnviarB.Text = "Enviar petición";
            this.EnviarB.UseVisualStyleBackColor = true;
            this.EnviarB.Click += new System.EventHandler(this.EnviarB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.EnviarB);
            this.Controls.Add(this.RegistrarB);
            this.Controls.Add(this.IniciarSB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DesconectarB);
            this.Controls.Add(this.ConectarB);
            this.Controls.Add(this.nombreG);
            this.Controls.Add(this.MostrarJR);
            this.Controls.Add(this.PganadasR);
            this.Controls.Add(this.ResultadosR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ResultadosR;
        private System.Windows.Forms.RadioButton PganadasR;
        private System.Windows.Forms.RadioButton MostrarJR;
        private System.Windows.Forms.TextBox nombreG;
        private System.Windows.Forms.Button ConectarB;
        private System.Windows.Forms.Button DesconectarB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IniciarSB;
        private System.Windows.Forms.Button RegistrarB;
        private System.Windows.Forms.Button EnviarB;
    }
}

