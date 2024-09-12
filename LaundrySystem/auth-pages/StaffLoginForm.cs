namespace LaundrySystem
{
    public partial class StaffLoginForm : Form
    {
        public StaffLoginForm()
        {
            InitializeComponent();
        }

        private void btnStaffLogin_Click(object sender, EventArgs e)
        {
            CustomerDashboard ins = new CustomerDashboard();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void StaffLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
