using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternetRadio.Models
{
    public class Class
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

        public InternetRadioViewModel radio { get; set; }
    }
}
