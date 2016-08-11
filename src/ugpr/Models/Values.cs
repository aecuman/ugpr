using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ugpr.Models
{
    [Table("Values")]
    public class Value
    {

        public int Id { get; set; }
        public string village { get; set; }
        public Nullable<double> block { get; set; }
        public string county { get; set; }
        public Nullable<double> acreage { get; set; }
        public Nullable<double> fair_value { get; set; }
        public string user { get; set; }
        public string tenure { get; set; }
        public Nullable<System.DateTime> period { get; set; }
        public string currency { get; set; }
        public string development { get; set; }
        public Nullable<double> rateperacre { get; set; }
    }
}
