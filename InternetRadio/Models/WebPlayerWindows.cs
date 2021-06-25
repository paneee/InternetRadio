using NAudio.Wave;
using System;

namespace InternetRadio.Models
{
    public class WebPlayerWindows : IWebPlayer
    {
        private MediaFoundationReader _mediaFoundationReader;
        private WaveOutEvent _waveOutEvent; 
        private string _actualPlay;
        private string _lastPlay;
        private float volumeBigStep = 0.2f;
        private float volumeSmallStep = 0.05f;

        private bool Validate()
        {
            if(_waveOutEvent != null)
            {
                return true;
            }
            else
            {
                return false;
            }     
        }
        public string GetActualPlay()
        {
            return _actualPlay;
        }

        public string GetLastPlay()
        {
            return _lastPlay;
        }

        public void Play(string urlWebRadio)
        {
            if(Validate())
            {
                _lastPlay = _actualPlay;
                _waveOutEvent.Stop();
                _waveOutEvent.Dispose();
                _mediaFoundationReader.Dispose();
                _mediaFoundationReader = new MediaFoundationReader(urlWebRadio);
                _waveOutEvent = new WaveOutEvent();
                _waveOutEvent.Init(_mediaFoundationReader);
                _waveOutEvent.Play();
                _actualPlay = urlWebRadio;
            }
            else
            {
                if(urlWebRadio != null)
                {
                    _mediaFoundationReader = new MediaFoundationReader(urlWebRadio);
                    _waveOutEvent = new WaveOutEvent();
                    _waveOutEvent.Init(_mediaFoundationReader);
                    _waveOutEvent.Play();
                    _actualPlay = urlWebRadio;
                }
            } 
        }


        public void Stop()
        {
            if (Validate())
            {
                _waveOutEvent.Stop();
                _waveOutEvent.Dispose();
                _mediaFoundationReader.Dispose();
                _actualPlay = null;
            }
        }

        public int ActualVolume()
        {
            return Convert.ToInt16(100 * _waveOutEvent.Volume);
        }

        public void VolumeDown()
        {
            if (Validate())
            {
                if (_waveOutEvent.Volume - volumeSmallStep >= 0)
                {
                    _waveOutEvent.Volume = _waveOutEvent.Volume - volumeSmallStep;
                }
                else
                {
                    _waveOutEvent.Volume = 0;
                }
            }
        }

        public void VolumeDownDown()
        {
            if (Validate())
            {
                if (_waveOutEvent.Volume - volumeBigStep >= 0)
                {
                    _waveOutEvent.Volume = _waveOutEvent.Volume - volumeBigStep;
                }
                else
                {
                    _waveOutEvent.Volume = 0;
                }
            }
        }

        public void VolumeUp()
        {
            if (Validate())
            {
                if (_waveOutEvent.Volume + volumeSmallStep <= 1)
                {
                    _waveOutEvent.Volume = _waveOutEvent.Volume + volumeSmallStep;
                }
                else
                {
                    _waveOutEvent.Volume = 1;
                }
            }
        }

        public void VolumeUpUp()
        {
            if (Validate())
            {
                if (_waveOutEvent.Volume + volumeBigStep <= 1)
                {
                    _waveOutEvent.Volume = _waveOutEvent.Volume + volumeBigStep;
                }
                else
                {
                    _waveOutEvent.Volume = 1;
                }
            }
        }
    }
}
