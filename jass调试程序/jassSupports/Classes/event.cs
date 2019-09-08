using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using integer = System.Int32;
    using real = System.Single;
    using boolean = System.Boolean;
    using @string = System.String;
    using code = System.Delegate;
    public class @event:agent
    {
        public unitevent unitevent;

        public unit sourceUnit;
        public player sourcePlayer;
        public dialog sourceDialog;
        public button sourceDialogButton;
        public timer sourceTimer;
        public trackable sourceTrackable;

        public real timerEventTime;
        public boolean timerEventPeriodic;

        public @string chatMatchMessage;
        public playerevent playerEvent;
        public gameevent gameEvent;
        public limitop unitStateEvent;
        public playerstate playerStateEvent;
        public playerunitevent playerUnitEvent;
        public gamestate gamestateEvent;

    }
}