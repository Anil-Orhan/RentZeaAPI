using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;

namespace Entities.Concrete
{
   public class Customer:IEntity
    {

        [Key]
        public int UserID { get; set; }
        public string CompanyName { get; set; }
    }
}
