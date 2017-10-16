using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryApp
{
    public class Datum
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NameShortDisplay { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public string Established { get; set; }
        public string IsOrganic { get; set; }
        public Images Images { get; set; }
        public string Status { get; set; }
        public string StatusDisplay { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        public string IsMassOwned { get; set; }
        public string BrandClassification { get; set; }
        public string MailingListUrl { get; set; }
    }
}
