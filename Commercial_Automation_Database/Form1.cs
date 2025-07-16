namespace Commercial_Automation_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new ÜRÜNLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        }
    }
}
