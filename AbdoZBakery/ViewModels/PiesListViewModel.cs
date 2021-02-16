using AbdoZBakery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbdoZBakery.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> PieList { get; set; }

        public string CurrentCategory { get; set; }
    }
}
