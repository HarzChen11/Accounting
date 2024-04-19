using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.記帳
{
    internal class DayCount
    {
        public static List<GroupModel> GroupMethod(DateTime startDay, DateTime endDay)
        {
            CSVHelper helper = new CSVHelper();
            List<DataModel> dataModels = helper.ReadCSVModel<DataModel>(startDay, endDay);


            List<GroupModel> list = (
                from dm in dataModels
                group dm by dm.type into g
                select new GroupModel{ type = g.Key, money = g.Sum(x => int.Parse(x.money)).ToString() }
            ).ToList();


            return list;
        }

    }
}
