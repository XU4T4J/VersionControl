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
            lblFullName = new Label();
            txtFullName = new TextBox();
            btnAdd = new Button();
            btnWriteFile = new Button();
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
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullName.Location = new Point(273, 34);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(52, 21);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "label1";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(359, 32);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(174, 23);
            txtFullName.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(273, 72);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(260, 35);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnWriteFile.Location = new Point(273, 125);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(260, 35);
            btnWriteFile.TabIndex = 6;
            btnWriteFile.Text = "button2";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 313);
            Controls.Add(btnWriteFile);
            Controls.Add(btnAdd);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(listUsers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listUsers;
        private Label lblFullName;
        private TextBox txtFullName;
        private Button btnAdd;
        private Button btnWriteFile;
    }
}
