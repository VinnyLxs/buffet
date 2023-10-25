namespace appalgumacoisabuffet.View
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Acessar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sair = new System.Windows.Forms.Button();
            this.txBox_Usuario = new System.Windows.Forms.TextBox();
            this.txBox_senha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(20, 38);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(77, 22);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.Location = new System.Drawing.Point(20, 91);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(63, 22);
            this.lbl_Senha.TabIndex = 1;
            this.lbl_Senha.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buffet Francisco";
            // 
            // Acessar
            // 
            this.Acessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acessar.Location = new System.Drawing.Point(101, 130);
            this.Acessar.Name = "Acessar";
            this.Acessar.Size = new System.Drawing.Size(118, 34);
            this.Acessar.TabIndex = 5;
            this.Acessar.Text = "Acessar";
            this.Acessar.UseVisualStyleBackColor = true;
            this.Acessar.Click += new System.EventHandler(this.Acessar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txBox_senha);
            this.groupBox1.Controls.Add(this.txBox_Usuario);
            this.groupBox1.Controls.Add(this.Sair);
            this.groupBox1.Controls.Add(this.Acessar);
            this.groupBox1.Controls.Add(this.lbl_Senha);
            this.groupBox1.Controls.Add(this.lbl_Usuario);
            this.groupBox1.Location = new System.Drawing.Point(207, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 238);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciais";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appalgumacoisabuffet.Properties.Resources.MicrosoftTeams_image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Sair
            // 
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(309, 201);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(44, 31);
            this.Sair.TabIndex = 6;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // txBox_Usuario
            // 
            this.txBox_Usuario.Location = new System.Drawing.Point(103, 40);
            this.txBox_Usuario.Name = "txBox_Usuario";
            this.txBox_Usuario.Size = new System.Drawing.Size(101, 20);
            this.txBox_Usuario.TabIndex = 7;
            // 
            // txBox_senha
            // 
            this.txBox_senha.Location = new System.Drawing.Point(101, 93);
            this.txBox_senha.Name = "txBox_senha";
            this.txBox_senha.PasswordChar = '*';
            this.txBox_senha.Size = new System.Drawing.Size(101, 20);
            this.txBox_senha.TabIndex = 8;
            // 
            // LoginTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 287);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginTela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de PDV Buffet Francisco";
            this.Load += new System.EventHandler(this.LoginTela_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Acessar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.TextBox txBox_senha;
        private System.Windows.Forms.TextBox txBox_Usuario;
    }
}