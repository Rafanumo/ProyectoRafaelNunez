using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryApp
{
    public class RootObject
    {
        public int CurrentPage { get; set; }
        public int NumberOfPages { get; set; }
        public int TotalResults { get; set; }
        public List<Datum> Data { get; set; }
        public string Status { get; set; }

        public string message { get; set; }
    }
}
