using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3;

namespace WpfApp3
{
    public class Agency
    {
        [Key] // This attribute specifies that 'objectid' is the primary key
        public string objectid { get; set; }

        public string agency_code { get; set; }
        public string agency_name { get; set; }
    }
}