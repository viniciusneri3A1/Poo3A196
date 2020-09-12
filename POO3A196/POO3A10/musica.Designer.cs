namespace POO3A196
{
    partial class musica
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboMusica = new System.Windows.Forms.ComboBox();
            this.btnPesquisarMusicas = new System.Windows.Forms.Button();
            this.txtPesquisarMusicas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GridMusica = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridMusica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nome do Autor";
            // 
            // comboMusica
            // 
            this.comboMusica.FormattingEnabled = true;
            this.comboMusica.Location = new System.Drawing.Point(102, 32);
            this.comboMusica.Name = "comboMusica";
            this.comboMusica.Size = new System.Drawing.Size(268, 21);
            this.comboMusica.TabIndex = 60;
            // 
            // btnPesquisarMusicas
            // 
            this.btnPesquisarMusicas.Location = new System.Drawing.Point(445, 85);
            this.btnPesquisarMusicas.Name = "btnPesquisarMusicas";
            this.btnPesquisarMusicas.Size = new System.Drawing.Size(114, 23);
            this.btnPesquisarMusicas.TabIndex = 59;
            this.btnPesquisarMusicas.Text = "Pesquisar";
            this.btnPesquisarMusicas.UseVisualStyleBackColor = true;
            this.btnPesquisarMusicas.Click += new System.EventHandler(this.btnPesquisarMusicas_Click);
            // 
            // txtPesquisarMusicas
            // 
            this.txtPesquisarMusicas.Location = new System.Drawing.Point(127, 87);
            this.txtPesquisarMusicas.Name = "txtPesquisarMusicas";
            this.txtPesquisarMusicas.Size = new System.Drawing.Size(312, 20);
            this.txtPesquisarMusicas.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Pesquisar Músicas";
            // 
            // GridMusica
            // 
            this.GridMusica.AllowUserToAddRows = false;
            this.GridMusica.AllowUserToDeleteRows = false;
            this.GridMusica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMusica.Location = new System.Drawing.Point(21, 131);
            this.GridMusica.Name = "GridMusica";
            this.GridMusica.ReadOnly = true;
            this.GridMusica.Size = new System.Drawing.Size(538, 198);
            this.GridMusica.TabIndex = 55;
            // 
            // musica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMusica);
            this.Controls.Add(this.btnPesquisarMusicas);
            this.Controls.Add(this.txtPesquisarMusicas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridMusica);
            this.Name = "musica";
            this.Text = "Música";
            this.Load += new System.EventHandler(this.musica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMusica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMusica;
        private System.Windows.Forms.Button btnPesquisarMusicas;
        private System.Windows.Forms.TextBox txtPesquisarMusicas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView GridMusica;
    }
}

