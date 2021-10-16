using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace jobportal.Models
{
    public class user
    {
        [Key]
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string dob { get; set; }
        public string email { get; set; }
        public Int64 number { get; set; }
       public string gender { get; set; }
        public int isactive { get; set; }
        public int searching { get; set; }

    }
}