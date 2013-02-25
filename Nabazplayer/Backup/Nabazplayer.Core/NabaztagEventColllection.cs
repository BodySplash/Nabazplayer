using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core
{
    public class NabaztagEventColllection : NabaztagEvent
    {
        public NabaztagEventColllection()
        {
            events = new List<NabaztagEvent>();
        }

        public void AddEvent(NabaztagEvent newEvent)
        {
            if (!events.Contains(newEvent))
            {
                events.Add(newEvent);
            }
        }

        public override string GetEventString()
        {
            string retour = "";

            foreach (NabaztagEvent element in events)
            {
                retour += "&" + element.GetEventString();
            }

            retour = retour.Substring(1, retour.Length - 1);

            return retour;
        }


        private IList<NabaztagEvent> events;
    }
}
