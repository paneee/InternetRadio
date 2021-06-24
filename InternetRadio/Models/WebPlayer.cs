using NAudio.Wave;

namespace InternetRadio.Models
{
    public class WebPlayer : IWebPlayer
    {
        private MediaFoundationReader _mediaFoundationReader;
        private WaveOutEvent _waveOutEvent; 
        private string _actualPlay;
        private string _lastPlay;

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
            if(_waveOutEvent == null)
            {
                _mediaFoundationReader = new MediaFoundationReader(urlWebRadio);
                _waveOutEvent = new WaveOutEvent();
                _waveOutEvent.Init(_mediaFoundationReader);
                _waveOutEvent.Play();
                _actualPlay = urlWebRadio;
            }
            else
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
        }


        public void Stop()
        {
            _waveOutEvent.Stop();
            _waveOutEvent.Dispose();
            _mediaFoundationReader.Dispose();
            _actualPlay = null;
        }

        public void VolumeDown()
        {
            _waveOutEvent.Volume = 0;
        }

        public void VolumeDownDown()
        {
            _waveOutEvent.Volume = 0;
        }

        public void VolumeUp()
        {
            _waveOutEvent.Volume = _waveOutEvent.Volume + 1;
        }

        public void VolumeUpUp()
        {
            _waveOutEvent.Volume = _waveOutEvent.Volume + 15;
        }
    }
}
