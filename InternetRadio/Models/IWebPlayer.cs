using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetRadio.Models
{
    public interface IWebPlayer
    {
        public void Play(string urlWebRadio);
        public void Stop();
        public int ActualVolume();
        public void VolumeUp();
        public void VolumeUpUp();
        public void VolumeDown();
        public void VolumeDownDown();
        public string GetActualPlay();
        public string GetLastPlay();
    }
}
