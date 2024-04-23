using System.ComponentModel;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblFullName.Text=Resource1.FullName;
            btnAdd.Text=Resource1.Add;
            btnWriteFile.Text=Resource1.WriteFile;

            //listbox1
            listUsers.DataSource=users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtFullName.Text,
            };
            users.Add(u);
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog(this);
            using StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
            foreach (User user in users)
            {
                sw.WriteLine("ID: {0} Név: {1}", user.ID, user.FullName);
            }
            
            
        }
    }
}
