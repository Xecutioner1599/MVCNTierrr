using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNtier.MODEL.Entities
{
    public class Order:BaseEntity
    {
        public string ShippedAddress { get; set; }

        public DateTime? RequiredDate { get; set; }

        public int? AppUserID { get; set; }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }
    }
}
