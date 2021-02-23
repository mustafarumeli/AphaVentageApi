using AlphaVentage.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVentage.Models
{
    public class StockTimeSeriesQuery : ApiQuery
    {
        public string Interval { get; set; }
        public override string ToString()
        {
            return base.ToString() + "&interval=" + Interval;
        }
    }
}
