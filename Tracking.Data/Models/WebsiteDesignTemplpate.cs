using System;
using System.Collections.Generic;
using System.Text;

namespace Tracking.Data.Models
{
    public class WebsiteDesignTemplpate
    {
        public string Title { get; set; }
        public string SEO { get; set; }
        public string HeadDescription { get; set; }
        public int NumberOfColumnsInBody { get; set; }

        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }
    }
}
