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

        private void müþterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var musteri = new MÜÞTERÝLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,

            };
            musteri.StartPosition = FormStartPosition.CenterParent;
            musteri.ShowDialog(this);
        }

        private void þirketlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sirket = new SÝRKETLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,

            };
            sirket.StartPosition = FormStartPosition.CenterParent;
            sirket.ShowDialog(this);

        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var personel = new PERSONELLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,

            };
            personel.StartPosition = FormStartPosition.CenterParent;
            personel.ShowDialog(this);
        }
    }
}
