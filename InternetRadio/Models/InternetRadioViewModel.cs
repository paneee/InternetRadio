using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternetRadio.Models
{
    public class InternetRadioViewModel
    {
        public IEnumerable<SelectListItem> WebRadios { get; set; }
        public string SelectetRadioUrl { get; set; }
        public string ActualPlayed { get; set; }
        public int ActualVolume { get; set; }
    }
}
