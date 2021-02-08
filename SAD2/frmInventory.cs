using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SAD2
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            FrmStockIn btn = new FrmStockIn();
            btn.Show();
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            frmStockOut btn = new frmStockOut();
            btn.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStockRecordDetails_Click(object sender, EventArgs e)
        {
            //Insert code para select ang database tas maview ang details sa pag stock in and out
            frmStockRecordDetails btn = new frmStockRecordDetails();
            btn.Show();
        }
    }
}
