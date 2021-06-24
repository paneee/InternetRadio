using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternetRadio.Models
{
    public class InternetRadioViewModel
    {
        public IEnumerable<SelectListItem> WebRadios { get; set; }
        public string SelectetRadio { get; set; }
        //public WebRadio WebRadioActualPlay { get; set; }
        //public WebRadio WebRadioLastPlay { get; set; }
    }
}
