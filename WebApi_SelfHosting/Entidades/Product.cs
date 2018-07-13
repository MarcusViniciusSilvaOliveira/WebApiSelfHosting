using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_SelfHosting.Entidades
{
    public class Product : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual string Code { get; set; }
        public virtual bool IsActive { get; set; }
    }
}
