using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.記帳
{
    internal class GroupModel
    {
        public String money { get; set; }
        public String type { get; set; }

        public GroupModel(String money, String type)
        {
            this.money = money;
            this.type = type;

        }

        public GroupModel()
        {

        }
    }
}
