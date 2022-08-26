using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass232
{
    class product : IComparable<product>
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int CompareTo(product other)
        {
           
            //return this.Price - other.Price;
            //return this.Price.CompareTo(other.Price);
            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return this.Name + ":" + this.Price + "원";
        }
    }
}
