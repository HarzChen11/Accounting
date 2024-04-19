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
    public partial class 帳戶 : Form
    {
        public 帳戶()
        {
            InitializeComponent();
            this.menuBar1.button7.Enabled = false;
        }

        private static 帳戶 childForm = null;


        public static Form getForm()
        {
            if (childForm == null)
            {

                childForm = new 帳戶();
            }
            return childForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan timeSpan = endDataPicker.Value.Subtract(startDataPicker.Value);
            String dirPath = ($@"C:\Users\user\Desktop\C#\ConsoleApp1\WindowsFormsApp1.記帳\記帳本檔案\");

            List<DataModel> list = null;
            CSVHelper cSVHelper = new CSVHelper();
            list = cSVHelper.ReadCSVModel<DataModel>(startDataPicker.Value, endDataPicker.Value);

            #region
            //for (int i = 0; i <= timeSpan.Days + 1; i++)
            //{
            //    DateTime dateTime = startDataPicker.Value.AddDays(i);
            //    CSVHelper helper = new CSVHelper();

            //    list.AddRange(helper.ReadCSVModel<DataModel>(Path.Combine(dirPath, dateTime.ToString("yyyy-MM-dd"))));
            //}
            #endregion


            #region 群組
            //var groupList = (
            //    from dm in list
            //    group dm by dm.type into g
            //    select new { key = g.Key, value = g.Sum(x => int.Parse(x.money)) }
            //).ToList();

            //foreach (var group in groupList)
            //{
            //    Console.WriteLine(group.key+" "+group.value);
            //}
            #endregion
            List<GroupModel> groupModels = DayCount.GroupMethod(startDataPicker.Value, endDataPicker.Value);


            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < groupModels.Count; i++)
            {
                FlowLayoutPanel panel1 = new FlowLayoutPanel();
                panel1.Width = flowLayoutPanel1.Width;
                panel1.Height = 30;
                //panel1.BorderStyle = BorderStyle.FixedSingle;

                Label label = new Label();
                label.Text = groupModels[i].type + "：";
                Label label1 = new Label();
                label1.Text = groupModels[i].money.ToString();

                panel1.Controls.Add(label);
                panel1.Controls.Add(label1);
                flowLayoutPanel1.Controls.Add(panel1);
            }



        }
    }
}
