namespace WinAppFunctions
{
    partial class frmSeno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.grbGraphic = new System.Windows.Forms.GroupBox();
            this.TablaGrafico = new System.Windows.Forms.PictureBox();
            this.grbOperations = new System.Windows.Forms.GroupBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaGrafico)).BeginInit();
            this.grbOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(19, 54);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(34, 20);
            this.txtA.TabIndex = 3;
            // 
            // grbGraphic
            // 
            this.grbGraphic.Controls.Add(this.TablaGrafico);
            this.grbGraphic.Location = new System.Drawing.Point(11, 12);
            this.grbGraphic.Name = "grbGraphic";
            this.grbGraphic.Size = new System.Drawing.Size(419, 331);
            this.grbGraphic.TabIndex = 10;
            this.grbGraphic.TabStop = false;
            this.grbGraphic.Text = "Gráfico";
            // 
            // TablaGrafico
            // 
            this.TablaGrafico.Location = new System.Drawing.Point(6, 19);
            this.TablaGrafico.Name = "TablaGrafico";
            this.TablaGrafico.Size = new System.Drawing.Size(400, 300);
            this.TablaGrafico.TabIndex = 1;
            this.TablaGrafico.TabStop = false;
            // 
            // grbOperations
            // 
            this.grbOperations.Controls.Add(this.lblMensaje);
            this.grbOperations.Controls.Add(this.label1);
            this.grbOperations.Controls.Add(this.btnCalcular);
            this.grbOperations.Controls.Add(this.txtA);
            this.grbOperations.Location = new System.Drawing.Point(436, 12);
            this.grbOperations.Name = "grbOperations";
            this.grbOperations.Size = new System.Drawing.Size(271, 331);
            this.grbOperations.TabIndex = 9;
            this.grbOperations.TabStop = false;
            this.grbOperations.Text = "Seno";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(27, 284);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 26;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(19, 97);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(225, 33);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmSeno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 354);
            this.Controls.Add(this.grbGraphic);
            this.Controls.Add(this.grbOperations);
            this.Name = "frmSeno";
            this.Text = "frmSeno";
            this.Load += new System.EventHandler(this.frmSeno_Load);
            this.grbGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaGrafico)).EndInit();
            this.grbOperations.ResumeLayout(false);
            this.grbOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.GroupBox grbGraphic;
        private System.Windows.Forms.PictureBox TablaGrafico;
        private System.Windows.Forms.GroupBox grbOperations;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnCalcular;
    }
}