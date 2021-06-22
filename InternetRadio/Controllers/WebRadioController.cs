﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternetRadio.Models;

namespace InternetRadio.Controllers
{
    public class WebRadioController : Controller
    {
        private readonly IWebRadiosRepository _radiosRepository;
        private readonly IWebRadio _webRadio;
        private readonly IWebPlayer _webPlayer;
        public WebRadioController(IWebRadiosRepository radiosRepository, IWebRadio webRadio, IWebPlayer webPlayer)
        {
            _radiosRepository = radiosRepository;
            _webRadio = webRadio;
            _webPlayer = webPlayer;
        }
        public ActionResult Index()
        {
            return View(_radiosRepository.GetAllStation());
        }

        public ActionResult Play()
        {
            return View("Index", _radiosRepository.GetAllStation());
        }

        public ActionResult Stop()
        {
            return View("Index", _radiosRepository.GetAllStation());
        }

        public ActionResult VolumeUp()
        {
            return View("Index", _radiosRepository.GetAllStation());
        }

        public ActionResult VolumeDown()
        {
            return View("Index", _radiosRepository.GetAllStation());
        }
        public ActionResult VolumeUpUp()
        {
            return View("Index", _radiosRepository.GetAllStation());
        }

        public ActionResult VolumeDownDown()
        {
            return View("Index", _radiosRepository.GetAllStation());
        }
    }
}
