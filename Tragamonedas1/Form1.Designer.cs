namespace Tragamonedas1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pgbcarga = new System.Windows.Forms.ProgressBar();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblcargando = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbcarga
            // 
            this.pgbcarga.Location = new System.Drawing.Point(174, 339);
            this.pgbcarga.Name = "pgbcarga";
            this.pgbcarga.Size = new System.Drawing.Size(651, 39);
            this.pgbcarga.TabIndex = 0;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Yellow;
            this.lbltitulo.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(341, 47);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(360, 28);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "TRAGAMONEDAS MARIO BROS";
            // 
            // lblcargando
            // 
            this.lblcargando.AutoSize = true;
            this.lblcargando.BackColor = System.Drawing.Color.Lime;
            this.lblcargando.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargando.Location = new System.Drawing.Point(478, 286);
            this.lblcargando.Name = "lblcargando";
            this.lblcargando.Size = new System.Drawing.Size(118, 27);
            this.lblcargando.TabIndex = 2;
            this.lblcargando.Text = "LOADING...";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tragamonedas1.Properties.Resources.Marios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 390);
            this.Controls.Add(this.lblcargando);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.pgbcarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbcarga;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblcargando;
        private System.Windows.Forms.Timer timer1;
    }
}

