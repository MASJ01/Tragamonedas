namespace Tragamonedas1
{
    partial class Form2
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
            this.lblcredito = new System.Windows.Forms.Label();
            this.txtcredito = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.lblscore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbximagen1 = new System.Windows.Forms.PictureBox();
            this.pbximagen2 = new System.Windows.Forms.PictureBox();
            this.pbximagen3 = new System.Windows.Forms.PictureBox();
            this.btnplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximagen3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcredito
            // 
            this.lblcredito.AutoSize = true;
            this.lblcredito.BackColor = System.Drawing.Color.Red;
            this.lblcredito.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcredito.Location = new System.Drawing.Point(50, 40);
            this.lblcredito.Name = "lblcredito";
            this.lblcredito.Size = new System.Drawing.Size(190, 26);
            this.lblcredito.TabIndex = 0;
            this.lblcredito.Text = "CREDIT: ";
            // 
            // txtcredito
            // 
            this.txtcredito.Location = new System.Drawing.Point(246, 46);
            this.txtcredito.Name = "txtcredito";
            this.txtcredito.Size = new System.Drawing.Size(110, 20);
            this.txtcredito.TabIndex = 1;
            // 
            // btnentrar
            // 
            this.btnentrar.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.Location = new System.Drawing.Point(362, 27);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(142, 49);
            this.btnentrar.TabIndex = 2;
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Blue;
            this.lblscore.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(550, 27);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(168, 26);
            this.lblscore.TabIndex = 3;
            this.lblscore.Text = "SCORE: ";
            this.lblscore.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pbximagen1
            // 
            this.pbximagen1.Location = new System.Drawing.Point(55, 113);
            this.pbximagen1.Name = "pbximagen1";
            this.pbximagen1.Size = new System.Drawing.Size(190, 183);
            this.pbximagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbximagen1.TabIndex = 5;
            this.pbximagen1.TabStop = false;
            this.pbximagen1.Visible = false;
            // 
            // pbximagen2
            // 
            this.pbximagen2.Location = new System.Drawing.Point(374, 115);
            this.pbximagen2.Name = "pbximagen2";
            this.pbximagen2.Size = new System.Drawing.Size(194, 181);
            this.pbximagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbximagen2.TabIndex = 6;
            this.pbximagen2.TabStop = false;
            this.pbximagen2.Visible = false;
            // 
            // pbximagen3
            // 
            this.pbximagen3.Location = new System.Drawing.Point(732, 113);
            this.pbximagen3.Name = "pbximagen3";
            this.pbximagen3.Size = new System.Drawing.Size(183, 177);
            this.pbximagen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbximagen3.TabIndex = 7;
            this.pbximagen3.TabStop = false;
            this.pbximagen3.Visible = false;
            // 
            // btnplay
            // 
            this.btnplay.BackgroundImage = global::Tragamonedas1.Properties.Resources.Play;
            this.btnplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnplay.Location = new System.Drawing.Point(395, 330);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(161, 104);
            this.btnplay.TabIndex = 8;
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Visible = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tragamonedas1.Properties.Resources.Marios2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 430);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.pbximagen3);
            this.Controls.Add(this.pbximagen2);
            this.Controls.Add(this.pbximagen1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txtcredito);
            this.Controls.Add(this.lblcredito);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbximagen3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcredito;
        private System.Windows.Forms.TextBox txtcredito;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbximagen1;
        private System.Windows.Forms.PictureBox pbximagen2;
        private System.Windows.Forms.PictureBox pbximagen3;
        private System.Windows.Forms.Button btnplay;
    }
}