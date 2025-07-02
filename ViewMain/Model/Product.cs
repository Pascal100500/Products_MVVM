using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewMain.Model
{
    public class Product
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal Cost { get; set; }
    }
}
