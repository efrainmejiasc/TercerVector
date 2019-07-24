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
            this.ListNegro = new System.Windows.Forms.ListBox();
            this.ListRojo = new System.Windows.Forms.ListBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.AddNumber = new System.Windows.Forms.Button();
            this.checkNegro = new System.Windows.Forms.CheckBox();
            this.checkRojo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ListNegro
            // 
            this.ListNegro.BackColor = System.Drawing.Color.Black;
            this.ListNegro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNegro.ForeColor = System.Drawing.Color.White;
            this.ListNegro.FormattingEnabled = true;
            this.ListNegro.ItemHeight = 16;
            this.ListNegro.Location = new System.Drawing.Point(1, -1);
            this.ListNegro.Name = "ListNegro";
            this.ListNegro.Size = new System.Drawing.Size(71, 484);
            this.ListNegro.TabIndex = 0;
            // 
            // ListRojo
            // 
            this.ListRojo.BackColor = System.Drawing.Color.Red;
            this.ListRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListRojo.ForeColor = System.Drawing.Color.White;
            this.ListRojo.FormattingEnabled = true;
            this.ListRojo.ItemHeight = 16;
            this.ListRojo.Location = new System.Drawing.Point(72, -1);
            this.ListRojo.Name = "ListRojo";
            this.ListRojo.Size = new System.Drawing.Size(71, 484);
            this.ListRojo.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(149, 12);
            this.txtResultado.MaxLength = 2;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(62, 20);
            this.txtResultado.TabIndex = 2;
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
            this.AddNumber.Location = new System.Drawing.Point(149, 61);
            this.AddNumber.Name = "AddNumber";
            this.AddNumber.Size = new System.Drawing.Size(160, 31);
            this.AddNumber.TabIndex = 3;
            this.AddNumber.Text = "Agregar";
            this.AddNumber.UseVisualStyleBackColor = false;
            this.AddNumber.Click += new System.EventHandler(this.AddNumber_Click);
            // 
            // checkNegro
            // 
            this.checkNegro.AutoSize = true;
            this.checkNegro.BackColor = System.Drawing.Color.Black;
            this.checkNegro.ForeColor = System.Drawing.Color.White;
            this.checkNegro.Location = new System.Drawing.Point(149, 38);
            this.checkNegro.Name = "checkNegro";
            this.checkNegro.Size = new System.Drawing.Size(80, 17);
            this.checkNegro.TabIndex = 4;
            this.checkNegro.Text = "Cero Negro";
            this.checkNegro.UseVisualStyleBackColor = false;
            this.checkNegro.CheckedChanged += new System.EventHandler(this.checkNegro_CheckedChanged);
            // 
            // checkRojo
            // 
            this.checkRojo.AutoSize = true;
            this.checkRojo.BackColor = System.Drawing.Color.Red;
            this.checkRojo.ForeColor = System.Drawing.Color.White;
            this.checkRojo.Location = new System.Drawing.Point(235, 38);
            this.checkRojo.Name = "checkRojo";
            this.checkRojo.Size = new System.Drawing.Size(73, 17);
            this.checkRojo.TabIndex = 5;
            this.checkRojo.Text = "Cero Rojo";
            this.checkRojo.UseVisualStyleBackColor = false;
            this.checkRojo.CheckedChanged += new System.EventHandler(this.checkRojo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(315, 482);
            this.Controls.Add(this.checkRojo);
            this.Controls.Add(this.checkNegro);
            this.Controls.Add(this.AddNumber);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.ListRojo);
            this.Controls.Add(this.ListNegro);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3er Vector";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

