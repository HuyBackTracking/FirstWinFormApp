namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            label7 = new Label();
            txtMemberID = new TextBox();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            button6 = new Button();
            cbCountry = new ComboBox();
            cbCity = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, -1);
            label1.Name = "label1";
            label1.Size = new Size(464, 60);
            label1.TabIndex = 0;
            label1.Text = "Member Mangement";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(64, 84);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 1;
            label2.Text = "Member ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 258);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 2;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 164);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 84);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 4;
            label5.Text = "Member Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 261);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 167);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(178, 79);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(242, 27);
            txtMemberID.TabIndex = 7;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(178, 258);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(242, 27);
            txtPass.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(178, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(583, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 27);
            txtName.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 436);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(820, 205);
            dataGridView1.TabIndex = 13;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(178, 313);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(499, 27);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(704, 311);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(252, 374);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(401, 374);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 20;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(543, 374);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button6
            // 
            button6.Location = new Point(380, 657);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 22;
            button6.Text = "Close";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(583, 161);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(242, 28);
            cbCountry.TabIndex = 23;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(583, 250);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(242, 28);
            cbCity.TabIndex = 24;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 698);
            Controls.Add(cbCity);
            Controls.Add(cbCountry);
            Controls.Add(button6);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtPass);
            Controls.Add(txtMemberID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label7;
        private TextBox txtMemberID;
        private TextBox txtPass;
        private TextBox txtEmail;
        private TextBox txtName;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button button6;
        private ComboBox cbCountry;
        private ComboBox cbCity;
    }
}