namespace Saludo
{
    partial class saludo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saludo));
            this.Saludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Saludar
            // 
            this.Saludar.BackColor = System.Drawing.Color.Transparent;
            this.Saludar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Saludar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Saludar.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Saludar.Location = new System.Drawing.Point(123, 33);
            this.Saludar.Name = "Saludar";
            this.Saludar.Size = new System.Drawing.Size(159, 64);
            this.Saludar.TabIndex = 0;
            this.Saludar.Text = "Mostrar";
            this.Saludar.UseVisualStyleBackColor = false;
            this.Saludar.Click += new System.EventHandler(this.Saludar_Click);
            // 
            // saludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 125);
            this.Controls.Add(this.Saludar);
            this.Name = "saludo";
            this.Text = "Saludo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Saludar;
    }
}

