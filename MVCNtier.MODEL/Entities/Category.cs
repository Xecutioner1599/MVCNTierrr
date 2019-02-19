using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNtier.MODEL.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }

        public string Description { get; set; }

        //Relational Properties (one to many with Product)

        public virtual List<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }
    }
}
