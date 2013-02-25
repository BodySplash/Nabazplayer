using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core.Events
{
    /// <summary>
    /// Describe a led action in a choregraphy
    /// </summary>
    public class ChoregraphyLedCommand : ChoregraphyCommand
    {
        #region *********************** Properties ***********************

        public NabaztagLed Led
        {
            get { return led; }
            set { led = value; }
        }

        #endregion

        #region *********************** Constructors ***********************

        public ChoregraphyLedCommand(NabaztagLed led, int time)
            : base("led")
        {
            this.led = led;
            this.Time = time;
        }

        #endregion

        #region *********************** Methods ***********************

        protected override string GetCommandStringCore()
        {
            return string.Format("{0},{1},{2},{3}", ((int)led.LedPosition).ToString(), led.LedColor.R.ToString(), led.LedColor.G.ToString(), led.LedColor.B.ToString());
        }

        #endregion

        #region *********************** attributes ***********************

        private NabaztagLed led;

        #endregion
    }
}
