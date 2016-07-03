namespace WinAppTicTacToe
{
    partial class frmTicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicTacToe));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpContent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.grbMessages = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.grbTicTacToe = new System.Windows.Forms.GroupBox();
            this.btnTicTacToe9 = new System.Windows.Forms.Button();
            this.btnTicTacToe8 = new System.Windows.Forms.Button();
            this.btnTicTacToe7 = new System.Windows.Forms.Button();
            this.btnTicTacToe6 = new System.Windows.Forms.Button();
            this.btnTicTacToe5 = new System.Windows.Forms.Button();
            this.btnTicTacToe4 = new System.Windows.Forms.Button();
            this.btnTicTacToe3 = new System.Windows.Forms.Button();
            this.btnTicTacToe2 = new System.Windows.Forms.Button();
            this.btnTicTacToe1 = new System.Windows.Forms.Button();
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            this.grbTicTacToe.SuspendLayout();
            this.grbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileSeparator1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(60, 20);
            this.mnuFile.Text = "Archivo";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(109, 22);
            this.mnuFileNew.Text = "Nuevo";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // mnuFileSeparator1
            // 
            this.mnuFileSeparator1.Name = "mnuFileSeparator1";
            this.mnuFileSeparator1.Size = new System.Drawing.Size(106, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(109, 22);
            this.mnuFileExit.Text = "Salir";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpContent,
            this.mnuHelpSeparator1,
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(53, 20);
            this.mnuHelp.Text = "Ayuda";
            // 
            // mnuHelpContent
            // 
            this.mnuHelpContent.Name = "mnuHelpContent";
            this.mnuHelpContent.Size = new System.Drawing.Size(135, 22);
            this.mnuHelpContent.Text = "Contenido";
            this.mnuHelpContent.Click += new System.EventHandler(this.mnuHelpContent_Click);
            // 
            // mnuHelpSeparator1
            // 
            this.mnuHelpSeparator1.Name = "mnuHelpSeparator1";
            this.mnuHelpSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(135, 22);
            this.mnuHelpAbout.Text = "Acerca de...";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // grbMessages
            // 
            this.grbMessages.Controls.Add(this.lblMessage);
            this.grbMessages.Controls.Add(this.picCharacter);
            this.grbMessages.Location = new System.Drawing.Point(29, 41);
            this.grbMessages.Name = "grbMessages";
            this.grbMessages.Size = new System.Drawing.Size(297, 94);
            this.grbMessages.TabIndex = 1;
            this.grbMessages.TabStop = false;
            this.grbMessages.Enter += new System.EventHandler(this.grbMessages_Enter);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(127, 34);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(143, 20);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Horas de Diversion";
            // 
            // picCharacter
            // 
            this.picCharacter.Image = ((System.Drawing.Image)(resources.GetObject("picCharacter.Image")));
            this.picCharacter.InitialImage = null;
            this.picCharacter.Location = new System.Drawing.Point(6, 19);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(64, 64);
            this.picCharacter.TabIndex = 0;
            this.picCharacter.TabStop = false;
            // 
            // grbTicTacToe
            // 
            this.grbTicTacToe.Controls.Add(this.btnTicTacToe9);
            this.grbTicTacToe.Controls.Add(this.btnTicTacToe8);
            this.grbTicTacToe.Controls.Add(this.btnTicTacToe7);
            this.grbTicTacToe.Controls.Add(this.btnTicTacToe6);
            this.grbTicTacToe.Controls.Add(this.btnTicTacToe5);
            this.grbTicTacToe.Controls.Add(this.btnTicTacToe4);
            this.grbTicTacToe.Controls.Add(this.btnTicTacToe3);
            this.grbTicTacToe.Controls.Add(this.btnTicTacToe2);
            this.grbTicTacToe.Controls.Add(this.btnTicTacToe1);
            this.grbTicTacToe.Location = new System.Drawing.Point(29, 178);
            this.grbTicTacToe.Name = "grbTicTacToe";
            this.grbTicTacToe.Size = new System.Drawing.Size(297, 222);
            this.grbTicTacToe.TabIndex = 2;
            this.grbTicTacToe.TabStop = false;
            // 
            // btnTicTacToe9
            // 
            this.btnTicTacToe9.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicTacToe9.Location = new System.Drawing.Point(198, 151);
            this.btnTicTacToe9.Name = "btnTicTacToe9";
            this.btnTicTacToe9.Size = new System.Drawing.Size(60, 60);
            this.btnTicTacToe9.TabIndex = 8;
            this.btnTicTacToe9.Text = "X";
            this.btnTicTacToe9.UseVisualStyleBackColor = true;
            this.btnTicTacToe9.Click += new System.EventHandler(this.btnTicTacToe9_Click);
            // 
            // btnTicTacToe8
            // 
            this.btnTicTacToe8.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicTacToe8.Location = new System.Drawing.Point(117, 151);
            this.btnTicTacToe8.Name = "btnTicTacToe8";
            this.btnTicTacToe8.Size = new System.Drawing.Size(60, 60);
            this.btnTicTacToe8.TabIndex = 7;
            this.btnTicTacToe8.Text = "X";
            this.btnTicTacToe8.UseVisualStyleBackColor = true;
            this.btnTicTacToe8.Click += new System.EventHandler(this.btnTicTacToe8_Click);
            // 
            // btnTicTacToe7
            // 
            this.btnTicTacToe7.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicTacToe7.Location = new System.Drawing.Point(39, 151);
            this.btnTicTacToe7.Name = "btnTicTacToe7";
            this.btnTicTacToe7.Size = new System.Drawing.Size(60, 60);
            this.btnTicTacToe7.TabIndex = 6;
            this.btnTicTacToe7.Text = "X";
            this.btnTicTacToe7.UseVisualStyleBackColor = true;
            this.btnTicTacToe7.Click += new System.EventHandler(this.btnTicTacToe7_Click);
            // 
            // btnTicTacToe6
            // 
            this.btnTicTacToe6.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicTacToe6.Location = new System.Drawing.Point(198, 85);
            this.btnTicTacToe6.Name = "btnTicTacToe6";
            this.btnTicTacToe6.Size = new System.Drawing.Size(60, 60);
            this.btnTicTacToe6.TabIndex = 5;
            this.btnTicTacToe6.Text = "X";
            this.btnTicTacToe6.UseVisualStyleBackColor = true;
            this.btnTicTacToe6.Click += new System.EventHandler(this.btnTicTacToe6_Click);
            // 
            // btnTicTacToe5
            // 
            this.btnTicTacToe5.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicTacToe5.Location = new System.Drawing.Point(117, 85);
            this.btnTicTacToe5.Name = "btnTicTacToe5";
            this.btnTicTacToe5.Size = new System.Drawing.Size(60, 60);
            this.btnTicTacToe5.TabIndex = 4;
            this.btnTicTacToe5.Text = "X";
            this.btnTicTacToe5.UseVisualStyleBackColor = true;
            this.btnTicTacToe5.Click += new System.EventHandler(this.btnTicTacToe5_Click);
            // 
            // btnTicTacToe4
            // 
            this.btnTicTacToe4.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicTacToe4.Location = new System.Drawing.Point(39, 85);
            this.btnTicTacToe4.Name = "btnTicTacToe4";
            this.btnTicTacToe4.Size = new System.Drawing.Size(60, 60);
            this.btnTicTacToe4.TabIndex = 3;
            this.btnTicTacToe4.Text = "X";
            this.btnTicTacToe4.UseVisualStyleBackColor = true;
            this.btnTicTacToe4.Click += new System.EventHandler(this.btnTicTacToe4_Click);
            // 
            // btnTicTacToe3
            // 
            this.btnTicTacToe3.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicTacToe3.Location = new System.Drawing.Point(198, 19);
            this.btnTicTacToe3.Name = "btnTicTacToe3";
            this.btnTicTacToe3.Size = new System.Drawing.Size(60, 60);
            this.btnTicTacToe3.TabIndex = 2;
            this.btnTicTacToe3.Text = "X";
            this.btnTicTacToe3.UseVisualStyleBackColor = true;
            this.btnTicTacToe3.Click += new System.EventHandler(this.btnTicTacToe3_Click);
            // 
            // btnTicTacToe2
            // 
            this.btnTicTacToe2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicTacToe2.Location = new System.Drawing.Point(117, 19);
            this.btnTicTacToe2.Name = "btnTicTacToe2";
            this.btnTicTacToe2.Size = new System.Drawing.Size(60, 60);
            this.btnTicTacToe2.TabIndex = 1;
            this.btnTicTacToe2.Text = "X";
            this.btnTicTacToe2.UseVisualStyleBackColor = true;
            this.btnTicTacToe2.Click += new System.EventHandler(this.btnTicTacToe2_Click);
            // 
            // btnTicTacToe1
            // 
            this.btnTicTacToe1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicTacToe1.Location = new System.Drawing.Point(39, 19);
            this.btnTicTacToe1.Name = "btnTicTacToe1";
            this.btnTicTacToe1.Size = new System.Drawing.Size(60, 60);
            this.btnTicTacToe1.TabIndex = 0;
            this.btnTicTacToe1.Text = "X";
            this.btnTicTacToe1.UseVisualStyleBackColor = true;
            this.btnTicTacToe1.Click += new System.EventHandler(this.btnTicTacToe1_Click);
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.btnExit);
            this.grbOptions.Controls.Add(this.btnNew);
            this.grbOptions.Location = new System.Drawing.Point(29, 425);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(297, 57);
            this.grbOptions.TabIndex = 3;
            this.grbOptions.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(170, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(39, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(354, 538);
            this.Controls.Add(this.grbOptions);
            this.Controls.Add(this.grbTicTacToe);
            this.Controls.Add(this.grbMessages);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego de Tres en Raya";
            this.Load += new System.EventHandler(this.frmTicTacToe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbMessages.ResumeLayout(false);
            this.grbMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            this.grbTicTacToe.ResumeLayout(false);
            this.grbOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpContent;
        private System.Windows.Forms.ToolStripSeparator mnuHelpSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.GroupBox grbMessages;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.GroupBox grbTicTacToe;
        private System.Windows.Forms.Button btnTicTacToe9;
        private System.Windows.Forms.Button btnTicTacToe8;
        private System.Windows.Forms.Button btnTicTacToe7;
        private System.Windows.Forms.Button btnTicTacToe6;
        private System.Windows.Forms.Button btnTicTacToe5;
        private System.Windows.Forms.Button btnTicTacToe4;
        private System.Windows.Forms.Button btnTicTacToe3;
        private System.Windows.Forms.Button btnTicTacToe2;
        private System.Windows.Forms.Button btnTicTacToe1;
        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
    }
}

