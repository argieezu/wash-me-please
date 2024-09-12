namespace LaundrySystem
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
