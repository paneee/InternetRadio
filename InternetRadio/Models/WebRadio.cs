using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetRadio.Models
{
    public class WebRadio: IWebRadio
    {
        public string Name { get; set; }
        public string Url { get; set; }
      
        public WebRadio()
        {

        }
        public WebRadio(string name, string url)
        {
            Name = name;
            Url = url;
        }
    }
}
