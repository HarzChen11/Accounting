using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.記帳
{
    public partial class 記一筆 : Form
    {
        public 記一筆()
        {
            InitializeComponent();
        }

        private static 記一筆 childForm = null;


        public static Form getForm()
        {
            if (childForm == null)
            {

                childForm = new 記一筆();
            }
            return childForm;
        }

        List<KeyValue> type = new List<KeyValue>();
        private void 記一筆_Load(object sender, EventArgs e)
        {
            MenuBar.form = this;
            this.menuBar1.button5.Enabled = false;

            pictureBox1.Image = Image.FromFile(@"C:\Users\user\Desktop\C#\ConsoleApp1\WindowsFormsApp1.記帳\A.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Image.FromFile(@"C:\Users\user\Desktop\C#\ConsoleApp1\WindowsFormsApp1.記帳\A.png");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            List<KeyValue> incomList = new List<KeyValue>();
            incomList.Add(new KeyValue("收入", 1));
            incomList.Add(new KeyValue("支出", 2));

            comboBox1.DataSource = incomList;
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";

            //List<KeyValue> type = new List<KeyValue>();
            type.Add(new KeyValue("薪水", 1));
            type.Add(new KeyValue("獎金", 2));
            type.Add(new KeyValue("加班費", 3));

            comboBox2.DataSource = type;
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";

        }

        private void upLoadImageClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = (@"C:\Users\user\Downloads");
            openFileDialog.Filter = "圖片檔|*.png;.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox pictureBox = (PictureBox)sender;
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String date = dateTimePicker1.Value.ToString("yyyy/MM/dd HH:mm");
            String money = textBox1.Text;
            String incom = comboBox1.Text;
            String type = comboBox2.Text;
            String remark = textBox2.Text;
            String Path = ($@"C:\Users\user\Desktop\C#\ConsoleApp1\WindowsFormsApp1.記帳\記帳本檔案\{dateTimePicker1.Value.ToString("yyyy-MM-dd")}\");

            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            String img1Path = Path + Guid.NewGuid().ToString() + ".png";
            String img2Path = Path + Guid.NewGuid().ToString() + ".png";

            pictureBox1.Image.Save(img1Path);
            pictureBox2.Image.Save(img2Path);

            //Console.WriteLine(date);
            //Console.WriteLine(money);
            //Console.WriteLine(incom);
            //Console.WriteLine(type);
            //Console.WriteLine(remark);

            CSVHelper cSVHelper = new CSVHelper();
            cSVHelper.WriteCSV(Path, new DataModel(date, money, incom, type, remark, img1Path, img2Path));

            //StreamWriter writer = new StreamWriter(Path + "記帳.csv", true);
            //writer.WriteLine($"{date},{money},{incom},{type},{remark},{img1Path},{img2Path}");
            //writer.Flush();
            //writer.Close();

            MessageBox.Show("新增成功");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int paynumber = (int)(comboBox1.SelectedValue);
            if (comboBox1.SelectedValue is int)
            {
                if ((int)comboBox1.SelectedValue == 2)
                {
                    List<KeyValue> payout = new List<KeyValue>();
                    payout.Add(new KeyValue("食", 1));
                    payout.Add(new KeyValue("衣", 2));
                    payout.Add(new KeyValue("住", 3));
                    payout.Add(new KeyValue("行", 4));
                    payout.Add(new KeyValue("育", 5));
                    payout.Add(new KeyValue("樂", 6));

                    comboBox2.DataSource = payout;
                    comboBox2.DisplayMember = "Key";
                    comboBox2.ValueMember = "Value";
                }
                else if ((int)comboBox1.SelectedValue == 1)
                {
                    comboBox2.DataSource = type;
                    comboBox2.DisplayMember = "Key";
                    comboBox2.ValueMember = "Value";
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
