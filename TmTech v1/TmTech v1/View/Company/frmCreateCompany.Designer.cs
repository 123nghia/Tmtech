namespace TmTech_v1.View.Customer
{
    partial class frmCreateCompany
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSave = new ModernUI.Controls.BootstrapButton();
            this.btnClearAll = new ModernUI.Controls.BootstrapButton();
            this.btnCancel = new ModernUI.Controls.BootstrapButton();
            this.pnelKhachHang = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSwiftCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cboParentCompany = new ModernUI.Controls.MetroSearchComboBox();
            this.cboTypeCustomer = new ModernUI.Controls.MetroComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTagetValue = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTaxcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDebitValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.comboboxCS1 = new TmTech_v1.ToolBoxCS.ComboboxCS();
            this.pnelKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(13, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(135, 20);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Tạo công ty mới";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Primary;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Depth = 0;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(486, 572);
            this.btnSave.MouseState = ModernUI.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 36);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = true;
            this.btnClearAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearAll.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Warning;
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.Depth = 0;
            this.btnClearAll.Icon = null;
            this.btnClearAll.Location = new System.Drawing.Point(367, 572);
            this.btnClearAll.MouseState = ModernUI.MouseState.HOVER;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(90, 36);
            this.btnClearAll.TabIndex = 31;
            this.btnClearAll.Text = "Clear all";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BootstrapStyle = ModernUI.ModernUIManager.BootstrapStyle.Danger;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(240, 572);
            this.btnCancel.MouseState = ModernUI.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 36);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnelKhachHang
            // 
            this.pnelKhachHang.Controls.Add(this.comboboxCS1);
            this.pnelKhachHang.Controls.Add(this.label19);
            this.pnelKhachHang.Controls.Add(this.txtFax);
            this.pnelKhachHang.Controls.Add(this.label16);
            this.pnelKhachHang.Controls.Add(this.txtSwiftCode);
            this.pnelKhachHang.Controls.Add(this.label6);
            this.pnelKhachHang.Controls.Add(this.txtAddress);
            this.pnelKhachHang.Controls.Add(this.cboParentCompany);
            this.pnelKhachHang.Controls.Add(this.btnSave);
            this.pnelKhachHang.Controls.Add(this.btnCancel);
            this.pnelKhachHang.Controls.Add(this.cboTypeCustomer);
            this.pnelKhachHang.Controls.Add(this.btnClearAll);
            this.pnelKhachHang.Controls.Add(this.label17);
            this.pnelKhachHang.Controls.Add(this.txtTagetValue);
            this.pnelKhachHang.Controls.Add(this.label15);
            this.pnelKhachHang.Controls.Add(this.txtTaxcode);
            this.pnelKhachHang.Controls.Add(this.label14);
            this.pnelKhachHang.Controls.Add(this.txtDebitValue);
            this.pnelKhachHang.Controls.Add(this.label13);
            this.pnelKhachHang.Controls.Add(this.txtWebsite);
            this.pnelKhachHang.Controls.Add(this.label11);
            this.pnelKhachHang.Controls.Add(this.txtEmployee);
            this.pnelKhachHang.Controls.Add(this.label10);
            this.pnelKhachHang.Controls.Add(this.txtPhone2);
            this.pnelKhachHang.Controls.Add(this.label8);
            this.pnelKhachHang.Controls.Add(this.txtPhone1);
            this.pnelKhachHang.Controls.Add(this.label7);
            this.pnelKhachHang.Controls.Add(this.label5);
            this.pnelKhachHang.Controls.Add(this.label4);
            this.pnelKhachHang.Controls.Add(this.label3);
            this.pnelKhachHang.Controls.Add(this.txtEmail);
            this.pnelKhachHang.Controls.Add(this.label18);
            this.pnelKhachHang.Controls.Add(this.lbCode);
            this.pnelKhachHang.Controls.Add(this.txtName);
            this.pnelKhachHang.Controls.Add(this.txtNote);
            this.pnelKhachHang.Controls.Add(this.txtCode);
            this.pnelKhachHang.Location = new System.Drawing.Point(36, 63);
            this.pnelKhachHang.Name = "pnelKhachHang";
            this.pnelKhachHang.Size = new System.Drawing.Size(574, 611);
            this.pnelKhachHang.TabIndex = 33;
            this.pnelKhachHang.Tag = "string";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(364, 271);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 75;
            this.label19.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFax.Location = new System.Drawing.Point(417, 264);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(136, 26);
            this.txtFax.TabIndex = 74;
            this.txtFax.Tag = "string";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(330, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 76;
            this.label16.Text = "Swift Code";
            // 
            // txtSwiftCode
            // 
            this.txtSwiftCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSwiftCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSwiftCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSwiftCode.Location = new System.Drawing.Point(415, 299);
            this.txtSwiftCode.Name = "txtSwiftCode";
            this.txtSwiftCode.Size = new System.Drawing.Size(138, 26);
            this.txtSwiftCode.TabIndex = 73;
            this.txtSwiftCode.Tag = "string";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Địa chỉ công ty";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(171, 232);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(382, 26);
            this.txtAddress.TabIndex = 71;
            this.txtAddress.Tag = "string";
            // 
            // cboParentCompany
            // 
            this.cboParentCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParentCompany.FormattingEnabled = true;
            this.cboParentCompany.Location = new System.Drawing.Point(171, 331);
            this.cboParentCompany.Name = "cboParentCompany";
            this.cboParentCompany.Size = new System.Drawing.Size(382, 28);
            this.cboParentCompany.TabIndex = 70;
            // 
            // cboTypeCustomer
            // 
            this.cboTypeCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTypeCustomer.DisplayMember = "cbo";
            this.cboTypeCustomer.FormattingEnabled = true;
            this.cboTypeCustomer.HighLight = ModernUI.Controls.MetroComboBox.highlight.Alway;
            this.cboTypeCustomer.ItemHeight = 23;
            this.cboTypeCustomer.Location = new System.Drawing.Point(171, 76);
            this.cboTypeCustomer.Name = "cboTypeCustomer";
            this.cboTypeCustomer.Size = new System.Drawing.Size(382, 29);
            this.cboTypeCustomer.TabIndex = 67;
            this.cboTypeCustomer.Tag = "cbo";
            this.cboTypeCustomer.UseSelectable = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 479);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 60;
            this.label17.Text = "Target Value";
            // 
            // txtTagetValue
            // 
            this.txtTagetValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTagetValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTagetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagetValue.Location = new System.Drawing.Point(171, 466);
            this.txtTagetValue.Name = "txtTagetValue";
            this.txtTagetValue.Size = new System.Drawing.Size(382, 26);
            this.txtTagetValue.TabIndex = 55;
            this.txtTagetValue.Tag = "int";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 440);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "Tax Code";
            // 
            // txtTaxcode
            // 
            this.txtTaxcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTaxcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxcode.Location = new System.Drawing.Point(171, 433);
            this.txtTaxcode.Name = "txtTaxcode";
            this.txtTaxcode.Size = new System.Drawing.Size(382, 26);
            this.txtTaxcode.TabIndex = 56;
            this.txtTaxcode.Tag = "string";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "Tiền khách hàng nợ";
            // 
            // txtDebitValue
            // 
            this.txtDebitValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDebitValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDebitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebitValue.Location = new System.Drawing.Point(171, 168);
            this.txtDebitValue.Name = "txtDebitValue";
            this.txtDebitValue.Size = new System.Drawing.Size(382, 26);
            this.txtDebitValue.TabIndex = 54;
            this.txtDebitValue.Tag = "float";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Website";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebsite.Location = new System.Drawing.Point(171, 398);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(382, 26);
            this.txtWebsite.TabIndex = 53;
            this.txtWebsite.Tag = "string";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Số nhân viên công ty";
            // 
            // txtEmployee
            // 
            this.txtEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.Location = new System.Drawing.Point(171, 365);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(382, 26);
            this.txtEmployee.TabIndex = 52;
            this.txtEmployee.Tag = "int";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Số  điện thoại liên  hệ 2";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone2.Location = new System.Drawing.Point(171, 136);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(382, 26);
            this.txtPhone2.TabIndex = 51;
            this.txtPhone2.Tag = "phone";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Số điện thoại liên hệ 1";
            // 
            // txtPhone1
            // 
            this.txtPhone1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone1.Location = new System.Drawing.Point(171, 102);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(382, 26);
            this.txtPhone1.TabIndex = 49;
            this.txtPhone1.Tag = "phone";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Thuộc công ty";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Loại khách hàng";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tên công ty";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Địa chỉ email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(171, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(382, 26);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.Tag = "string";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 509);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Ghi chú";
            // 
            // lbCode
            // 
            this.lbCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(52, 23);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(60, 13);
            this.lbCode.TabIndex = 39;
            this.lbCode.Text = "Mã công ty";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(171, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(382, 26);
            this.txtName.TabIndex = 38;
            this.txtName.Tag = "string";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(171, 502);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(382, 53);
            this.txtNote.TabIndex = 36;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(171, 13);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(113, 26);
            this.txtCode.TabIndex = 36;
            // 
            // comboboxCS1
            // 
            this.comboboxCS1.FormattingEnabled = true;
            this.comboboxCS1.ItemHeight = 23;
            this.comboboxCS1.Location = new System.Drawing.Point(52, 268);
            this.comboboxCS1.Name = "comboboxCS1";
            this.comboboxCS1.NameModel = "Company";
            this.comboboxCS1.Size = new System.Drawing.Size(121, 29);
            this.comboboxCS1.TabIndex = 77;
            this.comboboxCS1.UseSelectable = true;
            // 
            // frmCreateCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 687);
            this.Controls.Add(this.pnelKhachHang);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmCreateCompany";
            this.Load += new System.EventHandler(this.frmCreate_Load);
            this.pnelKhachHang.ResumeLayout(false);
            this.pnelKhachHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private ModernUI.Controls.BootstrapButton btnSave;
        private ModernUI.Controls.BootstrapButton btnClearAll;
        private ModernUI.Controls.BootstrapButton btnCancel;
        private System.Windows.Forms.Panel pnelKhachHang;
        private ModernUI.Controls.MetroComboBox cboTypeCustomer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTagetValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTaxcode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDebitValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private ModernUI.Controls.MetroSearchComboBox cboParentCompany;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSwiftCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNote;
        private ToolBoxCS.ComboboxCS comboboxCS1;
    }
}
