using static System.Net.Mime.MediaTypeNames;

namespace FactoryTest
{
    public partial class frmRunFactory : Form
    {
        Test test;

        public frmRunFactory()
        {
            InitializeComponent();
            MyInit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test.Run();
            textBox1.Text = test.GetLog();
        }

        private void MyInit()
        {
            test = new Test();
        }
    }
}