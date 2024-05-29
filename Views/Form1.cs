using EventAdminApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EventAdminApp.Views
{
    public partial class Form1 : Form
    {
        public EventList eventlist = new EventList();
        public Form1()
        {
            InitializeComponent();
            listBox1.DrawMode = DrawMode.OwnerDrawFixed; 
            listBox1.DrawItem += ListBox1_DrawItem; 
        }
        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();


            Event eve = (Event)listBox1.Items[e.Index];

            if (eve.Type == "Praca")
            {
                e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
            }
            else if (eve.Type == "Rodzina")
            {
                e.Graphics.FillRectangle(Brushes.MediumPurple, e.Bounds);
            }
            else if (eve.Type == "Zdrowie")
            {
                e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
            }
            else if (eve.Type == "Rozrywka")
            {
                e.Graphics.FillRectangle(Brushes.Orange, e.Bounds);
            }
            else if (eve.Type == "Sport")
            {
                e.Graphics.FillRectangle(Brushes.LawnGreen, e.Bounds);
            }
            else if(eve.Type == "Inny")
            {
                e.Graphics.FillRectangle(Brushes.LemonChiffon, e.Bounds);
            }
            
            var itemText = listBox1.Items[e.Index].ToString();
            e.Graphics.DrawString(itemText, e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }

        public event Action AddEvent;
        public event Action<int> SelectEvent;
        public event Action<int> DeleteEvent;

        public void selectEvent(object sender, EventArgs e)
        {
            var listbox = sender as ListBox;
            int index = listbox.SelectedIndex;
            SelectEvent?.Invoke(index);
        }

        public void addToListBox()
        {
            listBox1.Items.Clear();
            foreach ( var x in eventlist.list )
            {
                listBox1.Items.Add(x);
            }
        }

        private void addEvent(object sender, EventArgs e)
        {
            AddEvent?.Invoke();
        }

        private void serialize_list(object sender, EventArgs e)
        {
            eventlist.Serialize();
        }

        private void deserialize_list(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            eventlist.Deserialize();
            foreach ( var x in eventlist.list )
            {
                listBox1.Items.Add(x);
            }
        }

        public DateTime getDate
        {
            get
            {
                return DateBox.Value;
            }
        }
         public void setFormValues(string title, string description, DateTime date, string type, string priority)
        {
            TitleBox.Text = title;
            DescriptionBox.Text = description;
            DateBox.Value = date;
            TypeBox.Text = type;
            PriorBox.Text = priority;
        }

        public string getTitle()
        {
            return TitleBox.Text;
        }

        public string getDescription()
        {
            return DescriptionBox.Text;
        }

        public string getType()
        {
            return TypeBox.Text;
        }

        public string getPriority()
        {
            return PriorBox.Text;
        }

        public void deleteEvent(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            DeleteEvent?.Invoke(index);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void SortType_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            eventlist.SortBy("Type");
            foreach (var x in eventlist.list)
            {
                listBox1.Items.Add(x);
            }
        }

        public void SortPrior_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            eventlist.SortBy("Priority");
            foreach (var x in eventlist.list)
            {
                listBox1.Items.Add(x);
            }
        }

        public void SortDate_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            eventlist.SortBy("Date");
            foreach (var x in eventlist.list)
            {
                listBox1.Items.Add(x);
            }
        }

        private void FilterPrior_Click(object sender, EventArgs e)
        {
            string value = PriorBoxFilter.Text;
            listBox1.Items.Clear();
            eventlist.Filter("Priority", value);
            foreach (var x in eventlist.filtered)
            {
                listBox1.Items.Add(x);
            }
        }

        private void FilterDate_Click(object sender, EventArgs e)
        {
            DateTime value = DateBoxFilter.Value;
            listBox1.Items.Clear();
            eventlist.Filter("Date", value);
            foreach (var x in eventlist.filtered)
            {
                listBox1.Items.Add(x);
            }
        }

        private void FilterType_Click(object sender, EventArgs e)
        {
            string value = TypeBoxFilter.Text;
            listBox1.Items.Clear();
            eventlist.Filter("Type", value);
            foreach (var x in eventlist.filtered)
            {
                listBox1.Items.Add(x);
            }
        }        
    }
}
