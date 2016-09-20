using System;

namespace _07_Timer
{
    internal class Timer
    {
        public int Seconds = 0;
        
        public override string ToString()
        {
            var time = TimeSpan.FromSeconds(Seconds);
            return time.ToString(@"hh\:mm\:ss");
        }

        internal string Padded(int input)
        {
            return input.ToString("00");
        }
    }
}