namespace Pedra__papel_e_tesoura
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pedra = new System.Windows.Forms.Button();
            this.Papel = new System.Windows.Forms.Button();
            this.Tesoura = new System.Windows.Forms.Button();
            this.PicJogador = new System.Windows.Forms.PictureBox();
            this.PicCPU = new System.Windows.Forms.PictureBox();
            this.lbjogador = new System.Windows.Forms.Label();
            this.lbcpu = new System.Windows.Forms.Label();
            this.PlacarJogador = new System.Windows.Forms.Label();
            this.PlacarCPU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // Pedra
            // 
            this.Pedra.BackColor = System.Drawing.Color.White;
            this.Pedra.BackgroundImage = global::Pedra__papel_e_tesoura.Properties.Resources.Pedra2;
            this.Pedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pedra.Location = new System.Drawing.Point(12, 225);
            this.Pedra.Name = "Pedra";
            this.Pedra.Size = new System.Drawing.Size(120, 120);
            this.Pedra.TabIndex = 0;
            this.Pedra.Tag = "0";
            this.Pedra.UseVisualStyleBackColor = false;
            this.Pedra.Click += new System.EventHandler(this.ClickJogada);
            // 
            // Papel
            // 
            this.Papel.BackColor = System.Drawing.Color.White;
            this.Papel.BackgroundImage = global::Pedra__papel_e_tesoura.Properties.Resources.Papel2;
            this.Papel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Papel.Location = new System.Drawing.Point(172, 225);
            this.Papel.Name = "Papel";
            this.Papel.Size = new System.Drawing.Size(120, 120);
            this.Papel.TabIndex = 1;
            this.Papel.Tag = "1";
            this.Papel.UseVisualStyleBackColor = false;
            this.Papel.Click += new System.EventHandler(this.ClickJogada);
            // 
            // Tesoura
            // 
            this.Tesoura.BackColor = System.Drawing.Color.White;
            this.Tesoura.BackgroundImage = global::Pedra__papel_e_tesoura.Properties.Resources.Tesoura2;
            this.Tesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tesoura.Location = new System.Drawing.Point(329, 225);
            this.Tesoura.Name = "Tesoura";
            this.Tesoura.Size = new System.Drawing.Size(120, 120);
            this.Tesoura.TabIndex = 2;
            this.Tesoura.Tag = "2";
            this.Tesoura.UseVisualStyleBackColor = false;
            this.Tesoura.Click += new System.EventHandler(this.ClickJogada);
            // 
            // PicJogador
            // 
            this.PicJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicJogador.Location = new System.Drawing.Point(12, 38);
            this.PicJogador.Name = "PicJogador";
            this.PicJogador.Size = new System.Drawing.Size(150, 150);
            this.PicJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicJogador.TabIndex = 3;
            this.PicJogador.TabStop = false;
            // 
            // PicCPU
            // 
            this.PicCPU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicCPU.Location = new System.Drawing.Point(297, 38);
            this.PicCPU.Name = "PicCPU";
            this.PicCPU.Size = new System.Drawing.Size(150, 150);
            this.PicCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCPU.TabIndex = 4;
            this.PicCPU.TabStop = false;
            // 
            // lbjogador
            // 
            this.lbjogador.AutoSize = true;
            this.lbjogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbjogador.Location = new System.Drawing.Point(168, 69);
            this.lbjogador.Name = "lbjogador";
            this.lbjogador.Size = new System.Drawing.Size(67, 20);
            this.lbjogador.TabIndex = 5;
            this.lbjogador.Text = "Jogador";
            // 
            // lbcpu
            // 
            this.lbcpu.AutoSize = true;
            this.lbcpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcpu.Location = new System.Drawing.Point(239, 70);
            this.lbcpu.Name = "lbcpu";
            this.lbcpu.Size = new System.Drawing.Size(42, 20);
            this.lbcpu.TabIndex = 6;
            this.lbcpu.Text = "CPU";
            // 
            // PlacarJogador
            // 
            this.PlacarJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacarJogador.Location = new System.Drawing.Point(182, 90);
            this.PlacarJogador.Name = "PlacarJogador";
            this.PlacarJogador.Size = new System.Drawing.Size(40, 20);
            this.PlacarJogador.TabIndex = 7;
            this.PlacarJogador.Text = "0";
            this.PlacarJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlacarCPU
            // 
            this.PlacarCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacarCPU.Location = new System.Drawing.Point(240, 90);
            this.PlacarCPU.Name = "PlacarCPU";
            this.PlacarCPU.Size = new System.Drawing.Size(40, 20);
            this.PlacarCPU.TabIndex = 8;
            this.PlacarCPU.Text = "0";
            this.PlacarCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 364);
            this.Controls.Add(this.PlacarCPU);
            this.Controls.Add(this.PlacarJogador);
            this.Controls.Add(this.lbcpu);
            this.Controls.Add(this.lbjogador);
            this.Controls.Add(this.PicCPU);
            this.Controls.Add(this.PicJogador);
            this.Controls.Add(this.Tesoura);
            this.Controls.Add(this.Papel);
            this.Controls.Add(this.Pedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra, papel e tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pedra;
        private System.Windows.Forms.Button Papel;
        private System.Windows.Forms.Button Tesoura;
        private System.Windows.Forms.PictureBox PicJogador;
        private System.Windows.Forms.PictureBox PicCPU;
        private System.Windows.Forms.Label lbjogador;
        private System.Windows.Forms.Label lbcpu;
        private System.Windows.Forms.Label PlacarJogador;
        private System.Windows.Forms.Label PlacarCPU;
    }
}

