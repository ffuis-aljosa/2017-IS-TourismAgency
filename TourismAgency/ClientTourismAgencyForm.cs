using System.Windows.Forms;

namespace TourismAgency
{
    public partial class ClientTourismAgencyForm : Form
    {
        public ClientTourismAgencyForm()
        {
            InitializeComponent();

        }

        private void ClientTourismAgencyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void toolStripButton1_Click(object sender, System.EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show(); 
        }
    }
}
