using LaundrySystem.AdminPages.Trasaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundrySystem.AdminPages
{
    public partial class TransactionFormAdmin : Form
    {
        public TransactionFormAdmin()
        {
            InitializeComponent();
        }

        private void buttonTrasactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistory transactionHistory = new TransactionHistory();
            this.Hide();
            transactionHistory.ShowDialog();
        }
    }
}
