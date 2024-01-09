using DAL.Entities;
using OkulApp.BLL.Repositories.OgretmenRepositories;
using System;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgretmenKayit : Form
    {
        public OgretmenWriteRepository _ogretmenwriterepository;
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
                await _ogretmenwriterepository.AddAsync(new Ogretmen()
                {
                    TcNo = int.Parse(textBoxtcno.Text),
                    Ad = textBoxad.Text,
                    Soyad = textBoxsoyad.Text,

                });
                await _ogretmenwriterepository.SaveAsync();
                MessageBox.Show("İşlem Başarılı");
                _ogretmenwriterepository.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void frmOgretmenKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
