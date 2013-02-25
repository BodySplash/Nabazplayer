using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Nabazplayer.Core
{
    /// <summary>
    /// Describe a led
    /// </summary>
    public class NabaztagLed
    {
        public enum Position
        {
            bottom = 0,
            left,
            middle,
            right,
            high
        }

        #region *********************** Properties ***********************

        public Color LedColor
        {
            get { return color; }
            set { color = value; }
        }

        public Position LedPosition
        {
            get { return position; }
        }

        #endregion

        #region *********************** Constructors ***********************

        internal NabaztagLed()
        {
            position = Position.bottom;
            color = Color.White;
        }

        internal NabaztagLed(Position position, Color color)
        {
            this.position = position;
            this.color = color;
        }

        #endregion

        #region *********************** Methods ***********************

        public NabaztagLed WithColor(Color color)
        {
            return new NabaztagLed(position, color);
        }

        #endregion

        #region *********************** attributes ***********************

        private Color color;
        private Position position;

        #endregion
    }
}
