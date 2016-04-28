namespace DesktopClean.App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotificacoes = new System.Windows.Forms.TextBox();
            this.fsw = new System.IO.FileSystemWatcher();
            this.notificacao = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnProcurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notificações";
            // 
            // txtNotificacoes
            // 
            this.txtNotificacoes.Location = new System.Drawing.Point(12, 100);
            this.txtNotificacoes.Multiline = true;
            this.txtNotificacoes.Name = "txtNotificacoes";
            this.txtNotificacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotificacoes.Size = new System.Drawing.Size(398, 160);
            this.txtNotificacoes.TabIndex = 3;
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.SynchronizingObject = this;
            this.fsw.Changed += new System.IO.FileSystemEventHandler(this.fsw_Changed);
            this.fsw.Created += new System.IO.FileSystemEventHandler(this.fsw_Created);
            this.fsw.Renamed += new System.IO.RenamedEventHandler(this.fsw_Renamed);
            // 
            // notificacao
            // 
            this.notificacao.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificacao.BalloonTipText = "teste";
            this.notificacao.Icon = ((System.Drawing.Icon)(resources.GetObject("notificacao.Icon")));
            this.notificacao.Text = "DesktopClean";
            this.notificacao.Visible = true;
            this.notificacao.DoubleClick += new System.EventHandler(this.notificacao_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pasta destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(89, 17);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(225, 20);
            this.txtDestino.TabIndex = 5;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(320, 15);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 6;
            this.btnProcurar.Text = "Procurar...";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 272);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotificacoes);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DesktopClean";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotificacoes;
        private System.IO.FileSystemWatcher fsw;
        private System.Windows.Forms.NotifyIcon notificacao;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

