namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemberID = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            cbCountry = new ComboBox();
            cbCity = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 46);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 105);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 1;
            label2.Text = "Member Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 170);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 229);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 292);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 350);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 5;
            label6.Text = "City";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(323, 39);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(206, 27);
            txtMemberID.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(323, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(206, 27);
            txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(323, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(323, 222);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(206, 27);
            txtPass.TabIndex = 9;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Items.AddRange(new object[] { "Viet Nam", "United State", "Laos", "Philiphin", "Singapore", "Myanma", "Denmark" });
            cbCountry.Location = new Point(323, 284);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(206, 28);
            cbCountry.TabIndex = 10;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Items.AddRange(new object[] { "Ha Noi", "Singapore", "Dallas", "Kula lumpur", "viengchan", "Tp HCM" });
            cbCity.Location = new Point(323, 342);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(206, 28);
            cbCity.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(265, 421);
            button1.Name = "button1";
            button1.Size = new Size(85, 27);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(457, 421);
            button2.Name = "button2";
            button2.Size = new Size(85, 27);
            button2.TabIndex = 13;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbCity);
            Controls.Add(cbCountry);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtMemberID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMemberDetail";
            Text = "frmMemberDetail";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMemberID;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPass;
        private ComboBox cbCountry;
        private ComboBox cbCity;
        private Button button1;
        private Button button2;
    }
}