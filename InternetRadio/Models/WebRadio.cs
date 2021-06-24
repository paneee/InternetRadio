using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetRadio.Models
{
    public class WebRadio: IWebRadio
    {
        public string name { get; set; }
        public string url { get; set; }
      
        public WebRadio()
        {

        }
        public WebRadio(string name, string url)
        {
            this.name = name;
            this.url = url;
        }

        public string GetUrl()
        {
            return url;
        }

        public string GetName()
        {
            return name;
        }

        public WebRadio GetWebRadio()
        {
            return this;
        }
    }
}
