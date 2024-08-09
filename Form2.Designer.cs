namespace Loja_do_Andre
{
    partial class Form2
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
            this.cd_box1 = new System.Windows.Forms.TextBox();
            this.nm_box1 = new System.Windows.Forms.TextBox();
            this.remove = new System.Windows.Forms.Button();
            this.voutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cd_box1
            // 
            this.cd_box1.Location = new System.Drawing.Point(421, 149);
            this.cd_box1.Multiline = true;
            this.cd_box1.Name = "cd_box1";
            this.cd_box1.Size = new System.Drawing.Size(175, 30);
            this.cd_box1.TabIndex = 0;
            // 
            // nm_box1
            // 
            this.nm_box1.Location = new System.Drawing.Point(668, 148);
            this.nm_box1.Multiline = true;
            this.nm_box1.Name = "nm_box1";
            this.nm_box1.Size = new System.Drawing.Size(189, 31);
            this.nm_box1.TabIndex = 1;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(912, 147);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(150, 32);
            this.remove.TabIndex = 2;
            this.remove.Text = "dar baixa";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // voutar
            // 
            this.voutar.Location = new System.Drawing.Point(1140, 147);
            this.voutar.Name = "voutar";
            this.voutar.Size = new System.Drawing.Size(220, 32);
            this.voutar.TabIndex = 3;
            this.voutar.Text = "voltar para o cadastro";
            this.voutar.UseVisualStyleBackColor = true;
            this.voutar.Click += new System.EventHandler(this.voutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(421, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(668, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(596, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1140, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "voltar para a pesquisa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1564, 868);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voutar);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.nm_box1);
            this.Controls.Add(this.cd_box1);
            this.Name = "Form2";
            this.Text = "Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cd_box1;
        private System.Windows.Forms.TextBox nm_box1;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button voutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}