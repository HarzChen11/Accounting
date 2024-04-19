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
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        //private static MenuBar GetMenuBar = new MenuBar();

        //public static UserControl GetControl()
        //{
           
        //    return GetMenuBar;
        //}

        public static Form form = null;
        private void ChangeForm(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            
            if (form!= null)
            {
                form.Hide();
            }


            switch (button.Text)
            {
                case "記一筆":
                    form = new 記一筆();
                    form.Show();
                    break;

                case "記帳本":
                    form = new 記帳本();
                    form.Show();                   
                    break;
                case "帳戶":
                    form = new 帳戶();
                    form.Show();
                    break;
                case "圖表分析":
                    form = new 圖表分析();
                    form.Show();
                    break;
            }
        }
    }
}
