using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAdminApp.Models
{
    public class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }


        public override string ToString()
        {
            return Title + " - " + Date.ToShortDateString();
        }
        public Event(string title, string description, DateTime date, string type, string priority)
        {
            Title = title;
            Description = description;
            Date = date;
            Type = type;
            Priority = priority;
        }
        public Event() { }
    }
}

