using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetRadio.Models
{
    public class WebPlayerRaspbian : IWebPlayer
    {

        private string LinuxCommand(string[] arguments)
        {
            arguments = ;
            using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
            {
                proc.StartInfo.FileName = arguments[0];
                proc.StartInfo.Arguments = arguments[1];
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.Start();
                proc.WaitForExit();
                return proc.StandardOutput.ReadToEnd();
            }
        }
        public int ActualVolume()
        {
            throw new NotImplementedException();
        }

        public string GetActualPlay()
        {
            throw new NotImplementedException();
        }

        public string GetLastPlay()
        {
            throw new NotImplementedException();
        }

        public void Play(string urlWebRadio)
        {
            LinuxCommand(new string[] { "mpc", "clear" });
            LinuxCommand(new string[] { "mpc", "add " + urlWebRadio });
            LinuxCommand(new string[] { "mpc", "play" });
        }

        public void Stop()
        {
            LinuxCommand(new string[] { "mpc", "stop" });
            LinuxCommand(new string[] { "mpc", "clear"});
        }

        public void VolumeDown()
        {
            LinuxCommand(new string[] { "mpc", "volume -10" });
        }

        public void VolumeDownDown()
        {
            LinuxCommand(new string[] { "mpc", "volume -20" });
        }

        public void VolumeUp()
        {
            LinuxCommand(new string[] { "mpc", "volume +10" });
        }

        public void VolumeUpUp()
        {
            LinuxCommand(new string[] { "mpc", "volume +20" });
        }
    }
}
