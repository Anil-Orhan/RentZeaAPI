using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities.DTOs
{
    public class PayProcessPack
    {
        public Customer customer { get; set; }
        
        public decimal totalAmount { get; set; }    

    }
}
