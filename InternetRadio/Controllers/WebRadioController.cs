using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetRadio.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace InternetRadio.Controllers
{
    public class WebRadioController : Controller
    {
        private readonly IWebRadiosRepository _radiosRepository;
        private readonly IWebRadio _webRadio;
        private readonly IWebPlayer _webPlayer;
        private readonly InternetRadioViewModel _internetRadioViewModel;
        public WebRadioController(IWebRadiosRepository radiosRepository, IWebRadio webRadio, IWebPlayer webPlayer)
        {
            _radiosRepository = radiosRepository;
            _webRadio = webRadio;
            _webPlayer = webPlayer;

            _internetRadioViewModel = new InternetRadioViewModel();
        }

        private void RefreshViewModel()
        {
            _internetRadioViewModel.WebRadios = new SelectList(_radiosRepository.GetAllStation().Select(x => new { Value = x.GetUrl(), Text = x.GetName() }), "Value", "Text");
           //_internetRadioViewModel.WebRadioActualPlay = _webPlayer.GetActualPlay();
           ///_internetRadioViewModel.WebRadioLastPlay = _webPlayer.GetLastPlay();
        }

        [HttpGet]
        public ActionResult Index()
        {
             RefreshViewModel();
             return View(_internetRadioViewModel);
        }

        [HttpPost]
        public ActionResult Action(InternetRadioViewModel collection, string submit)
        {
            switch(submit)
            {
                case "Play":
                    int j = 9;
                    break;

                case "Stop":
                    break;

                case "VolumeUp":
                    break;

                case "VolumeUpUp":
                    break;

                case "VolumeDown":
                    break;

                case "VolumeDownDown":
                    break;
            }
            RefreshViewModel();
            return View("Index", _internetRadioViewModel);
        }
    }
}
