using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core.Events
{
    public class SendMessageEvent : NabaztagEvent
    {

        public SendMessageEvent(int idMessage)
        {
            this.idMessage = idMessage;
        }

        public override string GetEventString()
        {
            return "idmessage=" + idMessage.ToString();
        }


        private int idMessage;
    }
}
