using System;
using System.Collections.Generic;
using System.Text;

namespace NabazRemote.Controllers.ViewInterfaces
{
    public interface NabaztagView
    {
        void AttachController(NabaztagController controller);
        void Refresh();
    }
}
