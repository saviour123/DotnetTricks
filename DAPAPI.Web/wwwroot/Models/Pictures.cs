using System;
using System.Collections.Generic;

namespace DAPAPI.Web.Models
{
    public partial class Pictures
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public int? FileSize { get; set; }
        public string Format { get; set; }
        public string LargeImage { get; set; }
        public string MediumImage { get; set; }
        public string SmallImage { get; set; }
        public string Title { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
