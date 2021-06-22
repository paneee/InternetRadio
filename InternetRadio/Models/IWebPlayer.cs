using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetRadio.Models
{
    public interface IWebPlayer
    {
        public void Play(string url);
        public void Stop();
    }
}
