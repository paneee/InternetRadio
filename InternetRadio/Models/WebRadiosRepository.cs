using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetRadio.Models
{
    public class WebRadiosRepository : IWebRadiosRepository
    {
        private List<WebRadio> _webRadio = new List<WebRadio>();
        
        private void seed()
        {
            _webRadio.Add(new WebRadio("ChiliZet", "https://ch.cdn.eurozet.pl/chi-net.mp3"));
            _webRadio.Add(new WebRadio("357", "https://n06a-eu.rcs.revma.com/ye5kghkgcm0uv?rj-ttl=5&rj-tok=AAABduJfGVcAbh2i1fQT0iMZcA"));
            _webRadio.Add(new WebRadio("RNS", "https://ch.cdn.eurozet.pl/chi-net.mp3"));
            _webRadio.Add(new WebRadio("PR3 Trójka","mms://stream.polskieradio.pl/program3"));
            _webRadio.Add(new WebRadio("Record Chillout","http://air2.radiorecord.ru:805/chil_aac_64"));
            _webRadio.Add(new WebRadio("Radio Kampus","http://193.0.98.66:8005/"));
            _webRadio.Add(new WebRadio("Weszło","http://radio.weszlo.fm/s7d70a7895/listen"));
        }

        public WebRadiosRepository()
        {
            seed();
        }

        private bool ContainsRadio(WebRadio webRadio)
        {
            var k = _webRadio.Where(p => p.Name == webRadio.Name && p.Url == webRadio.Url).Count();
            if (_webRadio.Where(p => p.Name == webRadio.Name && p.Url == webRadio.Url).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddRadio(WebRadio webradio)
        {
            if (!ContainsRadio(webradio))
            {
                _webRadio.Add(webradio);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveRadio(WebRadio webradio)
        {
            if (ContainsRadio(webradio))
            {
                _webRadio.RemoveAll((c => c.Name == webradio.Name && c.Url == webradio.Url));
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<WebRadio> GetAllStation()
        {
            return _webRadio;
        }
    }
}
