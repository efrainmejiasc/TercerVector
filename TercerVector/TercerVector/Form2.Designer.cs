namespace TercerVector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ListRojo = new System.Windows.Forms.ListBox();
            this.ListNegro = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Condiciones = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.AddNumber = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.pronostico = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pronostico.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListRojo
            // 
            this.ListRojo.BackColor = System.Drawing.Color.Red;
            this.ListRojo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRojo.ForeColor = System.Drawing.Color.White;
            this.ListRojo.FormattingEnabled = true;
            this.ListRojo.ItemHeight = 29;
            this.ListRojo.Location = new System.Drawing.Point(70, -2);
            this.ListRojo.Name = "ListRojo";
            this.ListRojo.Size = new System.Drawing.Size(71, 580);
            this.ListRojo.TabIndex = 10;
            // 
            // ListNegro
            // 
            this.ListNegro.BackColor = System.Drawing.Color.Black;
            this.ListNegro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListNegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNegro.ForeColor = System.Drawing.Color.White;
            this.ListNegro.FormattingEnabled = true;
            this.ListNegro.ItemHeight = 29;
            this.ListNegro.Location = new System.Drawing.Point(-1, -2);
            this.ListNegro.Name = "ListNegro";
            this.ListNegro.Size = new System.Drawing.Size(71, 580);
            this.ListNegro.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(142, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 502);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Condiciones
            // 
            this.Condiciones.BackColor = System.Drawing.Color.GreenYellow;
            this.Condiciones.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.Condiciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Condiciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Condiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Condiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condiciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Condiciones.Location = new System.Drawing.Point(84, 10);
            this.Condiciones.Name = "Condiciones";
            this.Condiciones.Size = new System.Drawing.Size(233, 31);
            this.Condiciones.TabIndex = 15;
            this.Condiciones.Text = "Ver Condiciones";
            this.Condiciones.UseVisualStyleBackColor = false;
            this.Condiciones.Visible = false;
            this.Condiciones.Click += new System.EventHandler(this.Condiciones_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Limpiar.Location = new System.Drawing.Point(142, 67);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(233, 31);
            this.Limpiar.TabIndex = 14;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // AddNumber
            // 
            this.AddNumber.BackColor = System.Drawing.Color.GreenYellow;
            this.AddNumber.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.AddNumber.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.AddNumber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddNumber.Location = new System.Drawing.Point(142, 38);
            this.AddNumber.Name = "AddNumber";
            this.AddNumber.Size = new System.Drawing.Size(233, 31);
            this.AddNumber.TabIndex = 13;
            this.AddNumber.Text = "Agregar Resultado";
            this.AddNumber.UseVisualStyleBackColor = false;
            this.AddNumber.Click += new System.EventHandler(this.AddNumber_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtResultado.Location = new System.Drawing.Point(142, 12);
            this.txtResultado.MaxLength = 2;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(233, 20);
            this.txtResultado.TabIndex = 12;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultado_KeyPress);
            this.txtResultado.Leave += new System.EventHandler(this.txtResultado_Leave);
            // 
            // pronostico
            // 
            this.pronostico.BackColor = System.Drawing.Color.SeaGreen;
            this.pronostico.Controls.Add(this.Condiciones);
            this.pronostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronostico.ForeColor = System.Drawing.Color.GreenYellow;
            this.pronostico.Location = new System.Drawing.Point(-1, 602);
            this.pronostico.Name = "pronostico";
            this.pronostico.Size = new System.Drawing.Size(376, 65);
            this.pronostico.TabIndex = 16;
            this.pronostico.TabStop = false;
            this.pronostico.Text = "groupBox1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(378, 666);
            this.Controls.Add(this.pronostico);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.AddNumber);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ListRojo);
            this.Controls.Add(this.ListNegro);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3er Vector";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pronostico.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListRojo;
        private System.Windows.Forms.ListBox ListNegro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Condiciones;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button AddNumber;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox pronostico;
    }
}