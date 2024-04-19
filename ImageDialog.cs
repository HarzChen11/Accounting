using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.記帳
{
    public partial class ImageDialog : Form
    {
        public ImageDialog(String imgurl)
        {
            InitializeComponent();

            pictureBox1.Image = Image.FromFile(imgurl);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void ImageDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
