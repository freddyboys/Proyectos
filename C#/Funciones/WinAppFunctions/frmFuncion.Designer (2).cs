namespace WinAppFunctions
{
    partial class frmFuncion
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
            this.picGraphic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listYp = new System.Windows.Forms.ListBox();
            this.listXp = new System.Windows.Forms.ListBox();
            this.listY = new System.Windows.Forms.ListBox();
            this.listX = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGraphic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picGraphic
            // 
            this.picGraphic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picGraphic.Location = new System.Drawing.Point(15, 34);
            this.picGraphic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picGraphic.Name = "picGraphic";
            this.picGraphic.Size = new System.Drawing.Size(550, 400);
            this.picGraphic.TabIndex = 0;
            this.picGraphic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.picGraphic);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(585, 462);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gráfico";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(27, 62);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(143, 34);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(631, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(260, 124);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(856, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Yp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Xp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "X";
            // 
            // listYp
            // 
            this.listYp.FormattingEnabled = true;
            this.listYp.Location = new System.Drawing.Point(846, 171);
            this.listYp.Name = "listYp";
            this.listYp.Size = new System.Drawing.Size(45, 316);
            this.listYp.TabIndex = 22;
            // 
            // listXp
            // 
            this.listXp.FormattingEnabled = true;
            this.listXp.Location = new System.Drawing.Point(771, 171);
            this.listXp.Name = "listXp";
            this.listXp.Size = new System.Drawing.Size(45, 316);
            this.listXp.TabIndex = 21;
            // 
            // listY
            // 
            this.listY.FormattingEnabled = true;
            this.listY.Location = new System.Drawing.Point(702, 171);
            this.listY.Name = "listY";
            this.listY.Size = new System.Drawing.Size(45, 316);
            this.listY.TabIndex = 20;
            // 
            // listX
            // 
            this.listX.FormattingEnabled = true;
            this.listX.Location = new System.Drawing.Point(631, 171);
            this.listX.Name = "listX";
            this.listX.Size = new System.Drawing.Size(45, 316);
            this.listX.TabIndex = 19;
            // 
            // frmFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listYp);
            this.Controls.Add(this.listXp);
            this.Controls.Add(this.listY);
            this.Controls.Add(this.listX);
            this.Name = "frmFuncion";
            this.Text = "frmFuncion";
            this.Load += new System.EventHandler(this.frmFuncion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGraphic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGraphic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listYp;
        private System.Windows.Forms.ListBox listXp;
        private System.Windows.Forms.ListBox listY;
        private System.Windows.Forms.ListBox listX;
    }
}