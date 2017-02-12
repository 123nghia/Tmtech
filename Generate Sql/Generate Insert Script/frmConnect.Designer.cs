namespace Generate_Insert_Script
{
    partial class frmConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnect));
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDatabase = new ModernUI.Controls.MetroComboBox();
            this.btnConnect = new ModernUI.Controls.BootstrapButton();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.SuspendLayout();
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblServer.Location = new System.Drawing.Point(40, 79);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(55, 20);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtServer.Location = new System.Drawing.Point(44, 102);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(252, 26);
            this.txtServer.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.Location = new System.Drawing.Point(44, 175);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(40, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(44, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 26);
            this.txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(40, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(40, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Database";
            // 
            // cbbDatabase
            // 
            this.cbbDatabase.FormattingEnabled = true;
            this.cbbDatabase.HighLight = ModernUI.Controls.MetroComboBox.highlight.Alway;
            this.cbbDatabase.ItemHeight = 23;
            this.cbbDatabase.Location = new System.Drawing.Point(44, 322);
            this.cbbDatabase.Name = "cbbDatabase";
            this.cbbDatabase.Size = new System.Drawing.Size(252, 29);
            this.cbbDatabase.TabIndex = 7;
            this.cbbDatabase.UseSelectable = true;
            this.cbbDatabase.DropDown += new System.EventHandler(this.cbbDatabase_DropDown);
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Depth = 0;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(84, 371);
            this.btnConnect.MouseState = ModernUI.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 36);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(191, 371);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbbDatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConnect";
            this.Text = "Kết nối";
            this.Load += new System.EventHandler(this.frmConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ModernUI.Controls.MetroComboBox cbbDatabase;
        private ModernUI.Controls.BootstrapButton btnConnect;
        private ModernUI.Controls.BootstrapButton btnCancel;
    }
}

