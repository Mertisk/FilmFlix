namespace FKYS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(txtUserName.Text,txtPass.Text)==false)
            {
                MessageBox.Show("Geçersiz Kullanıcı adı veya şifre");
                return;
            }
            else
            {
                this.Hide();
                var frmMain = new frmMain();
                frmMain.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}