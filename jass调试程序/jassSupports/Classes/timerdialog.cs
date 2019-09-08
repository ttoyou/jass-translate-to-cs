using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using boolean = System.Boolean;
    using @string = System.String;
    public class timerdialog:agent
    {
        public boolean isDisplayed = true;
        public @string title = "";
        public timer hookedtimer;
    }
}