namespace AssetTracker
{
    partial class AddAssetForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInstructions = new Label();
            txtSystemName = new TextBox();
            txtModel = new TextBox();
            txtManufacturer = new TextBox();
            txtType = new TextBox();
            txtIpAddress = new TextBox();
            dtpPurchaseDate = new DateTimePicker();
            txtNotes = new TextBox();
            cboEmployee = new ComboBox();
            btnSave = new Button();
            btnClear = new Button();
            lblSystemName = new Label();
            lblModel = new Label();
            lblManufacturer = new Label();
            lblType = new Label();
            lblIpAddress = new Label();
            lblPurchaseDate = new Label();
            lblNotes = new Label();
            lblEmployee = new Label();
            SuspendLayout();
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(479, 9);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(309, 75);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "Hardware details are collected automatically. \r\nSelect the responsible employee,\r\n add the purchase date from the asset sticker if it has one,\r\n and add any notes.\r\n Then click Save.";
            // 
            // txtSystemName
            // 
            txtSystemName.Location = new Point(105, 102);
            txtSystemName.Name = "txtSystemName";
            txtSystemName.Size = new Size(415, 23);
            txtSystemName.TabIndex = 1;
            txtSystemName.TextChanged += txtSystemName_TextChanged;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(105, 131);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(415, 23);
            txtModel.TabIndex = 2;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(105, 160);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(415, 23);
            txtManufacturer.TabIndex = 3;
            // 
            // txtType
            // 
            txtType.Location = new Point(105, 189);
            txtType.Name = "txtType";
            txtType.Size = new Size(415, 23);
            txtType.TabIndex = 4;
            // 
            // txtIpAddress
            // 
            txtIpAddress.Location = new Point(105, 218);
            txtIpAddress.Name = "txtIpAddress";
            txtIpAddress.Size = new Size(415, 23);
            txtIpAddress.TabIndex = 5;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Checked = false;
            dtpPurchaseDate.Location = new Point(105, 247);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.ShowCheckBox = true;
            dtpPurchaseDate.Size = new Size(415, 23);
            dtpPurchaseDate.TabIndex = 6;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(105, 276);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(415, 23);
            txtNotes.TabIndex = 7;
            // 
            // cboEmployee
            // 
            cboEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(105, 305);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(415, 23);
            cboEmployee.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(276, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save asset";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(105, 358);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Location = new Point(21, 110);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(78, 15);
            lblSystemName.TabIndex = 11;
            lblSystemName.Text = "System name";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(58, 139);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 12;
            lblModel.Text = "Model";
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(21, 168);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(79, 15);
            lblManufacturer.TabIndex = 13;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(67, 197);
            lblType.Name = "lblType";
            lblType.Size = new Size(32, 15);
            lblType.TabIndex = 14;
            lblType.Text = "Type";
            // 
            // lblIpAddress
            // 
            lblIpAddress.AutoSize = true;
            lblIpAddress.Location = new Point(37, 226);
            lblIpAddress.Name = "lblIpAddress";
            lblIpAddress.Size = new Size(62, 15);
            lblIpAddress.TabIndex = 15;
            lblIpAddress.Text = "Ip Address";
            // 
            // lblPurchaseDate
            // 
            lblPurchaseDate.AutoSize = true;
            lblPurchaseDate.Location = new Point(17, 253);
            lblPurchaseDate.Name = "lblPurchaseDate";
            lblPurchaseDate.Size = new Size(82, 15);
            lblPurchaseDate.TabIndex = 16;
            lblPurchaseDate.Text = "Purchase Date";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(61, 284);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(38, 15);
            lblNotes.TabIndex = 17;
            lblNotes.Text = "Notes";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(40, 313);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(59, 15);
            lblEmployee.TabIndex = 18;
            lblEmployee.Text = "Employee";
            // 
            // AddAssetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmployee);
            Controls.Add(lblNotes);
            Controls.Add(lblPurchaseDate);
            Controls.Add(lblIpAddress);
            Controls.Add(lblType);
            Controls.Add(lblManufacturer);
            Controls.Add(lblModel);
            Controls.Add(lblSystemName);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(cboEmployee);
            Controls.Add(txtNotes);
            Controls.Add(dtpPurchaseDate);
            Controls.Add(txtIpAddress);
            Controls.Add(txtType);
            Controls.Add(txtManufacturer);
            Controls.Add(txtModel);
            Controls.Add(txtSystemName);
            Controls.Add(lblInstructions);
            Name = "AddAssetForm";
            Text = "Add Asset";
            Load += AddAssetForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstructions;
        private TextBox txtSystemName;
        private TextBox txtModel;
        private TextBox txtManufacturer;
        private TextBox txtType;
        private TextBox txtIpAddress;
        private DateTimePicker dtpPurchaseDate;
        private TextBox txtNotes;
        private ComboBox cboEmployee;
        private Button btnSave;
        private Button btnClear;
        private Label lblSystemName;
        private Label lblModel;
        private Label lblManufacturer;
        private Label lblType;
        private Label lblIpAddress;
        private Label lblPurchaseDate;
        private Label lblNotes;
        private Label lblEmployee;
    }
}
