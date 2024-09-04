namespace QueueingApplication
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier = new CashierClass();

        public QueuingForm(CashierClass cashier)
        {
            this.cashier = cashier;
        }

        public QueuingForm()
        {
            InitializeComponent();


        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }
    }
}
