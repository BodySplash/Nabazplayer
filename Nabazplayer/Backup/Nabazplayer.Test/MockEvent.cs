using System;
using System.Collections.Generic;
using System.Text;
using Nabazplayer.Core;

namespace Nabazplayer.Test
{
    public class MockEvent : NabaztagEvent
    {
        public override string GetEventString()
        {
            return "ears=ok";
        }
    }
}
