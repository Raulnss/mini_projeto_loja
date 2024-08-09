namespace Loja_do_Andre
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
            this.codigo = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.L_qt_pd_cadastrado = new System.Windows.Forms.Label();
            this.ver_qt = new System.Windows.Forms.Button();
            this.vender = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(316, 123);
            this.codigo.Multiline = true;
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(234, 38);
            this.codigo.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(626, 123);
            this.nome.Multiline = true;
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(208, 38);
            this.nome.TabIndex = 1;
            // 
            // Cadastrar
            // 
            this.Cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cadastrar.Location = new System.Drawing.Point(895, 123);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(109, 38);
            this.Cadastrar.TabIndex = 2;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // L_qt_pd_cadastrado
            // 
            this.L_qt_pd_cadastrado.AutoSize = true;
            this.L_qt_pd_cadastrado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.L_qt_pd_cadastrado.Location = new System.Drawing.Point(383, 177);
            this.L_qt_pd_cadastrado.Name = "L_qt_pd_cadastrado";
            this.L_qt_pd_cadastrado.Size = new System.Drawing.Size(0, 16);
            this.L_qt_pd_cadastrado.TabIndex = 3;
            // 
            // ver_qt
            // 
            this.ver_qt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ver_qt.Location = new System.Drawing.Point(1231, 121);
            this.ver_qt.Name = "ver_qt";
            this.ver_qt.Size = new System.Drawing.Size(125, 40);
            this.ver_qt.TabIndex = 4;
            this.ver_qt.Text = "ver produtos";
            this.ver_qt.UseVisualStyleBackColor = true;
            this.ver_qt.Click += new System.EventHandler(this.ver_qt_Click);
            // 
            // vender
            // 
            this.vender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vender.Location = new System.Drawing.Point(75, 121);
            this.vender.Name = "vender";
            this.vender.Size = new System.Drawing.Size(103, 40);
            this.vender.TabIndex = 6;
            this.vender.Text = "vender";
            this.vender.UseVisualStyleBackColor = true;
            this.vender.Click += new System.EventHandler(this.vender_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(325, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(642, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(1174, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 682);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(75, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1564, 868);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vender);
            this.Controls.Add(this.ver_qt);
            this.Controls.Add(this.L_qt_pd_cadastrado);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.codigo);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Label L_qt_pd_cadastrado;
        private System.Windows.Forms.Button ver_qt;
        private System.Windows.Forms.Button vender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

