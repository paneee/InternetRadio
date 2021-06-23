using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetRadio.Models
{
    public interface IWebRadio
    {
        public string GetUrl();
        public string GetName();
    }
}
