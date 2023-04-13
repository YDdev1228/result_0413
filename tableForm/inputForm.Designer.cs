namespace tableForm
{
    partial class inputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputForm));
            panel1 = new Panel();
            btnDispose = new PictureBox();
            label1 = new Label();
            txtEmpId = new TextBox();
            txtLName = new TextBox();
            label2 = new Label();
            txtFName = new TextBox();
            label3 = new Label();
            txtMName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            txtContact = new TextBox();
            label8 = new Label();
            cboGender = new ComboBox();
            dtBdate = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDispose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btnDispose);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 61);
            panel1.TabIndex = 1;
            // 
            // btnDispose
            // 
            btnDispose.Cursor = Cursors.Hand;
            btnDispose.Dock = DockStyle.Right;
            btnDispose.Image = (Image)resources.GetObject("btnDispose.Image");
            btnDispose.Location = new Point(529, 0);
            btnDispose.Name = "btnDispose";
            btnDispose.Size = new Size(52, 61);
            btnDispose.SizeMode = PictureBoxSizeMode.CenterImage;
            btnDispose.TabIndex = 4;
            btnDispose.TabStop = false;
            btnDispose.Click += disposeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 91);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 2;
            label1.Text = "Employee Id";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(162, 88);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(377, 29);
            txtEmpId.TabIndex = 3;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(162, 123);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(377, 29);
            txtLName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 126);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(162, 158);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(377, 29);
            txtFName.TabIndex = 7;
            txtFName.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 161);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 6;
            label3.Text = "First Name";
            // 
            // txtMName
            // 
            txtMName.Location = new Point(162, 193);
            txtMName.Name = "txtMName";
            txtMName.Size = new Size(377, 29);
            txtMName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 196);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 8;
            label4.Text = "Middle Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 231);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 10;
            label5.Text = "Birth Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 266);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 12;
            label6.Text = "Gender";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(162, 298);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(377, 72);
            txtAddress.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 301);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 14;
            label7.Text = "Address";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(162, 376);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(377, 29);
            txtContact.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 379);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 16;
            label8.Text = "Contact No";
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(162, 263);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(377, 29);
            cboGender.TabIndex = 18;
            // 
            // dtBdate
            // 
            dtBdate.Location = new Point(162, 225);
            dtBdate.Name = "dtBdate";
            dtBdate.Size = new Size(377, 29);
            dtBdate.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(162, 421);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 47);
            btnSave.TabIndex = 20;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(256, 421);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 47);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button2_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 192, 0);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(350, 421);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 47);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // inputForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(579, 504);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dtBdate);
            Controls.Add(cboGender);
            Controls.Add(txtContact);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtMName);
            Controls.Add(label4);
            Controls.Add(txtFName);
            Controls.Add(label3);
            Controls.Add(txtLName);
            Controls.Add(label2);
            Controls.Add(txtEmpId);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "inputForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnDispose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnCancel;
        private PictureBox btnDispose;
        private TextBox txtEmpId;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtMName;
        private TextBox txtAddress;
        private TextBox txtContact;
        private ComboBox cboGender;
        private DateTimePicker dtBdate;
        private Button btnSave;
        private Button btnUpdate;
    }
}