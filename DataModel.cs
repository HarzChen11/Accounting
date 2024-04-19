using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.記帳
{
    internal class DataModel
    {
        [DisplayName("日期")]
        public String date { get; set; }
        [DisplayName("金額")]
        public String money { get; set; }
        [DisplayName("收支")]
        public String income { get; set; }
        [DisplayName("類型")]
        public String type { get; set; }
        [DisplayName("備註")]
        public String remark { get; set; }
        [DisplayName("圖1")]
        public String img1 { get; set; }
        [DisplayName("圖2")]
        public String img2 { get; set; }

        public DataModel(String date, String money, String income, String type, String remark, String img1, String img2)
        {
            this.date = date;
            this.money = money;
            this.income = income;
            this.type = type;
            this.remark = remark;
            this.img1 = img1;
            this.img2 = img2;

        }

        public DataModel()
        {

        }
    }
}
