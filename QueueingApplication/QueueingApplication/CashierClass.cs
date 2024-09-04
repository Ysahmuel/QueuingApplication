namespace QueueingApplication
{
    public class CashierClass{

        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;

        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }

        public static void Main(string[] args)
        {
            Application.Run(new QueuingForm());
            Application.Run(new CashierWindowQueue());


        }
    }
}