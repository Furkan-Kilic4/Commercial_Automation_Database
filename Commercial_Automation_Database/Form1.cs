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

        private void �r�nlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var urun = new �R�NLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,

            };
            urun.StartPosition = FormStartPosition.CenterParent;
            urun.ShowDialog(this);
        }

        private void m��terilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var musteri = new M��TER�LER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,

            };
            musteri.StartPosition = FormStartPosition.CenterParent;
            musteri.ShowDialog(this);
        }

        private void �irketlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sirket = new S�RKETLER
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

        private void giderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var giderler = new G�DERLER
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,

            };
            giderler.StartPosition = FormStartPosition.CenterParent;
            giderler.ShowDialog(this);
        }

        private void bankalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bankalar = new BANKALAR
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false,

            };
            bankalar.StartPosition = FormStartPosition.CenterParent;
            bankalar.ShowDialog(this);
        }
    }
}
