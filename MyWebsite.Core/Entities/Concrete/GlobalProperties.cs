using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Core.Entities.Concrete
{
    public static class GlobalProperties
    {
        public static string DbConn { get; set; }
        public static string SeoDesc { get; set; }
        public static string SeoTags { get; set; }
        public static string SeoAuthor { get; set; }
    }

}
