using MVCNtier.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCNtier.MODEL.Entities
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string RePassword { get; set; }

        public Guid ActivationCode { get; set; }

        public Role Role { get; set; }

        public bool IsActive { get; set; }

        public bool IsBanned { get; set; }

        public string UserIdentity { get; set; }

        public string UserIP { get; set; }

        public string Email { get; set; }

        public AppUser()
        {
            IsActive = false;
            IsBanned = false;
            Role = Role.Member;
            ActivationCode = Guid.NewGuid();
        }

        //Relational Properties

        public virtual AppUserDetail AppUserDetail { get; set; }
    }
}
