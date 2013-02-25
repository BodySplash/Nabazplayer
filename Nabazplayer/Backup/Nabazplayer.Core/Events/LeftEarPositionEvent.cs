using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core.Events
{
    public class LeftEarPositionEvent : NabaztagEvent
    {
        public LeftEarPositionEvent(int position)
        {
            if (position < 0 || position > 16)
            {
                throw new ArgumentException("position must be between 0 and 16");
            }
            this.position = position;
        }

        public override string GetEventString()
        {
            return "posleft=" + position.ToString();
        }

        private int position;
    }
}
