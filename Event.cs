using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourlyPromptWF
{
    class Event
    {

        public DateTime DueDateTime { get; set; }
        public EventType Type { get; set; }

        public Event(DateTime dueDateTime, EventType type)
        {
            this.DueDateTime = dueDateTime;
            this.Type = type;
        }


    }
}
