using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternetRadio.Models
{
    public class InternetRadioViewModel
    {
        [Key]
        public int id { get; set; }
        public List<string> WebRadioSelectList { get; set; }
        //public WebRadio WebRadioActualPlay { get; set; }
        //public WebRadio WebRadioLastPlay { get; set; }
    }
}
