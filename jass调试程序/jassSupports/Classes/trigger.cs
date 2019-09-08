using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using boolean = System.Boolean;
    public class trigger : agent
    {
        public boolean isEnabled = true;
        public List<@event> events = new List<@event>();
        public List<triggercondition> conditions = new List<triggercondition>();
        public List<triggeraction> actions = new List<triggeraction>();

    }
}