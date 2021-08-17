using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ErrorHandling.Shared
{
    public class Berekening
    {
        public int Teller { get; set; }
        public decimal Noemer { get; set; }
        public decimal Uitkomst { get; set; }
    }
}
