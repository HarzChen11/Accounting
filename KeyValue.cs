using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.記帳
{
    internal class KeyValue
    {
        public String Key { get; set; }
        public int Value { get; set; }

        public KeyValue(string Key,int Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
