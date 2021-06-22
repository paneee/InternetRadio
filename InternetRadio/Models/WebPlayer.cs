using NAudio.Wave;
using System.Collections.Generic;

namespace InternetRadio.Models
{
    public class WebPlayer : IWebPlayer
    {
        private MediaFoundationReader _mediaFoundationReader;
        private WaveOutEvent _waveOutEvent;


        public void Play(string url)
        {
            if(_waveOutEvent == null)
            {
                _mediaFoundationReader = new MediaFoundationReader(url);
                _waveOutEvent = new WaveOutEvent();
                _waveOutEvent.Init(_mediaFoundationReader);
                _waveOutEvent.Play();
            }
            else
            {
                _waveOutEvent.Stop();
                _waveOutEvent.Dispose();
                _mediaFoundationReader.Dispose();
                _mediaFoundationReader = new MediaFoundationReader(url);
                _waveOutEvent = new WaveOutEvent();
                _waveOutEvent.Init(_mediaFoundationReader);
                _waveOutEvent.Play();

            }
        }

        public void Stop()
        {
            _waveOutEvent.Stop();
            _waveOutEvent.Dispose();
            _mediaFoundationReader.Dispose();
        }


    }
}
