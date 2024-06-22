using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionString_Model_Class.Models
{
    public class MailConfig
    {
        public string mailFrom { get; set; }
        public string host { get; set; }
        public string password { get; set; }
        public int portNo { get; set; }
    }
}
