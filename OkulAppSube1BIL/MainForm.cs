using OkulApp.BLL.Repositories.OgretmenRepositories;
using System;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class MainForm : Form
    {
        private readonly OgretmenWriteRepository _ogretmenWriteRepository;

        public MainForm(OgretmenWriteRepository ogretmenWriteRepository)
        {
            _ogretmenWriteRepository = ogretmenWriteRepository;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            frmOgretmenKayit frm = new frmOgretmenKayit(_ogretmenWriteRepository);
            frm.Show();


        }
    }
}
