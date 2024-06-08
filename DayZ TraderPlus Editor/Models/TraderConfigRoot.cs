using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayZ_TraderPlus_Editor.Models
{
    public class TraderConfigRoot
    {
        public string Version { get; set; }
        public int EnableAutoCalculation { get; set; }
        public int EnableAutoDestockAtRestart { get; set; }
        public int EnableDefaultTraderStock { get; set; }

        public List<TraderCategory> TraderCategories { get; set; }
    }
}
