using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace metroapp
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Value { get; set; }
    }

    public class Items
    {
        public int ItemsId { get; set; }
        public int CategoryId { get; set; }
        public int ItemValue { get; set; }
    }
}