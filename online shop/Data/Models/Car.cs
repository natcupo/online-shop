using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace online_shop.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        public string name { set; get; }
        public string Shortdesc { set; get; }
        public string LongDesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool IsFavourite { set; get; }
        public bool available { set; get; }
        public int categoryId {set; get;}
        public virtual Category Category { set; get; }

    }
}
