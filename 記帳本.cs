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
    public partial class 記帳本 : Form
    {
        public 記帳本()
        {
            InitializeComponent();
            this.menuBar1.button6.Enabled = false;
        }

        private static 記帳本 childForm = null;


        public static Form getForm()
        {
            if (childForm == null)
            {

                childForm = new 記帳本();
            }
            return childForm;
        }

        List<DataModel> list = null;
        private void button1_Click(object sender, EventArgs e)
        {
            

            String Path = ($@"C:\Users\user\Desktop\C#\ConsoleApp1\WindowsFormsApp1.記帳\記帳本檔案\{dateTimePicker1.Value.ToString("yyyy-MM-dd")}\");

            CSVHelper cSVHelper = new CSVHelper();
            list = cSVHelper.ReadCSVModel<DataModel>(Path);

            if (list.Count == 0)
            {
                MessageBox.Show("今天沒資料");
            }
            else
            {

                initDataGridView1();
            }

            

            //StreamReader streamReader = new StreamReader(Path + "記帳.csv");
            //while (!streamReader.EndOfStream)
            //{
            //    String[] datas = streamReader.ReadLine().Split(',');
            //    DataModel dataModel = new DataModel(datas[0], datas[1], datas[2], datas[3], datas[4], datas[5], datas[6]);
            //    list.Add(dataModel);
            //    Console.WriteLine(datas);
            //}




        }

        private void initDataGridView1()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = list;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns["img1"].Visible = false;
            dataGridView1.Columns["img2"].Visible = false;

            dataGridView1.Columns.Add(new DataGridViewImageColumn()
            {
                HeaderText = "圖一"
            });

            dataGridView1.Columns.Add(new DataGridViewImageColumn()
            {
                HeaderText = "圖二"
            });
            dataGridView1.Columns.Add(new DataGridViewImageColumn()
            {
                HeaderText = "刪除"
            });

            for (int i = 0; i < list.Count; i++)
            {

                dataGridView1.Rows[i].Cells[7].Value = Image.FromFile(list[i].img1);
                dataGridView1.Rows[i].Cells[8].Value = Image.FromFile(list[i].img2);
                dataGridView1.Rows[i].Cells[9].Value = Image.FromFile(@"C:\Users\user\Desktop\C#\ConsoleApp1\WindowsFormsApp1.記帳\垃圾桶.png");
            }
        }

        CSVHelper helper = new CSVHelper();
        private void Click(object sender, DataGridViewCellEventArgs e)
        {

            String Path = ($@"C:\Users\user\Desktop\C#\ConsoleApp1\WindowsFormsApp1.記帳\記帳本檔案\{dateTimePicker1.Value.ToString("yyyy-MM-dd")}\");
            ImageDialog imageDialog = null;
            switch (e.ColumnIndex)
            {
                case 7:
                    imageDialog = new ImageDialog(list[e.RowIndex].img1);
                    //Console.WriteLine(list[e.RowIndex].img1.ToString());
                    break;
                case 8:
                    imageDialog = new ImageDialog(list[e.RowIndex].img2);
                    break;
                case 9:
                    DataModel data = list[e.RowIndex];

                    Image image1 = (Image)dataGridView1.Rows[e.RowIndex].Cells[7].Value;
                    Image image2 = (Image)dataGridView1.Rows[e.RowIndex].Cells[8].Value;
                    image1.Dispose();
                    image2.Dispose();
                    list.Remove(data);


                    File.Delete(list[e.RowIndex].img1.ToString());
                    File.Delete(list[e.RowIndex].img2.ToString());


                    //File.Delete(data.img1);
                    //File.Delete(data.img2);
                    File.Delete(Path + "記帳.csv");



                    foreach (var item in list)
                    {
                        helper.WriteCSV(Path, item);
                    }

                    list = helper.ReadCSVModel<DataModel>(Path);


                    //for(int i = 0; i < list.Count; i++)
                    //{
                    //    String date = dateTimePicker1.Value.ToString("yyyy/MM/dd HH:mm");
                    //    String money = list[i].money;
                    //    String incom = list[i].income;
                    //    String type = list[i].type;
                    //    String remark = list[i].remark;
                    //    String img1Path = list[i].img1;
                    //    String img2Path = list[i].img2;
                    //    helper.WriteCSV(Path, new DataModel(date, money, incom, type, remark, img1Path, img2Path));

                    //}



                    initDataGridView1();
                    break;
            }

            if (imageDialog != null)
            {
                imageDialog.ShowDialog();
            }
        }

        private void txtEdit(object sender, DataGridViewCellEventArgs e)
        {
            String Path = ($@"C:\Users\user\Desktop\C#\ConsoleApp1\WindowsFormsApp1.記帳\記帳本檔案\{dateTimePicker1.Value.ToString("yyyy-MM-dd")}\");
            switch (e.ColumnIndex)
            {
                case 0:
                    list[e.RowIndex].date = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    break;
                case 1:
                    list[e.RowIndex].money = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case 2:
                    list[e.RowIndex].income = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    break;
                case 3:
                    list[e.RowIndex].type = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    break;
                case 4:
                    list[e.RowIndex].remark = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    break;

            }


            File.Delete(Path + "記帳.csv");

            foreach (var item in list)
            {
                helper.WriteCSV(Path, item);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image image1 = (Image)this.dataGridView1.Rows[0].Cells[7].Value;
            Image image2 = (Image)this.dataGridView1.Rows[0].Cells[8].Value;
            image1.Dispose();
            image2.Dispose();
            this.dataGridView1.Dispose();
            File.Delete(list[0].img1);
            File.Delete(list[0].img2);
            this.list.RemoveAt(0);
            initDataGridView1();

        }
    }
}
