using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using boolean = System.Boolean;
    using @string = System.String;
    /// <summary>
    /// 任务实体 用来创建任务
    /// </summary>
    public class quest:agent
    {
        public List<questitem> items = new List<questitem>();
        public @string title = "";
        public @string description = "";
        public boolean isEnabled = true;
        public boolean isFailed = false;
        public boolean completed = false;
        public boolean required = true;
        public boolean isDiscoverd = true;
    }
}
