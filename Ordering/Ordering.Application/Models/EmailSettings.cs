using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.API.Models
{
    public class EmailSettings
    {
        public string  ApiKey { get; set; }
        public string FromAddress { get; set; }

        public string FromName { get; set; }
    }
}
