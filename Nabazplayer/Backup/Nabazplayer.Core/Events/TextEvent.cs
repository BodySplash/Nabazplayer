using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core.Events
{
    public class TextEvent : NabaztagEvent
    {
        public enum VoiceType
        {
            julie22k,
            claire22s,
            caroline22k,
            bruno22k
        }

        #region *********************** properties ***********************

        public string Message
        {
            get { return message; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public VoiceType Voice
        {
            get { return voice; }
            set { voice = value; }
        }

        public int Pitch
        {
            get { return pitch; }
            set { pitch = value; }
        }

        #endregion

        #region *********************** Constructors ***********************

        public TextEvent(string message)
        {
            this.message = message;
            speed = 100;
            voice = VoiceType.claire22s;
            pitch = 100;
        }

        public TextEvent(string message, VoiceType voice)
        {
            this.message = message;
            this.voice = voice;
            speed = 100;
        }

        public TextEvent(string message, VoiceType voice, int speed)
        {
            this.message = message;
            this.voice = voice;
            this.speed = speed;
            pitch = 100;
        }

        public TextEvent(string message, VoiceType voice, int speed, int pitch)
        {
            this.message = message;
            this.voice = voice;
            this.speed = speed;
            this.pitch = pitch;
        }

        #endregion

        #region *********************** Methods ***********************

        public override string GetEventString()
        {
            return string.Format("tts={0}&speed={1}&voice={2}&pitch={3}", message, speed.ToString(), voice.ToString(), pitch.ToString());
        }

        #endregion

        #region *********************** Attributes ***********************

        private string message;
        private int speed;
        private VoiceType voice;
        private int pitch;

        #endregion

    }
}
