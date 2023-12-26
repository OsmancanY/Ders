using OkulApp.BLL.Repositories.OgrenciRepository;
using System;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgrenciRemove : Form
    {
        readonly private OgrenciWriteRepository _ogrenciWriteRepository;
        public frmOgrenciRemove(OgrenciWriteRepository ogrenciWriteRepository)
        {
            _ogrenciWriteRepository = ogrenciWriteRepository;
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (radioButton1 != null)
            {
                try
                {
                    _ogrenciWriteRepository.RemoveAsync(textBoxOgrenciId.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
            else { MessageBox.Show("Eminmisiniz sorusu atlanamaz."); }

        }
    }
}
