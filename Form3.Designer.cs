namespace Loja_do_Andre
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.voutar = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.nm_box1 = new System.Windows.Forms.TextBox();
            this.cd_box1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(632, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(385, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            // 
            // voutar
            // 
            this.voutar.Location = new System.Drawing.Point(1104, 141);
            this.voutar.Name = "voutar";
            this.voutar.Size = new System.Drawing.Size(228, 34);
            this.voutar.TabIndex = 9;
            this.voutar.Text = "voltar para o cadastro";
            this.voutar.UseVisualStyleBackColor = true;
            this.voutar.Click += new System.EventHandler(this.voutar_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(876, 141);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(172, 34);
            this.remove.TabIndex = 8;
            this.remove.Text = "pesquisar";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // nm_box1
            // 
            this.nm_box1.Location = new System.Drawing.Point(632, 142);
            this.nm_box1.Multiline = true;
            this.nm_box1.Name = "nm_box1";
            this.nm_box1.Size = new System.Drawing.Size(181, 33);
            this.nm_box1.TabIndex = 7;
            // 
            // cd_box1
            // 
            this.cd_box1.Location = new System.Drawing.Point(385, 142);
            this.cd_box1.Multiline = true;
            this.cd_box1.Name = "cd_box1";
            this.cd_box1.Size = new System.Drawing.Size(178, 33);
            this.cd_box1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(410, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 698);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1104, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "voltar para a venda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1564, 868);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voutar);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.nm_box1);
            this.Controls.Add(this.cd_box1);
            this.Name = "Form3";
            this.Text = "Pesquisa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button voutar;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.TextBox nm_box1;
        private System.Windows.Forms.TextBox cd_box1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}