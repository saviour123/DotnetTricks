using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Currencies
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public long? CountryId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
    }
}
