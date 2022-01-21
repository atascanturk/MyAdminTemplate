using MyWebsite.Core.Utilities.Results.ComplexTypes;
using MyWebsite.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Entities.Dtos
{
    public class VideoDto
    {
        public Video Video { get; set; }
        public ResultStatus ResultStatus { get; set; }
        public string Message { get; set; }
    }
}
