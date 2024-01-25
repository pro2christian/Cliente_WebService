namespace Cliente_WebService
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
            this.EnviaStr_Text = new System.Windows.Forms.TextBox();
            this.RecebeStr_Text = new System.Windows.Forms.TextBox();
            this.enviaStr_button = new System.Windows.Forms.Button();
            this.recebeStr_button = new System.Windows.Forms.Button();
            this.limpar_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnviaStr_Text
            // 
            this.EnviaStr_Text.Location = new System.Drawing.Point(31, 127);
            this.EnviaStr_Text.Name = "EnviaStr_Text";
            this.EnviaStr_Text.Size = new System.Drawing.Size(201, 20);
            this.EnviaStr_Text.TabIndex = 1;
            // 
            // RecebeStr_Text
            // 
            this.RecebeStr_Text.Location = new System.Drawing.Point(251, 126);
            this.RecebeStr_Text.Name = "RecebeStr_Text";
            this.RecebeStr_Text.Size = new System.Drawing.Size(192, 20);
            this.RecebeStr_Text.TabIndex = 2;
            // 
            // enviaStr_button
            // 
            this.enviaStr_button.Location = new System.Drawing.Point(31, 169);
            this.enviaStr_button.Name = "enviaStr_button";
            this.enviaStr_button.Size = new System.Drawing.Size(201, 23);
            this.enviaStr_button.TabIndex = 3;
            this.enviaStr_button.Text = "Envia String";
            this.enviaStr_button.UseVisualStyleBackColor = true;
            this.enviaStr_button.Click += new System.EventHandler(this.enviaStr_Click);
            // 
            // recebeStr_button
            // 
            this.recebeStr_button.Location = new System.Drawing.Point(251, 169);
            this.recebeStr_button.Name = "recebeStr_button";
            this.recebeStr_button.Size = new System.Drawing.Size(192, 23);
            this.recebeStr_button.TabIndex = 4;
            this.recebeStr_button.Text = "Recebe String";
            this.recebeStr_button.UseVisualStyleBackColor = true;
            this.recebeStr_button.Click += new System.EventHandler(this.recebeStr_Click);
            // 
            // limpar_Button
            // 
            this.limpar_Button.Location = new System.Drawing.Point(251, 198);
            this.limpar_Button.Name = "limpar_Button";
            this.limpar_Button.Size = new System.Drawing.Size(192, 23);
            this.limpar_Button.TabIndex = 5;
            this.limpar_Button.Text = "Limpar";
            this.limpar_Button.UseVisualStyleBackColor = true;
            this.limpar_Button.Visible = false;
            this.limpar_Button.Click += new System.EventHandler(this.limpar_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 274);
            this.Controls.Add(this.limpar_Button);
            this.Controls.Add(this.recebeStr_button);
            this.Controls.Add(this.enviaStr_button);
            this.Controls.Add(this.RecebeStr_Text);
            this.Controls.Add(this.EnviaStr_Text);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EnviaStr_Text;
        private System.Windows.Forms.TextBox RecebeStr_Text;
        private System.Windows.Forms.Button enviaStr_button;
        private System.Windows.Forms.Button recebeStr_button;
        private System.Windows.Forms.Button limpar_Button;
    }
}

