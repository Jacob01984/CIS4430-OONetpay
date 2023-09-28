namespace OONetpay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            Netpay netpay = new Netpay();
            netpay.hrs = (int) numHours.Value;
            netpay.pr = Convert.ToDouble(txtPayrate.Text);
            netpay.yoe = (int)numYOS.Value;
            txtGross.Text = netpay.CalcGross().ToString("N2");
            txtFed.Text = netpay.CalcFed().ToString("N2");
            txtSs.Text = netpay.CalcSS().ToString("N2");
            txtMed.Text = netpay.CalcMed().ToString("N2");
            txtTotalDed.Text = netpay.CalctotalDed().ToString("N2");
            txtLong.Text = netpay.CalctotalDed().ToString("N2");
            txtPay.Text = netpay.calcNetPay().ToString("N2");
        }
    }
}