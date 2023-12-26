using OkulApp.BLL.Repositories.OgretmenRepositories;
using System;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgretmenKayit : Form
    {
        readonly private OgretmenWriteRepository _ogretmenwriterepository;
        public frmOgretmenKayit(OgretmenWriteRepository ogretmenWriteRepository)
        {
            _ogretmenwriterepository = ogretmenWriteRepository;
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await _ogretmenwriterepository.AddAsync(new OkulApp.MODEL.Ogretmen()
                {
                    TcNo = int.Parse(textBoxtcno.Text),
                    Ad = textBoxad.Text,
                    Soyad = textBoxsoyad.Text,

                });
                await _ogretmenwriterepository.SaveAsync();
                MessageBox.Show("İşlem Başarılı");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void frmOgretmenKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
