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
    public class triggeraction:handle
    {
        public code action;
        public void Invoke()
        {
            action.DynamicInvoke();
        }
    }
}
