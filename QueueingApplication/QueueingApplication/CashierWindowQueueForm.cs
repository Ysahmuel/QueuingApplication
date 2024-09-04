using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QueueingApplication
{
    public partial class CashierWindowQueue : Form
    {
        public CashierWindowQueue()
        {
            InitializeComponent();


        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listCashierQueue.Items.Count > 0)
            {
                listCashierQueue.Items.RemoveAt(0);
            }
        }
    }
}
