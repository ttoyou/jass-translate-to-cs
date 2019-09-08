using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using real = System.Single;
    using @string = System.String;
    using integer = System.Int32;
    using boolean = System.Boolean;

    public class unit : widget
    {
        public unit() : base()
        {
            RuntimeRecorder.Recorder.Units.Add(this);
        }

        public boolean canSleep = true;
        public boolean isPaused = false;
        public boolean isInvulnerable = false;
        public boolean showed = true;
        public boolean isSleeping = false;
        public boolean ignoreAlarm=false;
        public boolean useFood = true;
        public player owner;
        public integer unitid;

        #region LoactionAndMoving
        public real speed;
        public real facing;
        public real FlyHeight;
        public integer userData = 0;
        #endregion

        #region heroData
        public integer strength = 0;
        public integer agility = 0;
        public integer intelligence = 0;

        public integer level = 0;
        public integer XP = 0;
        #endregion

        public real scaleX = 1;
        public real scaleY = 1;
        public real scaleZ = 1;
        public item[] slots = new item[6];

        public playercolor color;
    }
}