using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetRadio.Models
{
    public interface IWebRadiosRepository
    {
        public IEnumerable<WebRadio> GetAllStation();
        public bool AddRadio(WebRadio webradio);
        public bool RemoveRadio(WebRadio webradio);
    }
}
