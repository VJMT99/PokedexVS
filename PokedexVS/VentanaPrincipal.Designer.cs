namespace PokedexVS
{
    partial class VentanaPrincipal
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
            this.izquierda = new System.Windows.Forms.Button();
            this.derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // izquierda
            // 
            this.izquierda.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.Location = new System.Drawing.Point(86, 253);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(99, 40);
            this.izquierda.TabIndex = 0;
            this.izquierda.Text = "<\r\n";
            this.izquierda.UseVisualStyleBackColor = true;
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // derecha
            // 
            this.derecha.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.Location = new System.Drawing.Point(191, 253);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(99, 40);
            this.derecha.TabIndex = 2;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = true;
            this.derecha.Click += new System.EventHandler(this.derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(83, 168);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(207, 51);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Text = "label1";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 397);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.izquierda);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Label nombrePokemon;
    }
}

