namespace TercerVector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListNegro = new System.Windows.Forms.ListBox();
            this.ListRojo = new System.Windows.Forms.ListBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.AddNumber = new System.Windows.Forms.Button();
            this.checkNegro = new System.Windows.Forms.CheckBox();
            this.checkRojo = new System.Windows.Forms.CheckBox();
            this.NuevoCiclo = new System.Windows.Forms.Button();
            this.EliminarResultado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pronostico = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GuardarRuta = new System.Windows.Forms.Button();
            this.txtPronostico = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pronostico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListNegro
            // 
            this.ListNegro.BackColor = System.Drawing.Color.Black;
            this.ListNegro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListNegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNegro.ForeColor = System.Drawing.Color.White;
            this.ListNegro.FormattingEnabled = true;
            this.ListNegro.ItemHeight = 16;
            this.ListNegro.Location = new System.Drawing.Point(1, -1);
            this.ListNegro.Name = "ListNegro";
            this.ListNegro.Size = new System.Drawing.Size(71, 496);
            this.ListNegro.TabIndex = 7;
            // 
            // ListRojo
            // 
            this.ListRojo.BackColor = System.Drawing.Color.Red;
            this.ListRojo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRojo.ForeColor = System.Drawing.Color.White;
            this.ListRojo.FormattingEnabled = true;
            this.ListRojo.ItemHeight = 16;
            this.ListRojo.Location = new System.Drawing.Point(72, -1);
            this.ListRojo.Name = "ListRojo";
            this.ListRojo.Size = new System.Drawing.Size(71, 496);
            this.ListRojo.TabIndex = 8;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtResultado.Location = new System.Drawing.Point(149, 12);
            this.txtResultado.MaxLength = 2;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(180, 20);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtResultado_KeyPress);
            this.txtResultado.Leave += new System.EventHandler(this.txtResultado_Leave);
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
            this.AddNumber.Location = new System.Drawing.Point(149, 38);
            this.AddNumber.Name = "AddNumber";
            this.AddNumber.Size = new System.Drawing.Size(180, 31);
            this.AddNumber.TabIndex = 1;
            this.AddNumber.Text = "Agregar Resultado";
            this.AddNumber.UseVisualStyleBackColor = false;
            this.AddNumber.Click += new System.EventHandler(this.AddNumber_Click);
            // 
            // checkNegro
            // 
            this.checkNegro.AutoSize = true;
            this.checkNegro.BackColor = System.Drawing.Color.Black;
            this.checkNegro.ForeColor = System.Drawing.Color.White;
            this.checkNegro.Location = new System.Drawing.Point(7, 3);
            this.checkNegro.Name = "checkNegro";
            this.checkNegro.Size = new System.Drawing.Size(99, 19);
            this.checkNegro.TabIndex = 0;
            this.checkNegro.Text = "Cero Negro";
            this.checkNegro.UseVisualStyleBackColor = false;
            this.checkNegro.Visible = false;
            this.checkNegro.CheckedChanged += new System.EventHandler(this.checkNegro_CheckedChanged);
            // 
            // checkRojo
            // 
            this.checkRojo.AutoSize = true;
            this.checkRojo.BackColor = System.Drawing.Color.Red;
            this.checkRojo.ForeColor = System.Drawing.Color.White;
            this.checkRojo.Location = new System.Drawing.Point(6, 3);
            this.checkRojo.Name = "checkRojo";
            this.checkRojo.Size = new System.Drawing.Size(90, 19);
            this.checkRojo.TabIndex = 0;
            this.checkRojo.Text = "Cero Rojo";
            this.checkRojo.UseVisualStyleBackColor = false;
            this.checkRojo.CheckedChanged += new System.EventHandler(this.checkRojo_CheckedChanged);
            // 
            // NuevoCiclo
            // 
            this.NuevoCiclo.BackColor = System.Drawing.Color.GreenYellow;
            this.NuevoCiclo.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.NuevoCiclo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.NuevoCiclo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NuevoCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoCiclo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NuevoCiclo.Location = new System.Drawing.Point(4, 505);
            this.NuevoCiclo.Name = "NuevoCiclo";
            this.NuevoCiclo.Size = new System.Drawing.Size(139, 31);
            this.NuevoCiclo.TabIndex = 5;
            this.NuevoCiclo.Text = "Nuevo Ciclo";
            this.NuevoCiclo.UseVisualStyleBackColor = false;
            this.NuevoCiclo.Visible = false;
            this.NuevoCiclo.Click += new System.EventHandler(this.NuevoCiclo_Click);
            // 
            // EliminarResultado
            // 
            this.EliminarResultado.BackColor = System.Drawing.Color.GreenYellow;
            this.EliminarResultado.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.EliminarResultado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.EliminarResultado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EliminarResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.EliminarResultado.Location = new System.Drawing.Point(149, 75);
            this.EliminarResultado.Name = "EliminarResultado";
            this.EliminarResultado.Size = new System.Drawing.Size(180, 31);
            this.EliminarResultado.TabIndex = 4;
            this.EliminarResultado.Text = "Limpiar";
            this.EliminarResultado.UseVisualStyleBackColor = false;
            this.EliminarResultado.Click += new System.EventHandler(this.EliminarResultado_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.checkNegro);
            this.panel1.Location = new System.Drawing.Point(55, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 25);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.checkRojo);
            this.panel2.Location = new System.Drawing.Point(145, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 25);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // pronostico
            // 
            this.pronostico.BackColor = System.Drawing.Color.SeaGreen;
            this.pronostico.Controls.Add(this.panel2);
            this.pronostico.Controls.Add(this.panel1);
            this.pronostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pronostico.ForeColor = System.Drawing.Color.GreenYellow;
            this.pronostico.Location = new System.Drawing.Point(4, 500);
            this.pronostico.Name = "pronostico";
            this.pronostico.Size = new System.Drawing.Size(325, 98);
            this.pronostico.TabIndex = 6;
            this.pronostico.TabStop = false;
            this.pronostico.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(149, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 382);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // GuardarRuta
            // 
            this.GuardarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GuardarRuta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GuardarRuta.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.GuardarRuta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.GuardarRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GuardarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GuardarRuta.Location = new System.Drawing.Point(0, 579);
            this.GuardarRuta.Name = "GuardarRuta";
            this.GuardarRuta.Size = new System.Drawing.Size(337, 31);
            this.GuardarRuta.TabIndex = 10;
            this.GuardarRuta.Text = "Guardar Ruta";
            this.GuardarRuta.UseVisualStyleBackColor = false;
            this.GuardarRuta.Visible = false;
            this.GuardarRuta.Click += new System.EventHandler(this.GuardarRuta_Click);
            // 
            // txtPronostico
            // 
            this.txtPronostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPronostico.Location = new System.Drawing.Point(0, 562);
            this.txtPronostico.MaxLength = 50;
            this.txtPronostico.Name = "txtPronostico";
            this.txtPronostico.Size = new System.Drawing.Size(337, 20);
            this.txtPronostico.TabIndex = 11;
            this.txtPronostico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPronostico.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(344, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Nuevo Ciclo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(337, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPronostico);
            this.Controls.Add(this.GuardarRuta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pronostico);
            this.Controls.Add(this.EliminarResultado);
            this.Controls.Add(this.NuevoCiclo);
            this.Controls.Add(this.AddNumber);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.ListRojo);
            this.Controls.Add(this.ListNegro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3er Vector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pronostico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListNegro;
        private System.Windows.Forms.ListBox ListRojo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button AddNumber;
        private System.Windows.Forms.CheckBox checkNegro;
        private System.Windows.Forms.CheckBox checkRojo;
        private System.Windows.Forms.Button NuevoCiclo;
        private System.Windows.Forms.Button EliminarResultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox pronostico;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GuardarRuta;
        private System.Windows.Forms.TextBox txtPronostico;
        private System.Windows.Forms.Button button1;
    }
}

