namespace Banco
{
    partial class ConsultaConta
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
            this.contaGroupBox = new System.Windows.Forms.GroupBox();
            this.numerocomboBox = new System.Windows.Forms.ComboBox();
            this.novaContabutton = new System.Windows.Forms.Button();
            this.sacabutton = new System.Windows.Forms.Button();
            this.depositabutton = new System.Windows.Forms.Button();
            this.valorContaLabel = new System.Windows.Forms.Label();
            this.saldoContaLabel = new System.Windows.Forms.Label();
            this.numeroContaLabel = new System.Windows.Forms.Label();
            this.titularContaLabel = new System.Windows.Forms.Label();
            this.valorContatextbox = new System.Windows.Forms.TextBox();
            this.saldoContatextbox = new System.Windows.Forms.TextBox();
            this.titularContatextbox = new System.Windows.Forms.TextBox();
            this.contaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contaGroupBox
            // 
            this.contaGroupBox.Controls.Add(this.numerocomboBox);
            this.contaGroupBox.Controls.Add(this.novaContabutton);
            this.contaGroupBox.Controls.Add(this.sacabutton);
            this.contaGroupBox.Controls.Add(this.depositabutton);
            this.contaGroupBox.Controls.Add(this.valorContaLabel);
            this.contaGroupBox.Controls.Add(this.saldoContaLabel);
            this.contaGroupBox.Controls.Add(this.numeroContaLabel);
            this.contaGroupBox.Controls.Add(this.titularContaLabel);
            this.contaGroupBox.Controls.Add(this.valorContatextbox);
            this.contaGroupBox.Controls.Add(this.saldoContatextbox);
            this.contaGroupBox.Controls.Add(this.titularContatextbox);
            this.contaGroupBox.Location = new System.Drawing.Point(12, 22);
            this.contaGroupBox.Name = "contaGroupBox";
            this.contaGroupBox.Size = new System.Drawing.Size(260, 183);
            this.contaGroupBox.TabIndex = 27;
            this.contaGroupBox.TabStop = false;
            this.contaGroupBox.Text = "Conta";
            // 
            // numerocomboBox
            // 
            this.numerocomboBox.FormattingEnabled = true;
            this.numerocomboBox.Location = new System.Drawing.Point(145, 43);
            this.numerocomboBox.Name = "numerocomboBox";
            this.numerocomboBox.Size = new System.Drawing.Size(100, 21);
            this.numerocomboBox.TabIndex = 25;
            this.numerocomboBox.SelectedIndexChanged += new System.EventHandler(this.numerocomboBox_SelectedIndexChanged);
            // 
            // novaContabutton
            // 
            this.novaContabutton.Location = new System.Drawing.Point(67, 152);
            this.novaContabutton.Name = "novaContabutton";
            this.novaContabutton.Size = new System.Drawing.Size(126, 23);
            this.novaContabutton.TabIndex = 24;
            this.novaContabutton.Text = "Nova Conta";
            this.novaContabutton.UseVisualStyleBackColor = true;
            this.novaContabutton.Click += new System.EventHandler(this.novaContabutton_Click);
            // 
            // sacabutton
            // 
            this.sacabutton.Location = new System.Drawing.Point(159, 123);
            this.sacabutton.Name = "sacabutton";
            this.sacabutton.Size = new System.Drawing.Size(87, 23);
            this.sacabutton.TabIndex = 22;
            this.sacabutton.Text = "Sacar";
            this.sacabutton.UseVisualStyleBackColor = true;
            // 
            // depositabutton
            // 
            this.depositabutton.Location = new System.Drawing.Point(6, 123);
            this.depositabutton.Name = "depositabutton";
            this.depositabutton.Size = new System.Drawing.Size(75, 23);
            this.depositabutton.TabIndex = 21;
            this.depositabutton.Text = "Depositar";
            this.depositabutton.UseVisualStyleBackColor = true;
            // 
            // valorContaLabel
            // 
            this.valorContaLabel.AutoSize = true;
            this.valorContaLabel.Location = new System.Drawing.Point(12, 96);
            this.valorContaLabel.Name = "valorContaLabel";
            this.valorContaLabel.Size = new System.Drawing.Size(31, 13);
            this.valorContaLabel.TabIndex = 20;
            this.valorContaLabel.Text = "Valor";
            // 
            // saldoContaLabel
            // 
            this.saldoContaLabel.AutoSize = true;
            this.saldoContaLabel.Location = new System.Drawing.Point(12, 70);
            this.saldoContaLabel.Name = "saldoContaLabel";
            this.saldoContaLabel.Size = new System.Drawing.Size(34, 13);
            this.saldoContaLabel.TabIndex = 19;
            this.saldoContaLabel.Text = "Saldo";
            // 
            // numeroContaLabel
            // 
            this.numeroContaLabel.AutoSize = true;
            this.numeroContaLabel.Location = new System.Drawing.Point(12, 44);
            this.numeroContaLabel.Name = "numeroContaLabel";
            this.numeroContaLabel.Size = new System.Drawing.Size(44, 13);
            this.numeroContaLabel.TabIndex = 18;
            this.numeroContaLabel.Text = "Numero";
            // 
            // titularContaLabel
            // 
            this.titularContaLabel.AutoSize = true;
            this.titularContaLabel.Location = new System.Drawing.Point(12, 18);
            this.titularContaLabel.Name = "titularContaLabel";
            this.titularContaLabel.Size = new System.Drawing.Size(36, 13);
            this.titularContaLabel.TabIndex = 17;
            this.titularContaLabel.Text = "Titular";
            // 
            // valorContatextbox
            // 
            this.valorContatextbox.Location = new System.Drawing.Point(145, 96);
            this.valorContatextbox.Name = "valorContatextbox";
            this.valorContatextbox.Size = new System.Drawing.Size(100, 20);
            this.valorContatextbox.TabIndex = 14;
            // 
            // saldoContatextbox
            // 
            this.saldoContatextbox.Location = new System.Drawing.Point(145, 70);
            this.saldoContatextbox.Name = "saldoContatextbox";
            this.saldoContatextbox.Size = new System.Drawing.Size(100, 20);
            this.saldoContatextbox.TabIndex = 13;
            // 
            // titularContatextbox
            // 
            this.titularContatextbox.AccessibleName = "";
            this.titularContatextbox.Location = new System.Drawing.Point(145, 18);
            this.titularContatextbox.Name = "titularContatextbox";
            this.titularContatextbox.Size = new System.Drawing.Size(100, 20);
            this.titularContatextbox.TabIndex = 11;
            // 
            // ConsultaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.contaGroupBox);
            this.Name = "ConsultaConta";
            this.Text = "ConsultaConta";
            this.Load += new System.EventHandler(this.ConsultaConta_Load);
            this.contaGroupBox.ResumeLayout(false);
            this.contaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox contaGroupBox;
        private System.Windows.Forms.Button novaContabutton;
        private System.Windows.Forms.Button sacabutton;
        private System.Windows.Forms.Button depositabutton;
        private System.Windows.Forms.Label valorContaLabel;
        private System.Windows.Forms.Label saldoContaLabel;
        private System.Windows.Forms.Label numeroContaLabel;
        private System.Windows.Forms.Label titularContaLabel;
        private System.Windows.Forms.TextBox valorContatextbox;
        private System.Windows.Forms.TextBox saldoContatextbox;
        private System.Windows.Forms.ComboBox numerocomboBox;
        public System.Windows.Forms.TextBox titularContatextbox;
    }
}