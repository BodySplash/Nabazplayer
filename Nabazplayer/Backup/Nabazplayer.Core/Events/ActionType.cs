using System;
using System.Collections.Generic;
using System.Text;

namespace Nabazplayer.Core.Events
{
    public enum ActionType
    {
        PreviewTtsOrMusic = 1,
        GetListOfFriends = 2,
        GetInboxContent = 3,
        GetTimeZone = 4,
        GetSignature = 5,
        GetBlacklist = 6,
        GetStatus = 7,
        GetVersion = 8,
        GetTtsVoices = 9,
        GetName = 10,
        GetSelectedLanguages = 11,
        GetPreviewMessage = 12,
        FallAsleep = 13,
        WakeUp = 14
    }
}
