namespace WinAppFunctions
{
    partial class frmMenu
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
            this.btnCuadraticFuction = new System.Windows.Forms.Button();
            this.btn4petals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCuadraticFuction
            // 
            this.btnCuadraticFuction.Location = new System.Drawing.Point(139, 62);
            this.btnCuadraticFuction.Name = "btnCuadraticFuction";
            this.btnCuadraticFuction.Size = new System.Drawing.Size(244, 30);
            this.btnCuadraticFuction.TabIndex = 0;
            this.btnCuadraticFuction.Text = "Funcion Cuadratica";
            this.btnCuadraticFuction.UseVisualStyleBackColor = true;
            this.btnCuadraticFuction.Click += new System.EventHandler(this.btnCuadraticFuction_Click);
            // 
            // btn4petals
            // 
            this.btn4petals.Location = new System.Drawing.Point(139, 98);
            this.btn4petals.Name = "btn4petals";
            this.btn4petals.Size = new System.Drawing.Size(244, 30);
            this.btn4petals.TabIndex = 1;
            this.btn4petals.Text = "Rosa de 4 petalos";
            this.btn4petals.UseVisualStyleBackColor = true;
            this.btn4petals.Click += new System.EventHandler(this.btn4petals_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(139, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(244, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Coseno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Tangente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(139, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Funcion";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 413);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn4petals);
            this.Controls.Add(this.btnCuadraticFuction);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCuadraticFuction;
        private System.Windows.Forms.Button btn4petals;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

