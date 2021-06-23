using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetRadio.Models
{
    public class WebRadio: IWebRadio
    {
        private string _name { get; set; }
        private string _url { get; set; }
      
        public WebRadio()
        {

        }
        public WebRadio(string name, string url)
        {
            _name = name;
            _url = url;
        }

        public string GetUrl()
        {
            return _url;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
