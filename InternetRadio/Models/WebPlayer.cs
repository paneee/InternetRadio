using NAudio.Wave;
using System.Collections.Generic;

namespace InternetRadio.Models
{
    public class WebPlayer : IWebPlayer
    {
        private MediaFoundationReader _mediaFoundationReader;
        private WaveOutEvent _waveOutEvent; 
        private WebRadio _actualPlay;
        private WebRadio _lastPlay;

        public WebRadio GetActualPlay()
        {
            return _actualPlay;
        }

        public WebRadio GetLastPlay()
        {
            return _lastPlay;
        }

        public void Play(WebRadio webRadio)
        {
            if(_waveOutEvent == null)
            {
                _mediaFoundationReader = new MediaFoundationReader(webRadio.GetUrl());
                _waveOutEvent = new WaveOutEvent();
                _waveOutEvent.Init(_mediaFoundationReader);
                _waveOutEvent.Play();
                _actualPlay = webRadio;
            }
            else
            {
                _lastPlay = _actualPlay;
                _waveOutEvent.Stop();
                _waveOutEvent.Dispose();
                _mediaFoundationReader.Dispose();
                _mediaFoundationReader = new MediaFoundationReader(webRadio.GetUrl());
                _waveOutEvent = new WaveOutEvent();
                _waveOutEvent.Init(_mediaFoundationReader);
                _waveOutEvent.Play();
                _actualPlay = webRadio;
            } 
        }


        public void Stop()
        {
            _waveOutEvent.Stop();
            _waveOutEvent.Dispose();
            _mediaFoundationReader.Dispose();
            _actualPlay = null;
        }
    }
}
