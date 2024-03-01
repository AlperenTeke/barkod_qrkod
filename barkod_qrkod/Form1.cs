using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barkod_qrkod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Qr_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Qr.Text))
            {
                Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                picture_Qr.Image = qrCode.Draw(txt_Qr.Text, 30);
            }
        }

        private void btn_Barkod_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Barkod.Text))
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picture_Barkod.Image = barcode.Draw(txt_Barkod.Text, 30);
            }
        }
    }
}
