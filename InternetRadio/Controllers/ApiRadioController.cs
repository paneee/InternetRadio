using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using InternetRadio.Models;

namespace InternetRadio.Controllers
{ 
    [ApiController]
    [Route("[controller]/[action]/{id?}")]
    public class ApiRadioController : ControllerBase
    {
        private readonly IWebRadiosRepository _radiosRepository;
        private readonly IWebRadio _webRadio;
        private readonly IWebPlayer _webPlayer;

        public ApiRadioController(IWebRadiosRepository radiosRepository, IWebRadio webRadio, IWebPlayer webPlayer)
        {
            _radiosRepository = radiosRepository;
            _webRadio = webRadio;
            _webPlayer = webPlayer;
        }

        [HttpGet]
        public WebRadio Play(WebRadio webRadio)
        {
            var list = _radiosRepository.GetAllStation().ToList();
            if (list.Contains(webRadio))
            { 
                _webPlayer.Play(webRadio.GetUrl());
                return webRadio;
            }
            else
            {
                return null;
            }
        }

        [HttpGet]
        public void Stop()
        {
            _webPlayer.Stop();
        }

        [HttpGet]
        public IEnumerable<WebRadio> VolumeUp()
        {
            _webPlayer.VolumeUp();
            return _radiosRepository.GetAllStation();
        }

        [HttpGet]
        public IEnumerable<WebRadio> VolumeUpUp()
        {
            _webPlayer.VolumeUpUp();
            return _radiosRepository.GetAllStation();
        }

        [HttpGet]
        public IEnumerable<WebRadio> VolumeDown()
        {
            _webPlayer.VolumeDown();
            return _radiosRepository.GetAllStation();
        }

        [HttpGet]
        public IEnumerable<WebRadio> VolumeDownDown()
        {
            _webPlayer.VolumeDownDown();
            return _radiosRepository.GetAllStation();
        }


        [HttpGet]
        public IEnumerable<WebRadio> GetAllStation()
        {
            return _radiosRepository.GetAllStation();
        }


        [HttpPost]
        public IEnumerable<WebRadio> AddStation(WebRadio webRadio)
        {
            _radiosRepository.AddRadio(webRadio);
            return _radiosRepository.GetAllStation();
           
        }

        [HttpPost]
        public IEnumerable<WebRadio> RemoveStation(WebRadio webRadio)
        {
            _radiosRepository.RemoveRadio(webRadio);
            return _radiosRepository.GetAllStation();
        }
    }
}
