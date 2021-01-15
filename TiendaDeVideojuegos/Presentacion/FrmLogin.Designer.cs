namespace TiendaDeVideojuegos.Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtClave
            // 
            this.TxtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtClave.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(248, 239);
            this.TxtClave.MaxLength = 8;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(265, 35);
            this.TxtClave.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(148, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 37);
            this.label3.TabIndex = 29;
            this.label3.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(186, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 65);
            this.label1.TabIndex = 28;
            this.label1.Text = "INICIAR SESION";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigo.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(248, 179);
            this.TxtCodigo.MaxLength = 8;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(265, 35);
            this.TxtCodigo.TabIndex = 27;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(126, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 37);
            this.label2.TabIndex = 26;
            this.label2.Text = "Código:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.White;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnIngresar.Location = new System.Drawing.Point(363, 302);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(150, 51);
            this.BtnIngresar.TabIndex = 32;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 397);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnIngresar;
    }
}