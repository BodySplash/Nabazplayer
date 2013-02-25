using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core.Events
{
    public class ActionEvent : NabaztagEvent
    {
        

        public ActionType Action
        {
            get { return action; }
        }

        public ActionEvent(ActionType action)
        {
            this.action = action;
        }

        public override string GetEventString()
        {
            return string.Format("action={0}", ((int)action).ToString());
        }


        private ActionType action;

        
    }
}
