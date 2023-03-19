using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laba1.Models
{
    public class GuestResponse
    {
        public ushort Operand1 { get; set; }
        public ushort Operand2 { get; set; }
        public string Operation { get; set; }
        public decimal Result { get; set; }
    }

}