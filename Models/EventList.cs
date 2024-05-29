using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using EventAdminApp.Views;

namespace EventAdminApp.Models
{
    public class EventList
    {
        public List<Event> list = new List<Event>();
        public List<Event> filtered = new List<Event>();

        public void Serialize()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Plik XML|*.xml|Wszystkie pliki|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Event>));
                using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    xml.Serialize(fileStream, list);
                }
            }
        }

        public void Deserialize()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                list.Clear();
                XmlSerializer serializer = new XmlSerializer(typeof(List<Event>), new XmlRootAttribute("ArrayOfEvent"));
                using (Stream reader = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    var x = (List<Event>)serializer.Deserialize(reader);
                    foreach (Event p in x)
                    {
                        list.Add(p);
                    }
                }
            }
        }

        public void SortBy(string sortBy)
        {
            switch (sortBy)
            {
                case "Date":
                    list = list.OrderBy(e => e.Date).ToList();
                    break;
                case "Type":
                    list = list.OrderBy(e => e.Type).ToList();
                    break;
                case "Priority":
                    list = list.OrderBy(e => e.Priority == "Wysoki" ? 0 : e.Priority == "Średni" ? 1 : 2).ToList();
                    break;
                default:
                    break;
            }
        }

        public void Filter(string filter, string value)
        {
            filtered.Clear();
            switch (filter)
            {
                case "Type":
                    foreach (Event e in list)
                    {
                        if (e.Type == value)
                        {
                            filtered.Add(e);
                            filtered.ToList();
                        }
                    }
                    break;
                case "Priority":
                    foreach (Event e in list)
                    {
                        if (e.Priority == value)
                        {
                            filtered.Add(e);
                            filtered.ToList();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        public void Filter(string filter, DateTime value)
        {
            filtered.Clear();
            switch (filter)
            {
                case "Date":
                    foreach (Event e in list)
                    {
                        if (e.Date.Date == value.Date)
                        {
                            filtered.Add(e);
                            filtered.ToList();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        public EventList() { }
    }
}
