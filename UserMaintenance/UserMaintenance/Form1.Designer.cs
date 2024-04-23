namespace UserMaintenance
{
    partial class Form1
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
            listUsers = new ListBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // listUsers
            // 
            listUsers.FormattingEnabled = true;
            listUsers.ItemHeight = 15;
            listUsers.Location = new Point(12, 12);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(213, 289);
            listUsers.TabIndex = 0;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(273, 34);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(52, 21);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "label1";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(273, 63);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(52, 21);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "label2";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(359, 32);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(174, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(359, 61);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(174, 23);
            txtFirstName.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(273, 100);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(260, 35);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 313);
            Controls.Add(btnAdd);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(listUsers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listUsers;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnAdd;
    }
}
