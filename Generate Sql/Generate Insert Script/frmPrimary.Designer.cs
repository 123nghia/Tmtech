namespace Generate_Insert_Script
{
    partial class frmPrimary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimary));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTable = new ModernUI.Controls.MetroSearchComboBox();
            this.btnGenerate = new ModernUI.Controls.BootstrapButton();
            this.txtScript = new ModernUI.Controls.MetroTextBox();
            this.btnSetupDb = new ModernUI.Controls.MetroLink();
            this.bootstrapButton1 = new ModernUI.Controls.BootstrapButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(39, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng";
            // 
            // cbbTable
            // 
            this.cbbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Location = new System.Drawing.Point(99, 79);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(314, 28);
            this.cbbTable.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Depth = 0;
            this.btnGenerate.Icon = null;
            this.btnGenerate.Location = new System.Drawing.Point(441, 75);
            this.btnGenerate.MouseState = ModernUI.MouseState.HOVER;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(68, 36);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Insert";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtScript
            // 
            // 
            // 
            // 
            this.txtScript.CustomButton.Image = null;
            this.txtScript.CustomButton.Location = new System.Drawing.Point(476, 2);
            this.txtScript.CustomButton.Name = "";
            this.txtScript.CustomButton.Size = new System.Drawing.Size(208, 193);
            this.txtScript.CustomButton.Style = ModernUI.MetroColorStyle.Blue;
            this.txtScript.CustomButton.TabIndex = 1;
            this.txtScript.CustomButton.Theme = ModernUI.MetroThemeStyle.Light;
            this.txtScript.CustomButton.UseSelectable = true;
            this.txtScript.CustomButton.Visible = false;
            this.txtScript.Lines = new string[] {
        "script"};
            this.txtScript.Location = new System.Drawing.Point(0, 135);
            this.txtScript.MaxLength = 32767;
            this.txtScript.Multiline = true;
            this.txtScript.Name = "txtScript";
            this.txtScript.PasswordChar = '\0';
            this.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtScript.SelectedText = "";
            this.txtScript.SelectionLength = 0;
            this.txtScript.SelectionStart = 0;
            this.txtScript.ShortcutsEnabled = true;
            this.txtScript.Size = new System.Drawing.Size(687, 198);
            this.txtScript.TabIndex = 3;
            this.txtScript.Text = "script";
            this.txtScript.UseSelectable = true;
            this.txtScript.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtScript.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSetupDb
            // 
            this.btnSetupDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetupDb.HighLight = ModernUI.Controls.MetroLink.highlight.Hover;
            this.btnSetupDb.Image = ((System.Drawing.Image)(resources.GetObject("btnSetupDb.Image")));
            this.btnSetupDb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetupDb.Location = new System.Drawing.Point(7, 339);
            this.btnSetupDb.Name = "btnSetupDb";
            this.btnSetupDb.Size = new System.Drawing.Size(142, 23);
            this.btnSetupDb.TabIndex = 4;
            this.btnSetupDb.Text = "Setup connection";
            this.btnSetupDb.UseSelectable = true;
            this.btnSetupDb.Click += new System.EventHandler(this.btnSetupDb_Click);
            // 
            // bootstrapButton1
            // 
            this.bootstrapButton1.AutoSize = true;
            this.bootstrapButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bootstrapButton1.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.bootstrapButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bootstrapButton1.Depth = 0;
            this.bootstrapButton1.Icon = null;
            this.bootstrapButton1.Location = new System.Drawing.Point(536, 76);
            this.bootstrapButton1.MouseState = ModernUI.MouseState.HOVER;
            this.bootstrapButton1.Name = "bootstrapButton1";
            this.bootstrapButton1.Size = new System.Drawing.Size(73, 36);
            this.bootstrapButton1.TabIndex = 5;
            this.bootstrapButton1.Text = "Update";
            this.bootstrapButton1.UseVisualStyleBackColor = true;
            this.bootstrapButton1.Click += new System.EventHandler(this.bootstrapButton1_Click);
            // 
            // frmPrimary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 363);
            this.Controls.Add(this.bootstrapButton1);
            this.Controls.Add(this.btnSetupDb);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cbbTable);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrimary";
            this.Resizable = false;
            this.Text = "Generate Insert Script";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrimary_FormClosing);
            this.Load += new System.EventHandler(this.frmPrimary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ModernUI.Controls.MetroSearchComboBox cbbTable;
        private ModernUI.Controls.BootstrapButton btnGenerate;
        private ModernUI.Controls.MetroTextBox txtScript;
        private ModernUI.Controls.MetroLink btnSetupDb;
        private ModernUI.Controls.BootstrapButton bootstrapButton1;
    }
}