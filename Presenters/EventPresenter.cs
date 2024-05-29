using EventAdminApp.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;

namespace EventAdminApp.Presenters
{
    class EventPresenter
    {
        private Views.Form1 _view;
        private Models.EventList _model;
        public EventPresenter(Views.Form1 view, Models.EventList model)
        {
            _view = view;
            _model = model;
            _view.AddEvent += _view_AddEvent;
            _view.SelectEvent += _view_SelectEvent;
            _view.DeleteEvent += _view_DeleteEvent;

        }
        private void _view_AddEvent()
        {
            if (String.IsNullOrEmpty(_view.getTitle()) || String.IsNullOrEmpty(_view.getDescription()) || String.IsNullOrEmpty(_view.getType()))
            {
                MessageBox.Show("Proszę wpisać tekst w puste pola");
            }
            else
            {
                Event eve = new Event(_view.getTitle(), _view.getDescription(), _view.getDate, _view.getType(), _view.getPriority());
                _view.eventlist.list.Add(eve);
                _view.addToListBox();
            }
        }
        private void _view_SelectEvent(int index)
        {
            if (index >= 0 && index < _view.eventlist.list.Count)
            {
                var eve = _view.eventlist.list.ElementAt(index);
                _view.setFormValues(eve.Title, eve.Description, eve.Date, eve.Type, eve.Priority);
            }
        }

        private void _view_DeleteEvent(int index)
        {
            if (index >= 0 && index < _view.eventlist.list.Count)
            {
                _view.eventlist.list.RemoveAt(index);
                _view.addToListBox();
            }
        }
    }
}
