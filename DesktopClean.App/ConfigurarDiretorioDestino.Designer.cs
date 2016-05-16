namespace DesktopClean.App
{
    partial class ConfigurarDiretorioDestino
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
            this.txtDiretorioDestino = new System.Windows.Forms.TextBox();
            this.btnConsultarDiretorio = new System.Windows.Forms.Button();
            this.btnSalvarConfiguracao = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório";
            // 
            // txtDiretorioDestino
            // 
            this.txtDiretorioDestino.Location = new System.Drawing.Point(64, 32);
            this.txtDiretorioDestino.Name = "txtDiretorioDestino";
            this.txtDiretorioDestino.Size = new System.Drawing.Size(258, 20);
            this.txtDiretorioDestino.TabIndex = 1;
            // 
            // btnConsultarDiretorio
            // 
            this.btnConsultarDiretorio.Location = new System.Drawing.Point(328, 30);
            this.btnConsultarDiretorio.Name = "btnConsultarDiretorio";
            this.btnConsultarDiretorio.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarDiretorio.TabIndex = 2;
            this.btnConsultarDiretorio.Text = "Procurar";
            this.btnConsultarDiretorio.UseVisualStyleBackColor = true;
            this.btnConsultarDiretorio.Click += new System.EventHandler(this.btnConsultarDiretorio_Click);
            // 
            // btnSalvarConfiguracao
            // 
            this.btnSalvarConfiguracao.Location = new System.Drawing.Point(328, 92);
            this.btnSalvarConfiguracao.Name = "btnSalvarConfiguracao";
            this.btnSalvarConfiguracao.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarConfiguracao.TabIndex = 3;
            this.btnSalvarConfiguracao.Text = "Salvar";
            this.btnSalvarConfiguracao.UseVisualStyleBackColor = true;
            this.btnSalvarConfiguracao.Click += new System.EventHandler(this.btnSalvarConfiguracao_Click);
            // 
            // ConfigurarDiretorioDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 138);
            this.Controls.Add(this.btnSalvarConfiguracao);
            this.Controls.Add(this.btnConsultarDiretorio);
            this.Controls.Add(this.txtDiretorioDestino);
            this.Controls.Add(this.label1);
            this.Name = "ConfigurarDiretorioDestino";
            this.Text = "Configurar diretorio destino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiretorioDestino;
        private System.Windows.Forms.Button btnConsultarDiretorio;
        private System.Windows.Forms.Button btnSalvarConfiguracao;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}