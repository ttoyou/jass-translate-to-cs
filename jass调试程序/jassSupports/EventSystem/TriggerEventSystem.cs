using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    using integer = System.Int32;
    using real = System.Single;
    using boolean = System.Boolean;
    using @string = System.String;
    using code = System.Delegate;
    public static partial class TriggerEventSystem
    {
        public static void SendEvent()
        {
            CurrentEvent = new Extra.TEvent();
            foreach(trigger t in RuntimeRecorder.Recorder.Triggers)
                //检查并触发所有触发器
            {

            }
        }

        public static void SendChatEvent(integer eventPlayer,@string message)
        {
            CurrentEvent = new Extra.TEvent();
            foreach (trigger t in RuntimeRecorder.Recorder.Triggers)
            //检查并触发所有触发器
            {
                foreach(@event e in t.events)
                {
                    if (e.chatMatchMessage != null)
                    {
                        if (message.Contains(e.chatMatchMessage))
                        {
                            foreach (triggeraction ta in t.actions)
                            {
                                ta.Invoke();
                            }
                        }
                    }
                }
            }
        }

    }
}
