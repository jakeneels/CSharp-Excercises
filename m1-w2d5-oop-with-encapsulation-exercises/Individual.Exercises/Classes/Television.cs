using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }

        public Television()
        {
            IsOn = false;
            CurrentVolume = 2;
            CurrentChannel = 3;
        }
        public Television(bool isOn, int channel, int volume)
        {
            IsOn = isOn;
            CurrentChannel = channel;
            CurrentVolume = volume;
        }

        public void TurnOff() => IsOn = false;
        public void TurnOn()
        {
            IsOn = true;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }
        public void ChangeChannel(int newChannel)
        {
            if (IsOn && newChannel <= 18 && newChannel >= 3)
            {
                CurrentChannel = newChannel;
            }
            else
            {
                CurrentChannel = 3;
            }
        }
        public void ChannelUp() {
            if (IsOn && CurrentChannel < 18)
                CurrentChannel++;
            else
                CurrentChannel = 3;
        }
        public void ChannelDown()
        {
            if (IsOn && CurrentChannel > 3)
                CurrentChannel--;
            else if (IsOn && CurrentChannel == 3)
                CurrentChannel = 18;
            else
                CurrentChannel = 3;
        }
        public void RaiseVolume()
        {
            if (IsOn && CurrentVolume < 10)
                CurrentVolume++;
            else
                CurrentVolume = 2;
        }
        public void LowerVolume()
        {
            if (IsOn && CurrentVolume >= 1)
                CurrentVolume--;
            
        }
    }
}
