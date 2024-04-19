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
    public partial class 圖表分析 : Form
    {
        public 圖表分析()
        {
            InitializeComponent();
            this.menuBar1.button8.Enabled = false;
        }

        private static 圖表分析 childForm = null;


        public static Form getForm()
        {
            if (childForm == null)
            {

                childForm = new 圖表分析();
            }
            return childForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // groupModel=DayCount.GroupMethod


            List<GroupModel> groups = DayCount.GroupMethod(startDataPicker.Value,endDataPicker.Value);
            List<string> keyLisy=new List<string>();
            List<string> valueLisy=new List<string>();

            foreach (var group in groups)
            {
                keyLisy.Add(group.type);
                valueLisy.Add(group.money);               
            }
            chart1.Series[0].Points.DataBindXY(keyLisy, valueLisy);


        }
    }
}
