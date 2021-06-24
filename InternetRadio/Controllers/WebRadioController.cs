﻿using Microsoft.AspNetCore.Mvc;
using InternetRadio.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace InternetRadio.Controllers
{
    public class WebRadioController : Controller
    {
        private readonly IWebRadiosRepository _radiosRepository;
        private readonly IWebRadio _webRadio;
        private readonly IWebPlayer _webPlayer;
        private readonly InternetRadioViewModel _internetRadioViewModel = new InternetRadioViewModel();


        public WebRadioController(IWebRadiosRepository radiosRepository, IWebRadio webRadio, IWebPlayer webPlayer)
        {
            _radiosRepository = radiosRepository;
            _webRadio = webRadio;
            _webPlayer = webPlayer;
            _internetRadioViewModel.WebRadios = new SelectList(_radiosRepository.GetAllStation().Select(x => new { Value = x.GetUrl(), Text = x.GetName() }), "Value", "Text");
        }


        private void RefreshActualPlayed()
        {
            List<WebRadio> listaRadio = _radiosRepository.GetAllStation().ToList();
            WebRadio radio = listaRadio.Where(p => p.GetUrl() == _webPlayer.GetActualPlay()).FirstOrDefault();
            if (radio != null)
            {
                _internetRadioViewModel.ActualVolume = _webPlayer.ActualVolume();
                _internetRadioViewModel.ActualPlayed = radio.GetName();
            }
            else
            {
                _internetRadioViewModel.ActualPlayed = " - - - - - ";
            }
        }


        [HttpGet]
        public ActionResult Index()
        {
            RefreshActualPlayed();
            return View(_internetRadioViewModel);
        }


        [HttpPost]
        public ActionResult Action(InternetRadioViewModel internetRadioViewModel, string submit)
        {
            switch (submit)
            {
                case "Play":
                    _webPlayer.Play(internetRadioViewModel.SelectetRadioUrl);
                    break;

                case "Stop":
                    _webPlayer.Stop();
                    break;

                case "Volume +":
                    _webPlayer.VolumeUp();
                    break;

                case "Volume ++":
                    _webPlayer.VolumeUpUp();
                    break;

                case "Volume -":
                    _webPlayer.VolumeDown();
                    break;

                case "Volume --":
                    _webPlayer.VolumeDownDown();
                    break;
            }
            RefreshActualPlayed();
            return View("Index", _internetRadioViewModel);
        }
    }
}
