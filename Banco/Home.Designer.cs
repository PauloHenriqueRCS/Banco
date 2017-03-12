namespace Banco
{
    partial class Home
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cadastrocHomebutton = new System.Windows.Forms.Button();
            this.loginHomebutton = new System.Windows.Forms.Button();
            this.cpfHometextBox = new System.Windows.Forms.TextBox();
            this.nomeHometextBox = new System.Windows.Forms.TextBox();
            this.cpfHomelabel = new System.Windows.Forms.Label();
            this.nomeHomelabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cadastrocHomebutton);
            this.groupBox1.Controls.Add(this.loginHomebutton);
            this.groupBox1.Controls.Add(this.cpfHometextBox);
            this.groupBox1.Controls.Add(this.nomeHometextBox);
            this.groupBox1.Controls.Add(this.cpfHomelabel);
            this.groupBox1.Controls.Add(this.nomeHomelabel);
            this.groupBox1.Location = new System.Drawing.Point(32, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cadastrocHomebutton
            // 
            this.cadastrocHomebutton.Location = new System.Drawing.Point(33, 168);
            this.cadastrocHomebutton.Name = "cadastrocHomebutton";
            this.cadastrocHomebutton.Size = new System.Drawing.Size(144, 23);
            this.cadastrocHomebutton.TabIndex = 9;
            this.cadastrocHomebutton.Text = "Cadrastar-se";
            this.cadastrocHomebutton.UseVisualStyleBackColor = true;
            this.cadastrocHomebutton.Click += new System.EventHandler(this.cadastrocHomebutton_Click);
            // 
            // loginHomebutton
            // 
            this.loginHomebutton.Location = new System.Drawing.Point(75, 107);
            this.loginHomebutton.Name = "loginHomebutton";
            this.loginHomebutton.Size = new System.Drawing.Size(63, 41);
            this.loginHomebutton.TabIndex = 8;
            this.loginHomebutton.Text = "Login";
            this.loginHomebutton.UseVisualStyleBackColor = true;
            this.loginHomebutton.Click += new System.EventHandler(this.loginHomebutton_Click);
            // 
            // cpfHometextBox
            // 
            this.cpfHometextBox.Location = new System.Drawing.Point(94, 66);
            this.cpfHometextBox.Name = "cpfHometextBox";
            this.cpfHometextBox.Size = new System.Drawing.Size(100, 20);
            this.cpfHometextBox.TabIndex = 7;
            // 
            // nomeHometextBox
            // 
            this.nomeHometextBox.Location = new System.Drawing.Point(94, 16);
            this.nomeHometextBox.Name = "nomeHometextBox";
            this.nomeHometextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeHometextBox.TabIndex = 6;
            // 
            // cpfHomelabel
            // 
            this.cpfHomelabel.AutoSize = true;
            this.cpfHomelabel.Location = new System.Drawing.Point(16, 69);
            this.cpfHomelabel.Name = "cpfHomelabel";
            this.cpfHomelabel.Size = new System.Drawing.Size(27, 13);
            this.cpfHomelabel.TabIndex = 5;
            this.cpfHomelabel.Text = "CPF";
            // 
            // nomeHomelabel
            // 
            this.nomeHomelabel.AutoSize = true;
            this.nomeHomelabel.Location = new System.Drawing.Point(16, 16);
            this.nomeHomelabel.Name = "nomeHomelabel";
            this.nomeHomelabel.Size = new System.Drawing.Size(35, 13);
            this.nomeHomelabel.TabIndex = 4;
            this.nomeHomelabel.Text = "Nome";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cadastrocHomebutton;
        private System.Windows.Forms.Button loginHomebutton;
        private System.Windows.Forms.Label cpfHomelabel;
        private System.Windows.Forms.Label nomeHomelabel;
        public System.Windows.Forms.TextBox cpfHometextBox;
        public System.Windows.Forms.TextBox nomeHometextBox;
    }
}